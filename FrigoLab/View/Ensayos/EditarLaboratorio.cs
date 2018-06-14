using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Windows.Forms;

namespace FrigLab.View.Ensayos {
    public partial class EditarLaboratorio:Form, ICerrar {
        private static EditarLaboratorio instancia;

        private ControladorEnsayos cEnsayos = new ControladorEnsayos();

        private Laboratorio laboratorioSeleccionado;

        private string nombreLaboratorio;
        private EnumTipoLaboratorio tipoLaboratorio;

        private EditarLaboratorio() {
            InitializeComponent();

            foreach(RadioButton radio in GrupoTipoLab.Controls) {
                radio.CheckedChanged += GrupoTipoLab_CheckedChanged;
            }
        }

        public static EditarLaboratorio GetInstancia(Laboratorio laboratorioAEditar) {
            if(instancia == null){
        		instancia = new EditarLaboratorio{
					laboratorioSeleccionado = laboratorioAEditar
				};
				instancia.CargarDatos();
            }
            return instancia;
        }

        private void CargarDatos() {
            tipoLaboratorio = laboratorioSeleccionado.TipoDeLaboratorio;
            if(tipoLaboratorio.ToString() == "Interno") {
                radioInterno.Checked = true;
            } else {
                radioExterno.Checked = true;
            }

            nombreLaboratorio = laboratorioSeleccionado.NombreDeLaboratorio;
            txtNombre.Text = nombreLaboratorio;
        }

        private void GrupoTipoLab_CheckedChanged(object sender, EventArgs e) {
            tipoLaboratorio = (EnumTipoLaboratorio)Enum.Parse(typeof(EnumTipoLaboratorio), (sender as RadioButton).Text);
        }

        private void BtnGuardarClick(object sender, EventArgs e) {
            if(EsValidoNombre()) {
                if(cEnsayos.EditarLaboratorio(laboratorioSeleccionado.LaboratorioId, tipoLaboratorio, nombreLaboratorio)!=null) {
                    SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                    MessageBox.Show("El Laboratorio fue guardado");
                    this.Close();
                }
            }
            MessageBox.Show("No se pudo actualizar, compruebe que los datos son correctos \n" +
                "y que no existe un Laboratorio con el mismo nombre.");
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
        private void EditarLaboratorioFormFormClosing(object sender, FormClosingEventArgs e) {
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
