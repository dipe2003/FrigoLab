/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 14/03/2018
 * Hora: 10:34 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Sesion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrigLab.View.Areas {
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class NuevaArea:Form, ICerrar {

		private ControladorAreas cAreas = new ControladorAreas();

        static NuevaArea instancia;

		private NuevaArea() {
			InitializeComponent();
		}

        public static NuevaArea getInstancia() {
            if(instancia==null) {
                instancia = new NuevaArea();
            }
            return instancia;
        }
        
		private  void BtnGuardarClick(object sender, EventArgs e) {
			string nombre = txtNombre.Text;
            if(!string.IsNullOrEmpty(nombre) && cAreas.CrearNuevaArea(nombre)!=null) {
                SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                MessageBox.Show("El área fue guardada");
                this.Close();
            } else {
                MessageBox.Show("No se pudo crear, compruebe que los datos son correctos y que no existe un Area con el mismo nombre.");
            }
        }
		private void BtnCancelarClick(object sender, EventArgs e) {
			SesionDeUsuario.RemoverFormularioAbierto(this);
			this.Close();
		}
		private void NuevaAreaFormFormClosing(object sender, FormClosingEventArgs e) {
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
