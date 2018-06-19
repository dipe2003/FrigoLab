using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Ensayos {
    public partial class ListarLaboratorios:Form, ICerrar {
        private static ListarLaboratorios instancia;

        private ControladorEnsayos cEnsayos = new ControladorEnsayos();

        private IEnumerable<Laboratorio> laboratoriosRegistrados;
        private IEnumerable<Laboratorio> laboratoriosSinFiltro;

        private DataTable tabla;

        private Laboratorio laboratorioSeleccionado;
        
        private ListarLaboratorios() {
            InitializeComponent();
            CrearTabla();
            radioTodos.Checked = true;
            ActualizarRegistros();
            if(SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador
                || SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Verificador) {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            foreach(RadioButton radio in grupoTipo.Controls) {
                radio.CheckedChanged += GrupoTipoLaboratorioChange_Click;
            }
            tablaDatos.DataSource = tabla;
            tablaDatos.Columns["Id"].Visible = false;
            
			laboratorioSeleccionado = laboratoriosRegistrados.FirstOrDefault();
			
			tablaDatos.ContextMenuStrip = CrearMenuContextual();
        }

        public static ListarLaboratorios GetInstancia() {
            if(instancia == null) {
                instancia = new ListarLaboratorios();
            }
            return instancia;
        }

        private void CrearTabla() {
            tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre del Laboratorio", typeof(string));
            tabla.Columns.Add("Tipo de Laboratorio", typeof(string));
        }
        private void LlenarTabla() {
            if(tabla.Rows.Count != 0) {
                tabla.Clear();
            }

            foreach(Laboratorio lab in laboratoriosRegistrados) {
                tabla.Rows.Add(lab.LaboratorioId,
                               lab.NombreDeLaboratorio,
                               lab.TipoDeLaboratorio.ToString()
                              );
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
        
        private void GrupoTipoLaboratorioChange_Click(object sender, EventArgs e) {
            string tipo = (sender as RadioButton).Text;
            switch(tipo) {
                case "Solo Internos":
                    laboratoriosRegistrados = laboratoriosSinFiltro
                    	.Where(lab=>lab.TipoDeLaboratorio.ToString() == "Interno")
                    	.OrderBy(l=>l.NombreDeLaboratorio);
                    break;

                case "Solo Externos":
                    laboratoriosRegistrados = laboratoriosSinFiltro
                    	.Where(lab => lab.TipoDeLaboratorio.ToString() == "Externo")
                    	.OrderBy(l=>l.NombreDeLaboratorio);
                    break;

                default:
                    laboratoriosRegistrados = laboratoriosSinFiltro.OrderBy(l=>l.NombreDeLaboratorio);
                    break;
            }
            LlenarTabla();
        }

        private void BtnEditar_Click(object sender, EventArgs e) {
			if (laboratorioSeleccionado != null){
				Form editarLabForm = EditarLaboratorio.GetInstancia(laboratorioSeleccionado);
				editarLabForm.MdiParent = this.MdiParent;
				editarLabForm.Show();
				editarLabForm.BringToFront();
			}else{
				MessageBox.Show("No hay laboratorio seleccionado");
			}
        }
        private void ListarLaboratoriosFormFormClosing(object sender, FormClosingEventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            instancia = null;
        }

        public void ActualizarRegistros() {
            laboratoriosRegistrados = cEnsayos.ListarLaboratorios();
            laboratoriosSinFiltro = cEnsayos.ListarLaboratorios();
            LlenarTabla();
        }

        private void TxtBuscarNombre_TextChanged(object sender, EventArgs e) {
            if((sender as TextBox).Text != "") {
                grupoTipo.Enabled = false;
                string texto = (sender as TextBox).Text;
                laboratoriosRegistrados = laboratoriosSinFiltro
                	.Where(lab => lab.NombreDeLaboratorio.ToLower()
                	.Contains(texto.ToLower()))
                	.OrderBy(l=>l.NombreDeLaboratorio);
            } else {
                laboratoriosRegistrados = laboratoriosSinFiltro.OrderBy(l=>l.NombreDeLaboratorio);
                grupoTipo.Enabled = true;
            }
             LlenarTabla();
        }

        private void BtnQuitarFiltroNombreClick(object sender, EventArgs e) {
            txtBuscarNombre.Clear();
        }

        private void BtnEliminarClick(object sender, EventArgs e) {
			if (laboratorioSeleccionado != null){
                if(MessageBox.Show("Seguro que quiere eliminar el laboratorio seleccionado? \n" +
                    "Esta accion no se puede deshacer.", "Eliminar Laboratorio?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    if(!cEnsayos.EliminarLaboratorio(laboratorioSeleccionado.LaboratorioId)) {
                        MessageBox.Show("No se pudo eliminar el Laboratorio.");
                    } else {
                        ActualizarRegistros();
                        MessageBox.Show("El Laboratorio fue eliminado.");
                    }
                }
			}else{
				MessageBox.Show("No hay laboratorio seleccionado");
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
				laboratorioSeleccionado = laboratoriosRegistrados.Single(lab => lab.LaboratorioId == ((int)(tabla.Rows[filaActual].Cells[0].Value)));
                if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador &&
                   !laboratorioSeleccionado.AnalisisRealizados.Any()) {
                    btnEliminar.Enabled = true;
                }
				tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
            } catch(Exception ex) { }
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
