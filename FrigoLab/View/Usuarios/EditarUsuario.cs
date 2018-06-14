using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Logica.Usuarios;
using FrigLab.Model.Sesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrigLab.View.Usuarios {
    public partial class EditarUsuario:Form, ICerrar {

        private ControladorUsuarios cUsuarios = new ControladorUsuarios();
        private static Usuario usuarioSeleccionado;
        private List<Usuario> usuariosRegistrados;
       private  static EditarUsuario instancia;

        private string nuevoNombre;
        private string nuevoApellido;
        private string nuevoCorreo;

        private EditarUsuario() {

            InitializeComponent();
            usuariosRegistrados = cUsuarios.ListarUsuarios().ToList();

            txtMensaje.Visible = false;
        }

        public static EditarUsuario GetInstancia(Usuario usuarioAEditar) {
            if(instancia==null) {
                instancia = new EditarUsuario();
				usuarioSeleccionado = usuarioAEditar;
				instancia.CargarDatosDeUsuario();
            }
            return instancia;
        }

        private void CargarDatosDeUsuario() {
            txtNombre.Text = usuarioSeleccionado.NombreDeUsuario;
            txtApellido.Text = usuarioSeleccionado.ApellidoDeUsuario;
            txtCorreo.Text = usuarioSeleccionado.CorreoDeUsuario;
            txtPadron.Text = usuarioSeleccionado.UsuarioId.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            if(!ComprobarDatosObligatorios()) {
                txtMensaje.Clear();
                txtMensaje.Text = "Faltan datos obligatorios.";
                txtMensaje.Visible = true;
            } else {
                txtMensaje.Clear();
                txtMensaje.Visible = false;
                // variable para guardar el usuario modificado y actualizar la info de sesion si es necesario.
                Usuario user;
                if((user = cUsuarios.EditarUsuario(usuarioSeleccionado.UsuarioId, nuevoNombre, nuevoApellido, 
                    nuevoCorreo, usuarioSeleccionado.PermisoDeUsuario))!=null) {
                    SesionDeUsuario.ActualizarFormulariosAbiertos(this);
                    // comprobar si es necesario actualizar info de sesion y actualizar.
                    if(SesionDeUsuario.UsuarioLogueado.UsuarioId == usuarioSeleccionado.UsuarioId) {
                        SesionDeUsuario.UsuarioLogueado = user;
                        SesionDeUsuario.ActualizarMain();
                    }                    
                    MessageBox.Show("El usuario fue guardado");
                    this.Close();
                } else {
                    txtMensaje.Clear();
                    txtMensaje.Text = "No se pudo guardar.";
                    txtMensaje.Visible = true;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private bool ComprobarDatosObligatorios() {
            if(txtApellido.Text == "" && txtNombre.Text=="") {
                return false;
            }
            nuevoApellido = txtApellido.Text;
            nuevoNombre = txtNombre.Text;
            nuevoCorreo = txtCorreo.Text;
            return true;
        }
        
		private void BntCambiarCredencialClick(object sender, EventArgs e) {
			Form cambiarCredencialForm = CambiarCredencial.GetInstancia(usuarioSeleccionado);
			cambiarCredencialForm.MdiParent = this.MdiParent;
			SesionDeUsuario.AgregarFormularioAbierto(cambiarCredencialForm);
			cambiarCredencialForm.Show();
		}
        
        private void EditarUsuarioForm_FormClosing(object sender, FormClosingEventArgs e) {
        	SesionDeUsuario.RemoverFormularioAbierto(this);
        	instancia=null;
        }
        
        #region ICerrar implementation
        public void CerrarInstancia() {
        	instancia = null;
        }
        #endregion

    }
}
