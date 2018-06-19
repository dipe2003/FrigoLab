using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Usuarios;
using FrigLab.Model.Sesion;
using System;
using System.Windows.Forms;

namespace FrigLab.View.Usuarios {
    public partial class NuevoUsuario:Form, ICerrar {
        private ControladorUsuarios cUsuarios = new ControladorUsuarios();
        
		private static NuevoUsuario instancia;

        private EnumPermisoUsuario permisoSeleccionado;
        private int padronIngresado;
        private string password;
        private string passConfirm;

        private string nombre;
        private string apellido;
        private string correo;

        private NuevoUsuario() {
            InitializeComponent();
            radioMonitor.Checked=true;
        }
        
        public static NuevoUsuario GetInstancia(){
        	if(instancia == null){
				instancia = new NuevoUsuario();
        	}
			return instancia;
        }
                
        private void GrupoPermisoSeleccion_Click(object sender, EventArgs e){
        	permisoSeleccionado = (EnumPermisoUsuario) Enum.Parse(typeof(EnumPermisoUsuario), (sender as RadioButton).Text);
        }
        
        private void btnGuardar_Click(object sender, EventArgs e) {
            // valores            
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            correo = txtCorreo.Text;

            if(nombre!="" && apellido!="" && passConfirm!= "" && password!="") {
                if(passConfirm!=password) {
                    txtMensaje.Text = "El password no conincide con la confirmacion.";
                    txtMensaje.Visible = true;
                } else {
                    Usuario usuario = cUsuarios.CrearNuevoUsuario(padronIngresado, nombre, apellido, permisoSeleccionado, correo, password);
                    if(usuario!=null) {
                    	SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                        MessageBox.Show("El Usuario fue creado.");
                        this.Close();
                    } else {
                        txtMensaje.Text = "No se creo el usuario. Se deben verificar los datos ingresados.";
                        txtMensaje.Visible = true;
                    }
                }
            } else {
                txtMensaje.Text = "Faltan datos obligatorios.";
                txtMensaje.Visible = true;
            }
        }

        private void txtPadron_TextChanged(object sender, EventArgs e) {
            if(int.TryParse(txtPadron.Text, out padronIngresado)==false) {
                txtMensaje.Text = "El Padron ingresado no es correcto.";
                txtMensaje.Visible = true;
            } else {
                txtMensaje.Text = "";
                txtMensaje.Visible = false;
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e) {
            if(!txtConfirmPass.Text.Equals(txtPass.Text) || (txtPass.Text=="" && txtConfirmPass.Text=="")) {
                txtMensaje.Text = "El password esta vacio o no conincide con la confirmacion.";
                txtMensaje.Visible = true;
            } else {
                txtMensaje.Text = "";
                txtMensaje.Visible = false;
                passConfirm = txtConfirmPass.Text;
                password = txtPass.Text;
            }
        }

        private void NuevaUsuarioFormFormClosing(object sender, FormClosingEventArgs e) {
            SesionDeUsuario.RemoverFormularioAbierto(this);
            instancia = null;
        }
        
        #region ICerrar implementation
        public void CerrarInstancia() {
        	instancia = null;
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
