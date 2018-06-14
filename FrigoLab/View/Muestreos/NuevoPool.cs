using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Logica.Muestreos;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Muestreos {
    public partial class NuevoPool:Form, ICerrar {

        private static NuevoPool instancia;

        private ControladorMuestreos cMuestreos = new ControladorMuestreos();
		private ControladorPooles cPooles = new ControladorPooles();

        #region Datos de Pool
        private DateTime fechaPool;
        private string descripcionPool;
        private EnumClaseMuestra claseMuestra;
        #endregion

        #region Muestreos
        private List<Muestreo> muestreosRegistrados;
        private List<Muestreo> muestreosFiltrados = new List<Muestreo>();
        private List<Muestreo> muestreosAgregados = new List<Muestreo>();

        private Muestreo muestreoSeleccionadoAgregar;
        private Muestreo muestreoSeleccionadoQuitar;

        private DataTable tablaMuestreo;
        private DataTable tablaPool;
        #endregion

        private NuevoPool() {
            InitializeComponent();
            CargarDatos();
            tablaMuestreo = CrearTabla();
            tablaPool = CrearTabla();

            foreach(RadioButton radio in grupoClase.Controls) {
                radio.CheckedChanged += GrupoTipos_CheckedChanged;
            }

            LlenarTabla(tablaMuestreo, muestreosFiltrados);
            tablaDatos.DataSource = tablaMuestreo;
            tablaDatos.Columns["Id"].Visible = false;
            muestreoSeleccionadoAgregar = muestreosFiltrados.FirstOrDefault();
            tablaMuestreosAgregados.DataSource = tablaPool;
            tablaMuestreosAgregados.Columns["Id"].Visible = false;
        }

        public static NuevoPool GetInstancia() {
            if(instancia == null) {
                instancia = new NuevoPool();
            }
            return instancia;
        }

        private void CargarDatos() {
            claseMuestra = EnumClaseMuestra.Producto;
            radioProducto.Checked = true;
            muestreosRegistrados = cMuestreos.ListarMuestreosIndividuales().ToList();
            muestreosFiltrados = muestreosRegistrados
                .Where(m => m.Muestra.EspecificacionDeMuestra.ClaseDeMuestra == claseMuestra)
                .Where(m => m.ExistenResultados() == false)
                .Where(m => (m as Individual).Pool == null)
                .OrderBy(m=>(m as Individual).FechaHoraDeMuestreo)
                .ToList();
        }

        private DataTable CrearTabla() {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Fecha Muestreo", typeof(string));
            tabla.Columns.Add("Sector", typeof(string));
            tabla.Columns.Add("Muestra", typeof(string)); // NombreDeEspecificacion
            tabla.Columns.Add("Identificacion", typeof(string)); // Identificacion
            return tabla;
        }

        private void LlenarTabla(DataTable tabla, List<Muestreo> muestreos) {
            if(tabla.Rows.Count != 0) {
                tabla.Clear();
            }

            var items = new Object[tabla.Columns.Count];

            foreach(Individual muestreo in muestreos) {
                Muestra m = muestreo.Muestra;
                items[0] = muestreo.MuestreoId;
                items[1] = muestreo.FechaHoraDeMuestreo.ToShortDateString();
                items[2] = muestreo.Muestra.Area.NombreDeArea;
                items[3] = muestreo.Muestra.EspecificacionDeMuestra.NombreDeEspecificacionDeMuestra;
                items[4] = muestreo.Muestra.IdentificacionDeMuestra;

                DataRow dataRow = tabla.NewRow();
                dataRow.ItemArray = items;
                tabla.Rows.Add(dataRow);
            }
        }

        // Tipo (clase de muestra)
        private void GrupoTipos_CheckedChanged(object sender, EventArgs e) {
            EnumClaseMuestra nuevaClaseMuestra = (EnumClaseMuestra)(Enum.Parse(typeof(EnumClaseMuestra), (sender as RadioButton).Text));
            if(nuevaClaseMuestra != claseMuestra) {
                claseMuestra = nuevaClaseMuestra;
                muestreosFiltrados = muestreosRegistrados
                    .Where(m => m.Muestra.EspecificacionDeMuestra.ClaseDeMuestra == claseMuestra)
                    .ToList();
                LlenarTabla(tablaMuestreo, muestreosFiltrados);
                if(muestreosAgregados.Any()) {
                    muestreosAgregados.Clear();
                    tablaPool.Clear();
                }
            }
        }

        // tabla de muestreos disponibles para agregar a pool
        private void tablaDatos_SelectionChanged(object sender, EventArgs e) {
            try {
                muestreoSeleccionadoAgregar = muestreosFiltrados.Single(m => m.MuestreoId == ((int)(tablaDatos.SelectedRows[0].Cells[0].Value)));
            } catch(Exception ex) { }
        }

        // tabla de muestreos seleccionados para agregar a pool
        private void tablaMuestreosAgregados_SelectionChanged(object sender, EventArgs e) {
            try {
                muestreoSeleccionadoQuitar = muestreosAgregados.Single(m => m.MuestreoId == ((int)(tablaMuestreosAgregados.SelectedRows[0].Cells[0].Value)));
            } catch(Exception ex) { }
        }

        private void BtnCancelarClick(object sender, EventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            this.Close();
        }

        private void BtnReiniciarClick(object sender, EventArgs e) {
            if(muestreosAgregados.Any()) {
                muestreosAgregados.Clear();
                tablaPool.Clear();
            }
            ActualizarRegistros();
        }

        private void BtnNuevoMuestreoClick(object sender, EventArgs e) {
            Form nuevoMuestreo = NuevoMuestreo.GetInstancia(claseMuestra);
            SesionDeUsuario.AgregarFormularioAbierto(nuevoMuestreo);
            nuevoMuestreo.MdiParent = this.MdiParent;
            nuevoMuestreo.Show();
            nuevoMuestreo.BringToFront();
        }

        private void BtnGuardarClick(object sender, EventArgs e) {
            if(ComprobarValores()) {
                Muestreo nuevoPool = cPooles.CrearNuevoPool(SesionDeUsuario.UsuarioLogueado.UsuarioId,
                                        fechaPool, descripcionPool);
                if(nuevoPool != null) {
                    List<int> muestreos = muestreosAgregados.Select<Muestreo, int>(m => m.MuestreoId).ToList();
                    if(cPooles.AgregarMuestreosAPool(nuevoPool.MuestreoId, muestreos) == 0) {
                        MessageBox.Show("No se pudo agregar muestreo al Pool.");
                    } else {
                        SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                        MessageBox.Show("El pool fue creado.");
                        this.Close();
                    }
                } else {
                    MessageBox.Show("No se pudo crear el Pool.");
                }
            } else {
                MessageBox.Show("No se pudo crear el Pool. Los datos ingresados no son correctos.");
            }
        }

        private void BtnAgregarMuestreoClick(object sender, EventArgs e) {
            if(muestreoSeleccionadoAgregar != null) {
                // comprobar si el muestreo a agregar tiene ensayos asociados
                if(!muestreosAgregados.Any() || !muestreoSeleccionadoAgregar.AnalisisDelMuestreo.Any()) {
                    AgregarMuestreoSeleccionado(muestreoSeleccionadoAgregar);
                    muestreoSeleccionadoAgregar = muestreosFiltrados.FirstOrDefault();
                } else if(ComprobarEnsayos(muestreoSeleccionadoAgregar, muestreosAgregados)) {
                    AgregarMuestreoSeleccionado(muestreoSeleccionadoAgregar);
                    muestreoSeleccionadoAgregar = muestreosFiltrados.FirstOrDefault();
                } else {
                    MessageBox.Show("Solo se pueden agregar muestreso con los mismos analisis.");
                }
            } else {
                MessageBox.Show("No hay muestreo seleccionado.");
            }
        }

        private void BtnQuitarMuestreoClick(object sender, EventArgs e) {
            if(muestreoSeleccionadoQuitar != null) {
                muestreosFiltrados.Add(muestreoSeleccionadoQuitar);
                muestreosAgregados.Remove(muestreoSeleccionadoQuitar);
                LlenarTabla(tablaPool, muestreosAgregados);
                LlenarTabla(tablaMuestreo, muestreosFiltrados);
                muestreoSeleccionadoQuitar = muestreosAgregados.FirstOrDefault();
            } else {
                MessageBox.Show("No hay muestreo seleccionado.");
            }
        }

        private void AgregarMuestreoSeleccionado(Muestreo muestreo) {
            muestreosAgregados.Add(muestreo);
            muestreosFiltrados.Remove(muestreo);
            LlenarTabla(tablaPool, muestreosAgregados);
            LlenarTabla(tablaMuestreo, muestreosFiltrados);
        }

        /// <summary>
        /// Comprueba un muestreo contra los muestreos en la lista para verificar que tengan los mismos ensayos.
        /// </summary>
        /// <param name="muestreo"></param>
        /// <returns></returns>
		/// <param name = "muestreos"></param>
        private bool ComprobarEnsayos(Muestreo muestreo, List<Muestreo> muestreos) {
            // comprobar si tiene analisis
            if(muestreo.AnalisisDelMuestreo.Any()) {
                // tomar los ensayos del muestreo seleccionado y de los agregados
                IList<int> ensayosMuestreo = muestreo.AnalisisDelMuestreo.Select<Analisis, int>(a => a.Ensayo.EnsayoId).ToList();
                IList<Analisis> analisisMuestreoAgregados = muestreos.SelectMany<Muestreo, Analisis>(m => m.AnalisisDelMuestreo).ToList();
                IList<int> ensayosMuestreoAgregados = analisisMuestreoAgregados.Select<Analisis, int>(a => a.Ensayo.EnsayoId).ToList();

                // con el total de elementos de cada lista compararlos con los elementos no coincidentes (ditinct()) 
                // de la union de las listas
                // si los totales son iguales contienen los mismos analisis, de lo contrario no 
                int elementosMuestreo = ensayosMuestreo.Count();
                ensayosMuestreoAgregados = ensayosMuestreoAgregados.Distinct().ToList();
                int elementosAgregados = ensayosMuestreoAgregados.Count();
                ensayosMuestreo = (ensayosMuestreo.Union(ensayosMuestreoAgregados)).Distinct().ToList(); ;
                if(elementosMuestreo == elementosAgregados && elementosMuestreo == ensayosMuestreo.Count()){
                    return true;
                }
            }
            return false;
        }

        private bool ComprobarValores() {
			if (muestreosAgregados.Any()){
				fechaPool = pickerFechaPool.Value;
				descripcionPool = txtDescripcion.Text;
				if (string.IsNullOrEmpty(descripcionPool)){
					return false;
				}
				return true;
			}
			MessageBox.Show("El pool debe contener mínimo 2 muesrtreos.");
			return false;
        }

        private void NuevoPoolFormClosing(object sender, FormClosingEventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            instancia = null;
        }

        private void ActualizarRegistros() {
            CargarDatos();
            LlenarTabla(tablaMuestreo, muestreosFiltrados);
            muestreoSeleccionadoAgregar = muestreosFiltrados.FirstOrDefault();
        }
        public override void Refresh() {
            base.Refresh();
            ActualizarRegistros();
        }

        #region Interfase CerrarInstancia
        public void CerrarInstancia() {
            instancia = null;
        }
        #endregion
    }
}
