using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Windows.Forms;

namespace FrigLab.View.Ensayos {
    public partial class NuevoLaboratorio:Form, ICerrar {
        private static NuevoLaboratorio instancia;

        private ControladorEnsayos cEnsayos = new ControladorEnsayos();

        private string nombreLaboratorio;
        private EnumTipoLaboratorio tipoLaboratorio;

        private NuevoLaboratorio() {
            InitializeComponent();

            foreach(RadioButton radio in GrupoTipoLab.Controls) {
                radio.CheckedChanged += GrupoTipoLab_CheckedChanged;
                if(radio.Text == "Interno") radio.Checked = true;
            }
        }

        public static NuevoLaboratorio GetInstancia() {
            if(instancia == null) {
                instancia = new NuevoLaboratorio();
            }
            return instancia;
        }

        private void GrupoTipoLab_CheckedChanged(object sender, EventArgs e) {
            tipoLaboratorio = (EnumTipoLaboratorio) Enum.Parse(typeof(EnumTipoLaboratorio), (sender as RadioButton).Text);
        }

        private void BtnGuardarClick(object sender, EventArgs e) {
            if(EsValidoNombre()) {
                if(cEnsayos.CrearNuevoLaboratorio(nombreLaboratorio, tipoLaboratorio)!=null) {
                    SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                    MessageBox.Show("El Laboratorio fue guardado");
                    this.Close();
                } else {
                    MessageBox.Show("No se pudo crear, compruebe que los datos son correctos y \n" +
                "que no existe un Laboratorio con el mismo nombre.");
                }
            } else {
                MessageBox.Show("No se pudo crear, compruebe que los datos son correctos y \n" +
                    "que no existe un Laboratorio con el mismo nombre.");
            }
        }

        private bool EsValidoNombre() {
            if(!string.IsNullOrEmpty(txtNombre.Text)) {
                nombreLaboratorio =  txtNombre.Text;
                return true;
            }
            return false;
        }

        private void BtnCancelarClick(object sender, EventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            this.Close();
        }
        private void NuevaLaboratorioFormFormClosing(object sender, FormClosingEventArgs e) {
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
