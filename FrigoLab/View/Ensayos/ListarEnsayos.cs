/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 24/03/2018
 * Hora: 10:40 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Ensayos {
    /// <summary>
    /// Description of ListarEnsayos
    /// </summary>
    public partial class ListarEnsayos : Form, ICerrar{
		private static ListarEnsayos instancia;
		
		private ControladorEnsayos cEnsayos = new ControladorEnsayos();
		
		private IEnumerable<Ensayo> ensayosRegistrados;
		private IEnumerable<Ensayo> ensayosSinFiltro;

		private DataTable tabla;
		
		private Ensayo ensayoSeleccionado;
		private EnumClaseMuestra claseMuestra;
		
		private ListarEnsayos(){
			InitializeComponent();
			CrearTabla();
			ActualizarRegistros();
			
			// Botones de Accion por permiso de usuario
			if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador ||
                SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Verificador) {
				btnEditar.Enabled = true;
				btnEliminar.Enabled = true;
			}

			// Clase de Muestra
			foreach(RadioButton radio in grupoClaseMuestra.Controls) {
				radio.CheckedChanged += GrupoClaseMuestra_Checked;
			}
			radioTodas.Checked = true;
			
			// Tabla de datos
			tablaDatos.DataSource = tabla;
			tablaDatos.Columns["Id"].Visible = false;
			
			ensayoSeleccionado = ensayosRegistrados.FirstOrDefault();
			
			tablaDatos.ContextMenuStrip = CrearMenuContextual();
		}
		
		public static ListarEnsayos GetInstancia(){
			if(instancia == null){
				instancia = new ListarEnsayos();
			}
			return instancia;
		}
		
		private void CrearTabla() {
			tabla = new DataTable();
			tabla.Columns.Add("Id", typeof(int));
			tabla.Columns.Add("Nombre de Ensayo", typeof(string));
			tabla.Columns.Add("Muestra", typeof(EnumClaseMuestra));
			tabla.Columns.Add("Metodo de Ensayo", typeof(string));
			tabla.Columns.Add("Tipo", typeof(string));
		}

		private void LlenarTabla() {
			if(tabla.Rows.Count != 0) {
				tabla.Clear();
			}
			foreach(Ensayo esp in ensayosRegistrados) {
				tabla.Rows.Add(esp.EnsayoId,
				               esp.NombreDeEnsayo,
				               esp.ClaseDeMuestra,
				               esp.MetodoDeEnsayo,
				               esp.TipoDeAnalisis.ToString());
			}
		}
		
		private ContextMenuStrip CrearMenuContextual(bool seleccion = false){
			ContextMenuStrip ctxMenuStrip = new ContextMenuStrip();
			if(!seleccion || SesionDeUsuario.PermisoUsuario() != EnumPermisoUsuario.Administrador 
                && SesionDeUsuario.PermisoUsuario() != EnumPermisoUsuario.Verificador ){
				ctxMenuStrip.Items.Add("No hay acciones disponibles", Properties.Resources.imagen_no_disponible);
			} else {
				ctxMenuStrip.Items.Add("Editar", null, BtnEditar_Click);
				ctxMenuStrip.Items.Add("Eliminar", null, BtnEliminarClick);
			}
			return ctxMenuStrip;
		}
		
		private void BtnEditar_Click(object sender, EventArgs e) {
			if (ensayoSeleccionado != null){
				Form editarEnsayo = EditarEnsayo.GetInstancia(ensayoSeleccionado);
				editarEnsayo.MdiParent = this.MdiParent;
				editarEnsayo.Show();
				editarEnsayo.BringToFront();
			}else{
				MessageBox.Show("No hay ensayo seleccionado.");
			}
		}

		private void GrupoClaseMuestra_Checked(object sender, EventArgs e) {
			if((sender as RadioButton).Checked == true) {
				string texto = (sender as RadioButton).Text;
				if(texto == "Todas") {
					ensayosRegistrados = ensayosSinFiltro.OrderBy(l=>l.NombreDeEnsayo);
					ResetearFiltros();
				} else {
					claseMuestra = (EnumClaseMuestra)Enum.Parse(typeof(EnumClaseMuestra), (sender as RadioButton).Text);
					ensayosRegistrados = ensayosSinFiltro
						.Where(esp => esp.ClaseDeMuestra == claseMuestra)
						.OrderBy(l=>l.NombreDeEnsayo);
					txtBuscarMetodo.Clear();
					txtBuscarNombre.Clear();
					txtBuscarMetodo.Enabled = false;
					txtBuscarNombre.Enabled = false;
				}
				LlenarTabla();
			}
		}

		public void ActualizarRegistros() {
			ensayosRegistrados = cEnsayos.ListarEnsayos().OrderBy(l=>l.NombreDeEnsayo);
			ensayosSinFiltro = cEnsayos.ListarEnsayos().OrderBy(l=>l.NombreDeEnsayo);
			LlenarTabla();
		}

		private void TxtBuscarNombre_TextChanged(object sender, EventArgs e) {
			if(!string.IsNullOrEmpty((sender as TextBox).Text)) {
				txtBuscarMetodo.Clear();
				string texto = (sender as TextBox).Text;
				ensayosRegistrados = ensayosSinFiltro
					.Where(esp => esp.NombreDeEnsayo.ToLower()
					       .Contains(texto.ToLower()))
					.OrderBy(l=>l.NombreDeEnsayo);
				grupoClaseMuestra.Enabled = false;
			} else {
				ensayosRegistrados = ensayosSinFiltro.OrderBy(l=>l.NombreDeEnsayo);
				grupoClaseMuestra.Enabled = true;
				ResetearFiltros();
			}
			LlenarTabla();
		}
		
		private void TxtBuscarMetodo_TextChanged(object sender, EventArgs e) {
			if(!string.IsNullOrEmpty((sender as TextBox).Text)) {
				txtBuscarNombre.Clear();
				string texto = (sender as TextBox).Text;
				ensayosRegistrados = ensayosSinFiltro
					.Where(esp => esp.MetodoDeEnsayo.ToLower()
					       .Contains(texto.ToLower()))
					.OrderBy(l=>l.NombreDeEnsayo);
				grupoClaseMuestra.Enabled = false;
			} else {
				ensayosRegistrados = ensayosSinFiltro.OrderBy(l=>l.NombreDeEnsayo);
				grupoClaseMuestra.Enabled = true;
				ResetearFiltros();
			}
			LlenarTabla();
		}

		private void BtnQuitarFiltroBusquedasClick(object sender, EventArgs e) {
			ResetearFiltros();
		}

		private void ResetearFiltros() {
			txtBuscarNombre.Clear();
			txtBuscarMetodo.Clear();
			txtBuscarMetodo.Enabled = true;
			txtBuscarNombre.Enabled = true;
			ActualizarRegistros();
		}

		private void BtnEliminarClick(object sender, EventArgs e) {
			if (ensayoSeleccionado != null){
				if(MessageBox.Show("Seguro que quiere eliminar el ensayo seleccionado? \n" +
				                   "Esta accion no se puede deshacer.", "Eliminar Ensayo?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
					if(!cEnsayos.ElminarEnsayo(ensayoSeleccionado.EnsayoId)) {
						MessageBox.Show("No se pudo eliminar el Ensayo.");
					} else {
						ActualizarRegistros();
						MessageBox.Show("El Ensayo fue eliminado.");
						SesionDeUsuario.ActualizarFormulariosAbiertos(this);
					}
				}
			}else{
				MessageBox.Show("No hay ensayo seleccionado.");
			}
		}
		
		private void TablaDatosMouseDown(object sender, MouseEventArgs e) {
			int currentMouseOverRow = (sender as DataGridView).HitTest(e.X,e.Y).RowIndex;
			CambioFila(sender as DataGridView, currentMouseOverRow);
		}
		
		private void TablaDatosRowEnter(object sender, DataGridViewCellEventArgs e) {
			int currentMouseOverRow = e.RowIndex;
			CambioFila(sender as DataGridView, currentMouseOverRow);
		}
		
		private void CambioFila(DataGridView tabla, int filaActual){
			if (filaActual >= 0){
				tabla.Rows[filaActual].Selected = true;
				SeleccionarElemento(tabla, filaActual);
			}else{
				tablaDatos.ContextMenuStrip = CrearMenuContextual();
			}
		}
		
		private void SeleccionarElemento(DataGridView tabla, int filaActual){
			try {
				ensayoSeleccionado = ensayosRegistrados.Single(en => en.EnsayoId == (int)(tabla.Rows[filaActual].Cells[0].Value));
				if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador &&
				   !ensayoSeleccionado.AnalisisDelEnsayo.Any()) {
					btnEliminar.Enabled = true;
				}
				tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
			} catch(Exception) { }
		}
		
		private void ListarEnsayosFormFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}
		
		public override void Refresh() {
			base.Refresh();
			ActualizarRegistros();
		}
		
		#region ICerrar implementation
		public void CerrarInstancia() {
			instancia = null;
		}

		#endregion
	}
}
