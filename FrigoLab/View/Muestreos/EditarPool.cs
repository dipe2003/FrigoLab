/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 09/05/2018
 * Hora: 09:47 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Muestreos;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Muestreos {
    /// <summary>
    /// Description of EditarPool.
    /// </summary>
    public partial class EditarPool:Form, ICerrar {
        private static EditarPool instancia;

        private ControladorMuestreos cMuestreos = new ControladorMuestreos();
		private ControladorPooles cPooles = new ControladorPooles();

        private int idDePool;
        private Pool poolAEditar;

        private DateTime fechaPool;
        private string descripcionPool;

        #region Muestreos
        private List<Muestreo> muestreosRegistrados;
        private List<Muestreo> muestreosFiltrados = new List<Muestreo>();
        private List<Muestreo> muestreosAgregados = new List<Muestreo>();
        private List<Muestreo> muestreosAQuitar = new List<Muestreo>();

        private EnumClaseMuestra claseMuestra;

        private Muestreo muestreoSeleccionadoAgregar;
        private Muestreo muestreoSeleccionadoQuitar;

        private DataTable tablaMuestreo;
        private DataTable tablaPool;
        #endregion

        private EditarPool() {
            InitializeComponent();
            tablaMuestreo = CrearTabla();
            tablaPool = CrearTabla();
            tablaMuestreosAgregados.DataSource = tablaPool;
            tablaDatos.DataSource = tablaMuestreo;
        }

        public static EditarPool GetInstancia(int idPool) {
            if(instancia == null) {
                instancia = new EditarPool {
                    idDePool = idPool
                };
                instancia.CargarDatos();
            }
            return instancia;
        }

        #region Inicializar Datos

        private void CargarDatos() {
            poolAEditar = cPooles.ObtenerPool(idDePool) as Pool;

            claseMuestra = poolAEditar.MuestreosDePool.FirstOrDefault().Muestra.EspecificacionDeMuestra.ClaseDeMuestra;

            muestreosRegistrados = cMuestreos.ListarMuestreosIndividuales().ToList();
            muestreosAgregados =  ObtenerMuestreosCoincidentes(muestreosRegistrados, poolAEditar.MuestreosDePool);
            muestreosFiltrados = muestreosRegistrados.Where(m => (m as Individual).Pool == null && !m.ExistenResultados()).ToList();

            fechaPool = poolAEditar.FechaCreacionDePool;
            descripcionPool = poolAEditar.DescripcionDePool;
            pickerFechaPool.Value = fechaPool;
            txtDescripcion.Text = descripcionPool;

            LlenarTabla(tablaPool, muestreosAgregados);
            LlenarTabla(tablaMuestreo, muestreosFiltrados);
        }

        private List<Muestreo> ObtenerMuestreosCoincidentes(List<Muestreo> original, List<Muestreo> comparable) {
            List<Muestreo> coincidentes = new List<Muestreo>();
            List<int> ids = comparable.Select<Muestreo, int>(m => m.MuestreoId).ToList();
            foreach(Muestreo muestreo in original) {
                if(ids.Contains(muestreo.MuestreoId)) {
                    coincidentes.Add(muestreo);
                }
            }
            return coincidentes;
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
        #endregion

        #region Botones

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

        private void BtnAgregarMuestreoClick(object sender, EventArgs e) {
            if(muestreoSeleccionadoAgregar != null) {
                // comprobar si el muestreo a agregar tiene ensayos asociados
                if(!muestreosAgregados.Any() || !muestreoSeleccionadoAgregar.AnalisisDelMuestreo.Any()) {
                    AgregarMuestreoSeleccionado(muestreoSeleccionadoAgregar);
                    muestreoSeleccionadoAgregar = muestreosFiltrados.FirstOrDefault();
                } else if(ComprobarEnsayos(muestreoSeleccionadoAgregar, muestreosAgregados)) {
                    AgregarMuestreoSeleccionado(muestreoSeleccionadoAgregar);
                    muestreosAQuitar.Remove(muestreoSeleccionadoAgregar);
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
                muestreosAQuitar.Add(muestreoSeleccionadoQuitar);
                muestreoSeleccionadoQuitar = muestreosAgregados.FirstOrDefault();
            } else {
                MessageBox.Show("No hay muestreo seleccionado.");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            if(ComprobarValores()) {
                foreach(Muestreo muestreo in muestreosAQuitar) {
                    cPooles.QuitarMuestreoDePool(poolAEditar.MuestreoId, muestreo.MuestreoId);
                }
                cPooles.AgregarMuestreosAPool(poolAEditar.MuestreoId, muestreosAgregados.Where(a => (a as Individual).Pool == null).Select<Muestreo, int>(m => m.MuestreoId).ToList());
                SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                MessageBox.Show("El pool fue guardado");
                this.Close();
            } else {
                MessageBox.Show("No se pudo guardar el Pool. Los datos ingresados no son correctos.");
            }
        }

        private void BtnEliminarPool_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Seguro que desea eliminar el pool y todos los muestreos asociados. \nEsta operacion no se puede deshacer",
                "Eliminar Pool?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                foreach(Muestreo muestreo in poolAEditar.MuestreosDePool) {
                    cMuestreos.EliminarMuestreo(muestreo.MuestreoId);
                }
                cPooles.EliminarPool(poolAEditar.MuestreoId);
                SesionDeUsuario.formulariosAbiertos.Single(f => f.Name == "EditarMuestreo").Close();
                SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                this.Close();
            }
        }

        /// <summary>
        /// Comprueba un muestreo contra los muestreos en la lista para verificar que tengan los mismos ensayos.
        /// </summary>
        /// <param name="muestreoSeleccionado"></param>
        /// <returns></returns>
		/// <param name = "muestreos"></param>
        private bool ComprobarEnsayos(Muestreo muestreoSeleccionado, List<Muestreo> muestreos) {
            // comprobar si tiene analisis
            if(muestreoSeleccionado.AnalisisDelMuestreo.Any()) {
                // tomar los ensayos del muestreo seleccionado y de los agregados
                IList<int> ensayosMuestreo = muestreoSeleccionado.AnalisisDelMuestreo.Select<Analisis, int>(a => a.Ensayo.EnsayoId).ToList();
                IList<Analisis> analisisMuestreoAgregados = muestreos.SelectMany<Muestreo, Analisis>(m => m.AnalisisDelMuestreo).ToList();
                IList<int> ensayosMuestreoAgregados = analisisMuestreoAgregados.Select<Analisis, int>(a => a.Ensayo.EnsayoId).ToList();

                // con el total de elementos de cada lista compararlos con los elementos no coincidentes (ditinct()) 
                // de la union de las listas
                // si los totales son iguales contienen los mismos analisis, de lo contrario no 
                int elementosMuestreo = ensayosMuestreo.Count();
                ensayosMuestreoAgregados = ensayosMuestreoAgregados.Distinct().ToList();
                int elementosAgregados = ensayosMuestreoAgregados.Count();
                ensayosMuestreo = (ensayosMuestreo.Union(ensayosMuestreoAgregados)).Distinct().ToList(); ;
                if(elementosMuestreo == elementosAgregados && elementosMuestreo == ensayosMuestreo.Count()) {
                    return true;
                }
            }
            return false;
        }

        private void AgregarMuestreoSeleccionado(Muestreo muestreo) {
            muestreosAgregados.Add(muestreo);
            muestreosFiltrados.Remove(muestreo);
            LlenarTabla(tablaPool, muestreosAgregados);
            LlenarTabla(tablaMuestreo, muestreosFiltrados);
        }

        private bool ComprobarValores() {
            if(muestreosAgregados.Any()) {
                fechaPool = pickerFechaPool.Value;
                descripcionPool = txtDescripcion.Text;
                if(string.IsNullOrEmpty(descripcionPool)) {
                    return false;
                }
                return true;
            }
            MessageBox.Show("El pool debe contener mínimo 2 muesrtreos.");
            return false;
        }
        #endregion

        #region Tablas
        // tabla de muestreos disponibles para agregar a pool
        private void TablaDatos_SelectionChanged(object sender, EventArgs e) {
            try {
                muestreoSeleccionadoAgregar = muestreosFiltrados.Single(m => m.MuestreoId == ((int)(tablaDatos.SelectedRows[0].Cells[0].Value)));
            } catch(Exception ex) { }
        }

        // tabla de muestreos seleccionados para agregar a pool
        private void TablaMuestreosAgregados_SelectionChanged(object sender, EventArgs e) {
            try {
                muestreoSeleccionadoQuitar = muestreosAgregados.Single(m => m.MuestreoId == ((int)(tablaMuestreosAgregados.SelectedRows[0].Cells[0].Value)));
            } catch(Exception ex) { }
        }
        #endregion

        private void EditarPoolFormClosing(object sender, FormClosingEventArgs e) {
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
