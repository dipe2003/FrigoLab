using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Requisitos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Requisitos {
    public partial class ListarRequisitos:Form, ICerrar {
        private static ListarRequisitos instancia;

        private ControladorRequisitos cRequisitos = new ControladorRequisitos();

        IEnumerable<Requisito> requisitosRegistrados;
        IEnumerable<Requisito> requisitosSinFiltro;

        private DataTable tablaRequisitos;
        private DataTable tablaLimites;

        private Requisito requisitoSeleccionado;
        
        private ListarRequisitos() {
            InitializeComponent();
            CrearTablas();
            ActualizarRegistros();

            if(SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador
                || SesionDeUsuario.PermisoUsuario()== EnumPermisoUsuario.Verificador) {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }

            tablaDatos.Columns["Id"].Visible = false;
			requisitoSeleccionado = requisitosRegistrados.FirstOrDefault();
			
			tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
        }

        public static ListarRequisitos GetInstancia() {
            if(instancia == null) {
                instancia = new ListarRequisitos();
            }
            return instancia;
        }

        private void CrearTablas() {
            tablaLimites = new DataTable();
            tablaLimites.Columns.Add("Tipo", typeof(string));
            tablaLimites.Columns.Add("Muestra", typeof(EnumClaseMuestra));
            tablaLimites.Columns.Add("Ensayo", typeof(string));
            tablaLimites.Columns.Add("Referencia", typeof(string));
            tablaLimites.Columns.Add("Valor Marginal", typeof(string));
            tablaLimites.Columns.Add("Valor Inaceptable", typeof(string));
            tablaLimites.Columns.Add("Deteccion", typeof(string));
            tablaLimites.Columns.Add("Vigencia", typeof(string));

            tablaRequisitos = new DataTable();
            tablaRequisitos.Columns.Add("Id", typeof(int));
            tablaRequisitos.Columns.Add("Nombre del Requisito", typeof(string));
        }

        private void LlenarTablaRequisitos() {
            tablaRequisitos.Clear();
            foreach(Requisito requisito in requisitosRegistrados) {
                tablaRequisitos.Rows.Add(requisito.RequisitoId,
                               requisito.NombreDeRequisito);
            }
        }

        private void LlenarTablaLimites() {
            tablaLimites.Clear();
            string vigencia;
            foreach(Limite limite in requisitoSeleccionado.LimitesDelRequisito) {
                if(limite.FechaNoVigente!=null) {
                    vigencia ="No";
                } else {
                    vigencia="Si";
                }
                if(limite is Busqueda) {
                    tablaLimites.Rows.Add("Busqueda",
                                    limite.Ensayo.ClaseDeMuestra,
                                    limite.Ensayo.NombreDeEnsayo,
                                    limite.ReferenciaDeLimite,
                                    "-",
                                    "-",
                                    (limite as Busqueda).ValorAceptableDeBusqueda.ToString(),
                                    vigencia);
                } else if(limite is Marginal) {
                                    tablaLimites.Rows.Add("Recuento",
                                    limite.Ensayo.ClaseDeMuestra,
                                    limite.Ensayo.NombreDeEnsayo,
                                    limite.ReferenciaDeLimite,
                                    (limite as Marginal).ValorMarginalDeRecuento.ToString(),
                                    (limite as Marginal).ValorInaceptableDeRecuento.ToString(),
                                     "-",
                                     vigencia);
                } else {
                    tablaLimites.Rows.Add("Recuento",
                                    limite.Ensayo.ClaseDeMuestra,
                                    limite.Ensayo.NombreDeEnsayo,
                                    limite.ReferenciaDeLimite,
                                    "-",
                                    (limite as Inaceptable).ValorInaceptableDeRecuento.ToString(),
                                     "-",
                                     vigencia);
                }
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
			if (requisitoSeleccionado != null){
				Form editarRequisito = EditarRequisito.GetInstancia(requisitoSeleccionado);
				editarRequisito.MdiParent = this.MdiParent;
				editarRequisito.Show();
				editarRequisito.BringToFront();
			}else{
				MessageBox.Show("No hay requisito seleccionado");
			}
        }
        public void ActualizarRegistros() {
        	requisitosRegistrados = cRequisitos.ListarRequisitos().OrderBy(r => r.NombreDeRequisito);
        	requisitosSinFiltro = cRequisitos.ListarRequisitos().OrderBy(r => r.NombreDeRequisito);
        	LlenarTablaRequisitos();
        	tablaDatos.DataSource = tablaRequisitos;
        }

        private void TxtBuscarNombre_TextChanged(object sender, EventArgs e) {
            if(((sender as TextBox).Text).ToLower() != "") {
                string texto = (sender as TextBox).Text;
                requisitosRegistrados = requisitosSinFiltro
                    .Where(r => r.NombreDeRequisito.ToLower()
                    .Contains(texto))
                    .OrderBy(r => r.NombreDeRequisito);
            } else {
                requisitosRegistrados = requisitosSinFiltro.OrderBy(r => r.NombreDeRequisito);
            }
            LlenarTablaRequisitos();
            tablaDatos.DataSource = tablaRequisitos;
        }

        private void BtnQuitarFiltroNombreClick(object sender, EventArgs e) {
            txtBuscarNombre.Clear();
        }

        private void BtnEliminarClick(object sender, EventArgs e) {
			if (requisitoSeleccionado != null){
                if(MessageBox.Show("Seguro que quiere eliminar el requisito seleccionado? \n" +
                    "Esta accion no se puede deshacer.", "Eliminar Requisito?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    if(!cRequisitos.EliminarRequisito(requisitoSeleccionado.RequisitoId)) {
                        MessageBox.Show("No se pudo eliminar el Requisito.");
                    } else {
                        ActualizarRegistros();
                        MessageBox.Show("El Requisito fue eliminado.");
                    }
                }
			}else{
				MessageBox.Show("No hay requisito seleccionado");
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
				requisitoSeleccionado = requisitosRegistrados.Single(r => r.RequisitoId == ((int)(tabla.Rows[filaActual].Cells[0].Value)));
                LlenarTablaLimites();
                tablaDatos2.DataSource = tablaLimites;
                if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario == EnumPermisoUsuario.Administrador &&
                   !requisitoSeleccionado.LimitesDelRequisito.Any()) {
                    btnEliminar.Enabled = true;
                }
				tablaDatos.ContextMenuStrip = CrearMenuContextual(true);
            } catch(Exception ex) {
                Debug.WriteLine(ex.Message);
            }
		}
		
        private void ListarRequisitosFormFormClosing(object sender, FormClosingEventArgs e) {
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
