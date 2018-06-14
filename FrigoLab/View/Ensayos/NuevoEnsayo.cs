/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 24/03/2018
 * Hora: 10:03 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Windows.Forms;

namespace FrigLab.View.Ensayos {
    /// <summary>
    /// Description of NuevaEspecificacionEnsayoForm.
    /// </summary>
    public partial class NuevoEnsayo:Form, ICerrar {
        private static NuevoEnsayo instancia;

        private ControladorEnsayos cEnsayos = new ControladorEnsayos();

        private string nombreEnsayo;
        private string metodoEnsayo;
        private EnumTipoAnalisis tipoAnalisis;
        private EnumClaseMuestra claseMuestra = EnumClaseMuestra.Producto;

        private NuevoEnsayo() {
            InitializeComponent();

            // Tipo de Analisis
            foreach(RadioButton radio in GrupoTipoAnalisis.Controls) {
                radio.CheckedChanged += GrupoTipoAnalisis_Checked;
            }
            RadioBusqueda.Checked = true;

            // Clase de Muestra
            foreach(RadioButton radio in grupoClaseMuestra.Controls) {
                radio.CheckedChanged += GrupoClaseMuestra_Checked;
            }
            radioProducto.Checked = true;
        }

        public static NuevoEnsayo GetInstancia() {
            if(instancia == null) {
                instancia = new NuevoEnsayo();
            }
            return instancia;
        }

        private bool EsValidoNombre() {
            if(!string.IsNullOrEmpty(txtNombre.Text)) {
                nombreEnsayo =  txtNombre.Text;
                return true;
            }
            return false;
        }

        private void GrupoClaseMuestra_Checked(object sender, EventArgs e) {
            claseMuestra = (EnumClaseMuestra)Enum.Parse(typeof(EnumClaseMuestra), (sender as RadioButton).Text);
        }

        private void GrupoTipoAnalisis_Checked(object sender, EventArgs e) {
            string tipo = (sender as RadioButton).Text;
            switch(tipo) {
                case "Busqueda":
                    tipoAnalisis = EnumTipoAnalisis.Busqueda;
                    break;

                case "Recuento":
                    tipoAnalisis = EnumTipoAnalisis.Recuento;
                    break;

                default:
                    tipoAnalisis = EnumTipoAnalisis.RecuentoMarginal;
                    break;
            }
        }

        private void BtnGuardarClick(object sender, EventArgs e) {
            metodoEnsayo = txtMetodo.Text;
            if(EsValidoNombre()) {
                if(cEnsayos.CrearNuevoEnsayo(nombreEnsayo, metodoEnsayo, tipoAnalisis, claseMuestra)!=null) {
                    SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                    MessageBox.Show("El Ensayo fue guardado");
                    this.Close();
                } else {
                    MessageBox.Show("No se pudo crear, compruebe que los datos son correctos.");
                }
            } else {
                MessageBox.Show("No se pudo crear, compruebe que los datos son correctos.");
            }

        }

        private void BtnCancelarClick(object sender, EventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            this.Close();
        }
        private void NuevaEspecificacionEnsayoFormFormClosing(object sender, FormClosingEventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            instancia = null;
        }

        #region ICerrar implementation
        public void CerrarInstancia() {
            instancia = null;
        }
        #endregion
    }
}
