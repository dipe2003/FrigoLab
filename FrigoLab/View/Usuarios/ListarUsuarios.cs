using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Usuarios;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Usuarios {
    public partial class ListarUsuarios:Form, ICerrar {
		
		private static ListarUsuarios instancia = null;

		private ControladorUsuarios cUsuario = new ControladorUsuarios();

		private IEnumerable<Usuario> usuariosRegistrados = new List<Usuario>();
		private IEnumerable<Usuario> usuariosRegistradosSinFiltro = new List<Usuario>();
		private DataTable tabla;

		private  Usuario usuarioSeleccionado;

		private ListarUsuarios() {
			InitializeComponent();
			CrearTabla();
			ActualizarRegistros();
			radioTodos.Checked = true;
			tablaDatos.DataSource = tabla;
			
			usuarioSeleccionado = usuariosRegistrados.FirstOrDefault();

			tablaDatos.ContextMenuStrip = CrearMenuContextual();

            if(SesionDeUsuario.HaySesionIniciada()) {
                BloquearComponentes(SesionDeUsuario.PermisoUsuario());
            }
        }

		public static ListarUsuarios GetInstancia() {
			if(instancia == null) {
				instancia = new ListarUsuarios();
			}
			return instancia;
		}

		#region ICerrar implementation
		public void CerrarInstancia() {
			instancia = null;
		}
		#endregion

		private void CrearTabla() {
			tabla = new DataTable();
			tabla.Columns.Add("Padron", typeof(int));
			tabla.Columns.Add("Usuario", typeof(string));
			tabla.Columns.Add("Correo", typeof(string));
			tabla.Columns.Add("Permiso", typeof(EnumPermisoUsuario));
			tabla.Columns.Add("Vigente", typeof(string));
			tabla.Columns.Add("Fecha No Vigencia", typeof(DateTime));
		}
		private void LlenarTabla() {
			if(tabla.Rows.Count != 0) {
				tabla.Clear();
			}

			foreach(Usuario usuario in usuariosRegistrados) {
				string vigencia = "Si";
				if(usuario.FechaNoVigente!=null) {
					vigencia = "No";
				}
				tabla.Rows.Add(usuario.UsuarioId,
				               usuario.NombreCompleto,
				               usuario.CorreoDeUsuario,
				               usuario.PermisoDeUsuario,
				               vigencia, usuario.FechaNoVigente.GetValueOrDefault().Date
				              );
			}
		}

		private void BtnEditar_Click(object sender, EventArgs e) {
			if (usuarioSeleccionado != null){
				Form editarUsuarioForm;
				if (SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador){
					editarUsuarioForm = EditarUsuarioAdmin.GetInstancia(usuarioSeleccionado);
				} else {
					editarUsuarioForm = EditarUsuario.GetInstancia(usuarioSeleccionado);
				}
				editarUsuarioForm.MdiParent = this.MdiParent;
				editarUsuarioForm.Show();
				editarUsuarioForm.BringToFront();
			}else{
				MessageBox.Show("No hay usuario seleccionado");
			}
		}

		public void ActualizarRegistros() {
			usuariosRegistrados = cUsuario.ListarUsuarios().OrderBy(u=>u.UsuarioId);
			usuariosRegistradosSinFiltro = cUsuario.ListarUsuarios(true).OrderBy(u=>u.UsuarioId);
			LlenarTabla();
		}

		private ContextMenuStrip CrearMenuContextual(bool seleccion = false){
			ContextMenuStrip ctxMenuStrip = new ContextMenuStrip();
			if(!seleccion){
				ctxMenuStrip.Items.Add("No hay acciones disponibles", Properties.Resources.imagen_no_disponible);
			} else {
                if(usuarioSeleccionado.UsuarioId == SesionDeUsuario.UsuarioLogueado.UsuarioId || SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador) {
                    ctxMenuStrip.Items.Add("Editar", Properties.Resources.imagen_editar_usuario, BtnEditar_Click);
                } else {
                    ctxMenuStrip.Items.Add("No hay acciones disponibles", Properties.Resources.imagen_no_disponible);
                }
			}
			return ctxMenuStrip;
		}
		
		private void GrupoPermisoChange_Click(object sender, EventArgs e) {
			string permiso = (sender as RadioButton).Text;
			switch(permiso) {
				case "Solo Vigentes":
					usuariosRegistrados = usuariosRegistradosSinFiltro
						.Where(u => u.FechaNoVigente==null)
						.OrderBy(u=>u.UsuarioId);
					break;

				case "Solo No Vigentes":
					usuariosRegistrados = usuariosRegistradosSinFiltro
						.Where(a => a.FechaNoVigente!=null)
						.OrderBy(u=>u.UsuarioId);
					break;

				default:
					usuariosRegistrados = usuariosRegistradosSinFiltro.OrderBy(u=>u.UsuarioId);
					break;
			}
			LlenarTabla();
		}

		private void TxtBuscarNombre_TextChanged(object sender, EventArgs e) {
			if(((sender as TextBox).Text).ToLower() != "") {
				TxtBuscarPadron.Clear();
				string texto = (sender as TextBox).Text;
				grupoVigencia.Enabled = false;
				usuariosRegistrados = usuariosRegistradosSinFiltro
					.Where(a => a.NombreCompleto.ToLower()
					       .Contains(texto))
					.OrderBy(u=>u.UsuarioId);
			} else {
				grupoVigencia.Enabled = true;
				usuariosRegistrados = usuariosRegistradosSinFiltro.OrderBy(u=>u.UsuarioId);
			}
			LlenarTabla();
		}

		private void TxtBuscarPadron_TextChanged(object sender, EventArgs e) {
			if((sender as TextBox).Text != "") {
				int padron;
				if(int.TryParse((sender as TextBox).Text, out padron)) {
					txtBuscarNombre.Clear();
					grupoVigencia.Enabled = false;
					usuariosRegistrados = usuariosRegistradosSinFiltro
						.Where(a => a.UsuarioId.ToString()
						       .StartsWith(padron.ToString()))
						.OrderBy(u=>u.UsuarioId);;
				}
			} else {
				grupoVigencia.Enabled = true;
				usuariosRegistrados = usuariosRegistradosSinFiltro.OrderBy(u=>u.UsuarioId);
			}
			LlenarTabla();
		}

		private void BtnBorrarBusqueda_Click(object sender, EventArgs e) {
			txtBuscarNombre.Clear();
			TxtBuscarPadron.Clear();
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
				usuarioSeleccionado = usuariosRegistrados.Single(a => a.UsuarioId == ((int)(tabla.Rows[filaActual].Cells[0].Value)));
				if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador ||
				   SesionDeUsuario.UsuarioLogueado.UsuarioId == usuarioSeleccionado.UsuarioId) {
					btnEditar.Enabled = true;
				} else {
					btnEditar.Enabled = false;
				}
				if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador &&
				   !usuarioSeleccionado.AnalisisRealizados.Any() && !usuarioSeleccionado.AnalisisVerificados.Any() &&
				   !usuarioSeleccionado.MuestreosTomados.Any()) {
					btnEliminar.Enabled = true;
				} else {
					btnEliminar.Enabled = false;
				}
				tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
			} catch(Exception) { }
		}
		
		private void ListarUsuariosFormFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}
		
		public override void Refresh() {
			base.Refresh();
			ActualizarRegistros();
		}
	}
}
