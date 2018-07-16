using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Sesion;

namespace FrigLab.View.Buscar{
    public partial class BuscarCodigo:Form, ICerrar {

        private static BuscarCodigo instancia;

        private EnumClaseMuestra claseMuestra;
        private int idMuestreo;

        public static BuscarCodigo GetInstancia() {
            if(instancia == null) {
                instancia = new BuscarCodigo();
            }
            return instancia;
        }

        private BuscarCodigo() {
            InitializeComponent();
        }

        private void textBoxCodigoNumerico_TextChanged(object sender, EventArgs e) {
            if(int.TryParse((sender as TextBox).Text, out idMuestreo)) {
                textBoxCodigoBarras.Text = idMuestreo.ToString();
            } else {
                MessageBox.Show("Código no válido.");
            }
        }

        private EnumClaseMuestra ObtenerClaseMuestra(int codigo) {
            EnumClaseMuestra clase = (EnumClaseMuestra) (int.Parse(codigo.ToString().ElementAt(0).ToString()));
            return clase;
        }

        private void buttonCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e) {
            claseMuestra= ObtenerClaseMuestra(idMuestreo);
        }

        public void CerrarInstancia() {
            instancia = null;
        }

        private void BuscarCodigo_FormClosing(object sender, FormClosingEventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            instancia=null;
        }
    }
}
