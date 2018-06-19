/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 14/03/2018
 * Hora: 11:54 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Areas {
    /// <summary>
    /// Description of ListarAreas.
    /// </summary>
    public partial class ListarAreas:Form, ICerrar {

		private static ListarAreas instancia = null;

		private ControladorAreas cAreas = new ControladorAreas();

        private string vigenciaFiltrada = "Todas";
        private string textoBusqueda;
		private IEnumerable<Area> areasFiltradas = new List<Area>();
		private IEnumerable<Area> areasRegistradasSinFiltro = new List<Area>();

		private DataTable tabla;

		private Area areaSeleccionada;

		private ListarAreas() {
			InitializeComponent();
			CrearTabla();
			ActualizarRegistros();
			radioTodos.Checked = true;
			if (SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador ||
                SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Verificador){
				btnEditar.Enabled = true;
				btnEliminar.Enabled = true;
			}
			tablaDatos.DataSource = tabla;
			tablaDatos.Columns["Id"].Visible = false;

			areaSeleccionada = areasFiltradas.FirstOrDefault();
			tablaDatos.ContextMenuStrip = CrearMenuContextual();
		}

		public static ListarAreas GetInstancia() {
			if (instancia == null){
				instancia = new ListarAreas();
			}
			return instancia;
		}
		
		private ContextMenuStrip CrearMenuContextual(bool seleccion = false){			
			ContextMenuStrip ctxMenuStrip = new ContextMenuStrip();
			if(!seleccion || SesionDeUsuario.PermisoUsuario() != EnumPermisoUsuario.Administrador
                && SesionDeUsuario.PermisoUsuario() != EnumPermisoUsuario.Verificador) {
				ctxMenuStrip.Items.Add("No hay acciones disponibles", Properties.Resources.imagen_no_disponible);
			} else {
				ctxMenuStrip.Items.Add("Editar", Properties.Resources.imagen_editar, BtnEditar_Click);
				ctxMenuStrip.Items.Add("Eliminar", Properties.Resources.imagen_eliminar, BtnEliminarClick);
			}
			return ctxMenuStrip;
		}

       #region Datos
       private void FiltrarTabla() {
            areasFiltradas = FiltrarVigencia(vigenciaFiltrada, areasRegistradasSinFiltro.ToList());
            LlenarTabla();
        }

        private List<Area> FiltrarVigencia(string vigencia, List<Area> areasSinFiltrar) {
            switch(vigencia) {
                case "Solo Vigentes":
                    return areasRegistradasSinFiltro.Where(a => a.FechaNoVigente == null).OrderBy(a => a.NombreDeArea).ToList();

                case "Solo No Vigentes":
                    return areasRegistradasSinFiltro.Where(a => a.FechaNoVigente != null).OrderBy(a => a.NombreDeArea).ToList();

                default:
                    return areasRegistradasSinFiltro.OrderBy(a => a.NombreDeArea).ToList();
            }
        }

        private void GrupoVigenciaChange_Click(object sender, EventArgs e) {
			vigenciaFiltrada = (sender as RadioButton).Text;
            FiltrarTabla();			
		}
		
		private void CrearTabla() {
			tabla = new DataTable();
			tabla.Columns.Add("Id", typeof(int));
			tabla.Columns.Add("Nombre del Area", typeof(string));
			tabla.Columns.Add("Vigente", typeof(string));
			tabla.Columns.Add("Fecha No Vigencia", typeof(DateTime));
		}

		private void LlenarTabla() {
			if (tabla.Rows.Count != 0){
				tabla.Clear();
			}
			foreach (Area area in areasFiltradas){
				string vigencia = "Si";
				if (area.FechaNoVigente != null){
					vigencia = "No";
				}
				tabla.Rows.Add(area.AreaId,
				               area.NombreDeArea,
				               vigencia,
				               area.FechaNoVigente.GetValueOrDefault().Date);
			}
		}

        public void ActualizarRegistros() {
            areasFiltradas = cAreas.ListarAreas().OrderBy(a => a.NombreDeArea);
            areasRegistradasSinFiltro = cAreas.ListarAreas().OrderBy(a => a.NombreDeArea);
            areaSeleccionada = areasFiltradas.FirstOrDefault();
            LlenarTabla();
        }

        #endregion
        
        #region Busqueda
        private List<Area> BuscarNombre(string texto, List<Area> areasABuscar) {
                return areasABuscar.Where(a => a.NombreDeArea.ToLower().Contains(texto.ToLower()))
                        .OrderBy(a => a.NombreDeArea).ToList();
        }

        private void BtnBuscar_Click(object sender, EventArgs e) {
            textoBusqueda = txtBuscarNombre.Text;
            areasFiltradas = BuscarNombre(textoBusqueda, areasFiltradas.ToList());
            LlenarTabla();
        }

        private void BtnQuitarFiltroNombreClick(object sender, EventArgs e) {
            txtBuscarNombre.Clear();
            textoBusqueda = "";
            FiltrarTabla();
        }
        #endregion

        #region Acciones
        private void BtnEditar_Click(object sender, EventArgs e) {
            if(areaSeleccionada != null) {
                Form editarAreaForm = EditarArea.GetInstancia(areaSeleccionada);
                editarAreaForm.MdiParent = this.MdiParent;
                editarAreaForm.Show();
                editarAreaForm.BringToFront();
            } else {
                MessageBox.Show("No hay area seleccionada");
            }
        }

        private void BtnEliminarClick(object sender, EventArgs e) {
			if (areaSeleccionada != null){
				if(MessageBox.Show("Seguro que quiere eliminar el area seleccionada? \n" +
				                   "Esta accion no se puede deshacer.", "Eliminar Area?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
					if(!cAreas.EliminarArea(areaSeleccionada.AreaId)) {
						MessageBox.Show("No se pudo eliminar el Area.");
					} else {
						ActualizarRegistros();
						MessageBox.Show("El área fue eliminada");
					}
				}
			} else{
				MessageBox.Show("No hay area seleccionada");
			}
		}
        #endregion

        public override void Refresh() {
			base.Refresh();
			ActualizarRegistros();
		}
		
		private void ListarAreasFormFormClosing(object sender, FormClosingEventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			instancia = null;
		}
		
		#region ICerrar implementation
		public void CerrarInstancia() {
			instancia = null;
		}
		
		private void TablaDatosMouseDown(object sender, MouseEventArgs e) {
			int currentMouseOverRow = (sender as DataGridView).HitTest(e.X,e.Y).RowIndex;
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
				areaSeleccionada = areasFiltradas.Single(a => a.AreaId == (int)(tabla.Rows[filaActual].Cells[0].Value));
				if (SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador &&
				    !areaSeleccionada.EspecificacionesDeMuestras.Any()){
					btnEliminar.Enabled = true;
				}
				tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
			} catch (Exception){}
		}
		
		private void TablaDatosRowEnter(object sender, DataGridViewCellEventArgs e) {
			int currentMouseOverRow = e.RowIndex;
			CambioFila(sender as DataGridView, currentMouseOverRow);
		}

        #endregion
    }
}