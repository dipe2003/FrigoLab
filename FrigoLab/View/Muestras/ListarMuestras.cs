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

        private string tipoFiltrado = "Todas";
        private string sectorFiltrado = "Todos";
        private List<string> sectoresEnFiltro = new List<string>();

        private IEnumerable<Area> areasRegistradas;
        private IEnumerable<Area> areasSinFiltro;
        private DataTable tabla;

        private EspecificacionDeMuestra especificacionSeleccionada;

        private ListarMuestras() {
            InitializeComponent();
            CrearTabla();
            ActualizarRegistros();
            LLenarComboSectores(true);

            foreach(System.Windows.Forms.RadioButton radio in grupoTipo.Controls) {
                radio.CheckedChanged += GrupoTipos_CheckedChanged;
            }

            if(SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Administrador
                || SesionDeUsuario.PermisoUsuario() == EnumPermisoUsuario.Verificador) {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }

            especificacionSeleccionada = especificacionesFiltradas.FirstOrDefault();

            tablaDatos.ContextMenuStrip = CrearMenuContextual();

            // Grupo Sectores
            cboSector.DataSource = sectoresEnFiltro;
            sectorFiltrado = "Todos";
            cboSector.Text = sectorFiltrado;

            tablaDatos.DataSource = tabla;
            tablaDatos.Columns["Id"].Visible = false;
        }

        public static ListarMuestras GetInstancia() {
            if(instancia == null) {
                instancia = new ListarMuestras();
            }
            return instancia;
        }

        #region Datos
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

        private void LLenarComboSectores(bool inicio) {
            List<string> nombreSectores = new List<string>();
            if(inicio) {
                List<Area> areasEspecificaciones = especificacionesSinFiltro.SelectMany<EspecificacionDeMuestra, Area>(es => es.Areas).ToList();
                var sectores = from area in areasEspecificaciones
                               select area.NombreDeArea;
                nombreSectores = sectores.Distinct().ToList();
                nombreSectores.Add("Todos");
            } else {
                if(especificacionesFiltradas.Any()) {
                    List<Area> areasEspecificaciones = especificacionesFiltradas.SelectMany<EspecificacionDeMuestra, Area>(es => es.Areas).ToList();
                    var sectores = from area in areasEspecificaciones
                                   select area.NombreDeArea;
                    nombreSectores = sectores.Distinct().ToList();
                    nombreSectores.Add("Todos");
                } else {
                    var sectores = new List<string> { "Todos" };
                }
            }
            sectoresEnFiltro = nombreSectores;
            cboSector.Text = sectorFiltrado =="Todos" ? "Todos" : sectoresEnFiltro.FirstOrDefault();
        }

        private ContextMenuStrip CrearMenuContextual(bool seleccion = false) {
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

        public void ActualizarRegistros() {
            areasRegistradas = new ControladorAreas().ListarAreas().OrderBy(a => a.NombreDeArea);
            areasSinFiltro=  new ControladorAreas().ListarAreas().OrderBy(a => a.NombreDeArea);
            especificacionesFiltradas = cMuestras.ListarEspecificacionesDeMuestras()
                .OrderBy(esp => esp.NombreDeEspecificacionDeMuestra);
            especificacionesSinFiltro = cMuestras.ListarEspecificacionesDeMuestras()
                .OrderBy(esp => esp.NombreDeEspecificacionDeMuestra);
            LlenarTabla();
        }
        #endregion

        #region Acciones
        private void BtnEditar_Click(object sender, EventArgs e) {
            if(especificacionSeleccionada != null) {
                Form editarEspecificacionMuestraForm = EditarMuestra.GetInstancia(especificacionSeleccionada);
                editarEspecificacionMuestraForm.MdiParent = this.MdiParent;
                editarEspecificacionMuestraForm.Show();
                editarEspecificacionMuestraForm.BringToFront();
            } else {
                MessageBox.Show("No hay muestra seleccionada.");
            }
        }

        private void BtnEliminarClick(object sender, EventArgs e) {
            if(especificacionSeleccionada != null) {
                if(MessageBox.Show("Seguro que quiere eliminar la muestra seleccionada? \n" +
                    "Esta accion no se puede deshacer.", "Eliminar Muestra?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                    if(!cMuestras.EliminarEspecificacionDeMuestra(especificacionSeleccionada.EspecificacionDeMuestraId)) {
                        MessageBox.Show("No se pudo eliminar la Muestra seleccionada..");
                    } else {
                        ActualizarRegistros();
                        MessageBox.Show("La Muestra seleccionada fue eliminada");
                    }
                }
            } else {
                MessageBox.Show("No hay muestra seleccionada");
            }
        }
        #endregion        

        #region Filtro Tipos
        private void FiltrarTabla() {
            especificacionesFiltradas = FiltrarTipo(tipoFiltrado, especificacionesSinFiltro.ToList());
            especificacionesFiltradas = FiltrarSector(sectorFiltrado, especificacionesFiltradas.ToList());
            LlenarTabla();
            LLenarComboSectores(false);
        }

        private List<EspecificacionDeMuestra> FiltrarTipo(string tipo, List<EspecificacionDeMuestra> especificacionesAFiltrar) {
            if(string.IsNullOrEmpty(tipo) || tipo == "Todas") {
                return especificacionesAFiltrar.ToList();
            } else {
                EnumClaseMuestra claseDeMuestra = (EnumClaseMuestra)(Enum.Parse(typeof(EnumClaseMuestra), tipo));
                return especificacionesAFiltrar.Where(es => es.ClaseDeMuestra == claseDeMuestra).ToList();
            }
        }

        private void GrupoTipos_CheckedChanged(object sender, EventArgs e) {
            tipoFiltrado = (sender as RadioButton).Text;
            FiltrarTabla();
        }

        #region Filtro::Sectores
        private List<EspecificacionDeMuestra> FiltrarSector(string nombreSector, List<EspecificacionDeMuestra> especificacionesAFiltrar) {
            if(string.IsNullOrEmpty(nombreSector) || nombreSector=="Todos") {
                return especificacionesAFiltrar;
            }
            Area area = especificacionesAFiltrar.SelectMany<EspecificacionDeMuestra, Area>(es => es.Areas)
                 .Where(a => a.NombreDeArea == nombreSector).FirstOrDefault();
            return especificacionesAFiltrar.Where(esp=>esp.Areas.Contains(area)).ToList();
        }

        private void CboSectores_SelectedIndexChanged(object sender, EventArgs e) {
            sectorFiltrado = (sender as ComboBox).Text;
            FiltrarTabla();
        }

        #endregion

        private void BorrarFiltros(object sender, EventArgs e) {
            txtBuscarNombre.Clear();
            this.Refresh();
            RadioTodas.Checked = true;
            cboSector.Text = "Todos";
        }
        #endregion

        #region Busqueda
        private void BtnBuscar_Click(object sender, EventArgs e) {
            string textoBuscado = (sender as TextBox).Text;
            if(!string.IsNullOrEmpty(textoBuscado)) {
                especificacionesFiltradas = BuscarTexto(textoBuscado, especificacionesFiltradas.ToList());
                LlenarTabla();
            }
        }

        private List<EspecificacionDeMuestra> BuscarTexto(string texto, List<EspecificacionDeMuestra> especificacionesABuscar) {
            return especificacionesFiltradas
                .Where(es => es.NombreDeEspecificacionDeMuestra.ToLower().Contains(texto.ToLower())).ToList();
        }

        
        #endregion

        private void TablaDatosMouseDown(object sender, MouseEventArgs e) {
            int currentMouseOverRow = (sender as DataGridView).HitTest(e.X, e.Y).RowIndex;
            CambioFila(sender as DataGridView, currentMouseOverRow);
        }

        private void TablaDatosRowEnter(object sender, DataGridViewCellEventArgs e) {
            int currentMouseOverRow = e.RowIndex;
            CambioFila(sender as DataGridView, currentMouseOverRow);
        }

        private void CambioFila(DataGridView tabla, int filaActual) {
            if(filaActual >= 0) {
                tabla.Rows[filaActual].Selected = true;
                SeleccionarElemento(tabla, filaActual);
            } else {
                tablaDatos.ContextMenuStrip = CrearMenuContextual();
            }
        }

        private void SeleccionarElemento(DataGridView tabla, int filaActual) {
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
