using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrigLab.View.Muestras {
    public partial class ListarMuestras:Form, ICerrar {
        private static ListarMuestras instancia;

        private ControladorMuestras cMuestras = new ControladorMuestras();

        private IEnumerable<EspecificacionDeMuestra> especificacionesFiltradas;
        private IEnumerable<EspecificacionDeMuestra> especificacionesSinFiltro;
        private IEnumerable<Area> areasRegistradas;
        private IEnumerable<Area> areasSinFiltro;
        private DataTable tabla;

        private EspecificacionDeMuestra especificacionSeleccionada;

        private ListarMuestras() {
            InitializeComponent();
            CrearTabla();
            ActualizarRegistros();
            
            foreach(System.Windows.Forms.RadioButton radio in grupoTipo.Controls) {
                radio.CheckedChanged += GrupoTipos_CheckedChanged;
            }
            
            foreach (Control txtbox in grupoBuscar.Controls) {
				if (txtbox is TextBox){
					(txtbox as TextBox).TextChanged += GrupoBuscar_TextChanged;
				}
            }
            
            RadioTodas.Checked = true;
            if(SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador 
                || SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Verificador) {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            tablaDatos.DataSource = tabla;
            tablaDatos.Columns["Id"].Visible = false;
            
			especificacionSeleccionada = especificacionesFiltradas.FirstOrDefault();
			
			tablaDatos.ContextMenuStrip = CrearMenuContextual();
        }

        public static ListarMuestras GetInstancia() {
            if(instancia == null) {
                instancia = new ListarMuestras();
            }
            return instancia;
        }

        private void CrearTabla() {
           tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Tipo", typeof(string));
            tabla.Columns.Add("Areas", typeof(string));
            tabla.Columns.Add("Vigente", typeof(string));
            tabla.Columns.Add("Fecha No Vigente", typeof(DateTime));
        }

        private void LlenarTabla() {
           if(tabla.Rows.Count != 0) {
                tabla.Clear();
            }

            foreach(EspecificacionDeMuestra especificacion in especificacionesFiltradas) {
                string vigencia = "Si";
                StringBuilder areas = new StringBuilder();
                if(especificacion.FechaNoVigente!=null) {
                    vigencia = "No";
                }
                for(int i = 0; i < especificacion.Areas.Count; i++) {
                    areas.Append(especificacion.Areas.ElementAt(i).NombreDeArea);
                    if(i+1 < especificacion.Areas.Count) {
                        areas.Append(" / ");
                    }
                }
                tabla.Rows.Add(especificacion.EspecificacionDeMuestraId,
                               especificacion.NombreDeEspecificacionDeMuestra,
                               especificacion.ClaseDeMuestra.ToString(),
                                areas,
                                vigencia,
                                especificacion.FechaNoVigente.GetValueOrDefault().Date);
            }
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
        
        private void BtnEditar_Click(object sender, EventArgs e) {
			if (especificacionSeleccionada != null){
				Form editarEspecificacionMuestraForm = EditarMuestra.GetInstancia(especificacionSeleccionada);
				editarEspecificacionMuestraForm.MdiParent = this.MdiParent;
				editarEspecificacionMuestraForm.Show();
				editarEspecificacionMuestraForm.BringToFront();
			}else{
				MessageBox.Show("No hay muestra seleccionada.");
			}
        }
        
        private void BtnEliminarClick(object sender, EventArgs e) {
			if (especificacionSeleccionada != null){
                if(MessageBox.Show("Seguro que quiere eliminar la muestra seleccionada? \n" +
                    "Esta accion no se puede deshacer.", "Eliminar Muestra?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    if(!cMuestras.EliminarEspecificacionDeMuestra(especificacionSeleccionada.EspecificacionDeMuestraId)) {
                        MessageBox.Show("No se pudo eliminar la Muestra seleccionada..");
                    } else {
                        ActualizarRegistros();
                        MessageBox.Show("La Muestra seleccionada fue eliminada");
                    }
                }
			}else{
				MessageBox.Show("No hay muestra seleccionada");
			}
        }

        public void ActualizarRegistros() {
            areasRegistradas = new ControladorAreas().ListarAreas().OrderBy(a=>a.NombreDeArea);
            areasSinFiltro=  new ControladorAreas().ListarAreas().OrderBy(a=>a.NombreDeArea);
            especificacionesFiltradas = cMuestras.ListarEspecificacionesDeMuestras()
            	.OrderBy(esp=>esp.NombreDeEspecificacionDeMuestra);
			especificacionesSinFiltro = cMuestras.ListarEspecificacionesDeMuestras()
            	.OrderBy(esp => esp.NombreDeEspecificacionDeMuestra);
            LlenarTabla();
        }

        #region Filtro Tipos
        private void GrupoTipos_CheckedChanged(object sender, EventArgs e) {
            if((sender as RadioButton).Text != "Todas") {
                especificacionesFiltradas = especificacionesSinFiltro.Where(es => es.ClaseDeMuestra == (EnumClaseMuestra)(Enum.Parse(typeof(EnumClaseMuestra), (sender as RadioButton).Text)));
            } else {
                especificacionesFiltradas = especificacionesSinFiltro;
            }
            LlenarTabla();
        }
        #endregion

        #region Filtro Texto
		private void GrupoBuscar_TextChanged(object sender, EventArgs e) {
        	if (!string.IsNullOrEmpty((sender as TextBox).Text)){
				string texto = (sender as TextBox).Text;
				grupoTipo.Enabled = false;
				BloquearFiltros(sender);
                
				switch ((sender as TextBox).Name){
					case "txtBuscarSector":
                        areasRegistradas = areasSinFiltro
                            .Where(a => a.NombreDeArea.ToLower()
                            .Contains(texto.ToLower()));
                        IDictionary<int, EspecificacionDeMuestra> especificaciones = new Dictionary<int, EspecificacionDeMuestra>();
                        foreach(Area area  in areasRegistradas) {
                            foreach(EspecificacionDeMuestra esp in area.EspecificacionesDeMuestras) {
                                if(!especificaciones.ContainsKey(esp.EspecificacionDeMuestraId)) {
                                    especificaciones.Add(esp.EspecificacionDeMuestraId, esp);
                                }
                            }
                        }
                        especificacionesFiltradas = especificaciones.Values.OrderBy(esp=>esp.NombreDeEspecificacionDeMuestra).ToList();
						break;
                		
					case "txtBuscarNombre":
						especificacionesFiltradas = especificacionesSinFiltro
							.Where(t => t.NombreDeEspecificacionDeMuestra.ToLower()
							.Contains(texto.ToLower()))
							.OrderBy(esp=>esp.NombreDeEspecificacionDeMuestra);
						break;
                		
					default: 
						especificacionesFiltradas = especificacionesSinFiltro.OrderBy(esp=>esp.NombreDeEspecificacionDeMuestra);
						break;
				}
        	}else{
        		grupoTipo.Enabled = true;
                BorrarFiltros();
                especificacionesFiltradas = especificacionesSinFiltro.OrderBy(esp=>esp.NombreDeEspecificacionDeMuestra);
        	}
			LlenarTabla();
		}
        
        private void BloquearFiltros(object excepcion){
        	foreach (Control txtbox in grupoBuscar.Controls) {
        		if (txtbox is TextBox){
        			if ((txtbox as TextBox).Name != (excepcion as TextBox).Name){
        				(txtbox as TextBox).Clear();
        				(txtbox as TextBox).Enabled = false;
        			}
        		}
        	}
        }
        
        private void BorrarFiltros(object sender, EventArgs e){
            BorrarFiltros();
        }
        private void BorrarFiltros() {
            foreach(Control txtbox in grupoBuscar.Controls) {
                if(txtbox is TextBox) {
                    (txtbox as TextBox).Clear();
                    (txtbox as TextBox).Enabled = true;
                }
            }
        }
        #endregion

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
        		especificacionSeleccionada = especificacionesFiltradas.Single(es => es.EspecificacionDeMuestraId == ((int)(tabla.Rows[filaActual].Cells[0].Value)));
                if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador &&
                   !especificacionSeleccionada.MuestrasDeEspecifcacionDeMuestra.Any()) {
                    btnEliminar.Enabled = true;
                }
				tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
            } catch(Exception) { }
		}
        
        private void ListarMuestrasFormFormClosing(object sender, FormClosingEventArgs e) {
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
