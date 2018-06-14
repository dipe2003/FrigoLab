using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Sesion;
using miniLabMuestreo.Model.Logica.Ensayos;
using System;
using System.Windows.Forms;

namespace FrigLab.View.Ensayos {
    public partial class EditarEnsayo:Form, ICerrar {
        private static EditarEnsayo instancia;

        private ControladorEnsayos cEnsayos = new ControladorEnsayos();

        private Ensayo ensayoSeleccionado;

        private string nombreEnsayo;
        private string metodoEnsayo;
        private EnumTipoAnalisis tipoAnalisis;
        private EnumClaseMuestra claseMuestra;  

        private EditarEnsayo() {
            InitializeComponent();

            // Tipo de Analisis
            foreach(RadioButton radio in GrupoTipoAnalisis.Controls) {
                radio.CheckedChanged += GrupoTipoAnalisis_Checked;
            }

            // Clase de Muestra
            foreach(RadioButton radio in grupoClaseMuestra.Controls) {
                radio.CheckedChanged += GrupoClaseMuestra_Checked;
            }
        }
        
        public static EditarEnsayo GetInstancia(Ensayo ensayoAEditar) {
            if(instancia == null) {
        		instancia = new EditarEnsayo{
					ensayoSeleccionado = ensayoAEditar
				};
				instancia.CargarDatos();
            }
            return instancia;
        }

        private void CargarDatos() {
            nombreEnsayo = ensayoSeleccionado.NombreDeEnsayo;
            txtNombre.Text = nombreEnsayo;

            metodoEnsayo = ensayoSeleccionado.MetodoDeEnsayo;
            txtMetodo.Text = metodoEnsayo;

            tipoAnalisis = ensayoSeleccionado.TipoDeAnalisis;

            foreach(RadioButton radio in GrupoTipoAnalisis.Controls) {
                switch(tipoAnalisis.ToString()) {
                    case "Busqueda":
                        RadioBusqueda.Checked = true;
                        break;

                    case "Recuento":
                        RadioRecuento.Checked = true;
                        break;

                    default:
                        RadioMarginal.Checked = true;
                        break;
                }
            }

            claseMuestra = ensayoSeleccionado.ClaseDeMuestra;
            foreach(RadioButton radio in grupoClaseMuestra.Controls) {
                if(radio.Text == claseMuestra.ToString()) {
                    radio.Checked = true;
                }
            }
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
                if(cEnsayos.EditarEnsayo(ensayoSeleccionado.EnsayoId, nombreEnsayo, metodoEnsayo, tipoAnalisis, claseMuestra)!=null) {
                    SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                    MessageBox.Show("El Ensayo fue guardado");
                    this.Close();
            	}else{
            		MessageBox.Show("No se pudo actualizar, compruebe que los datos son correctos \n" +
                " y que no existe un Ensayo con el mismo nombre y metodo.");
            	}
            }else{
            	MessageBox.Show("No se pudo actualizar, compruebe que los datos son correctos \n" +
                " y que no existe un Ensayo con el mismo nombre y metodo.");
            }            
        }

        private bool EsValidoNombre() {
            if(!string.IsNullOrEmpty(txtNombre.Text)) {
                nombreEnsayo =  txtNombre.Text;
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
