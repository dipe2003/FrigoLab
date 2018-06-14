using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Usuarios;
using FrigLab.Model.Sesion;
using System;
using System.Windows.Forms;

namespace FrigLab.View.Usuarios {
    public partial class EditarUsuarioAdmin:Form, ICerrar {
        private ControladorUsuarios cUsuarios = new ControladorUsuarios();

        private static EditarUsuarioAdmin instancia;

        private Usuario usuarioSeleccionado;

        private string nombre;
        private string apellido;
        private string correo;
        private EnumPermisoUsuario permiso;
        private DateTime? fechaVigencia;

        private EditarUsuarioAdmin() {
            InitializeComponent();

            foreach(RadioButton radioButton in grupoPermiso.Controls) {
                radioButton.CheckedChanged += GrupoPermisoSeleccion_Click;
            }
        }

        public static EditarUsuarioAdmin GetInstancia(Usuario usuarioAEditar) {
            if(instancia==null) {
                instancia = new EditarUsuarioAdmin();
                instancia.usuarioSeleccionado = usuarioAEditar;
                instancia.CargarDatosDeUsuario();
            }
            return instancia;
        }
        
        private void CargarDatosDeUsuario() {
            txtNombre.Text = usuarioSeleccionado.NombreDeUsuario;
            txtApellido.Text = usuarioSeleccionado.ApellidoDeUsuario;
            txtCorreo.Text = usuarioSeleccionado.CorreoDeUsuario;
            txtPadron.Text = usuarioSeleccionado.UsuarioId.ToString();
            permiso = usuarioSeleccionado.PermisoDeUsuario;
            if(usuarioSeleccionado.FechaNoVigente != null) {
                fechaVigencia = usuarioSeleccionado.FechaNoVigente.Value;
                chkVigente.Checked = false;
            } else {
                chkVigente.Checked = true;
            }

            foreach(Control radioButton in grupoPermiso.Controls) {
                if((radioButton as RadioButton).Text == permiso.ToString()) {
                    (radioButton as RadioButton).Checked = true;
                }
            }
        }

        private void GrupoPermisoSeleccion_Click(object sender, EventArgs e) {
            permiso = (EnumPermisoUsuario)Enum.Parse(typeof(EnumPermisoUsuario), (sender as RadioButton).Text);
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
                if((user = cUsuarios.EditarUsuario(usuarioSeleccionado.UsuarioId, nombre, apellido, correo, permiso))!=null) {
                    // comprobar si fue cambiada la fecha de vigencia para guardar el cambio
                    if(usuarioSeleccionado.FechaNoVigente == null && fechaVigencia != null) {
                        cUsuarios.CambiarVigenciaUsuario(usuarioSeleccionado.UsuarioId, false);
                    } else if (usuarioSeleccionado.FechaNoVigente != null && fechaVigencia == null){
                        cUsuarios.CambiarVigenciaUsuario(usuarioSeleccionado.UsuarioId, true);
                    }

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

        private void BntCambiarCredencialClick(object sender, EventArgs e) {
            Form cambiarCredencialForm = CambiarCredencial.GetInstancia(usuarioSeleccionado);
            cambiarCredencialForm.MdiParent = this.MdiParent;
            SesionDeUsuario.AgregarFormularioAbierto(cambiarCredencialForm);
            cambiarCredencialForm.Show();
        }

        private bool ComprobarDatosObligatorios() {
            if(txtApellido.Text == "" && txtNombre.Text=="") {
                return false;
            }
            apellido = txtApellido.Text;
            nombre = txtNombre.Text;
            correo = txtCorreo.Text;
            return true;
        }

        private void ChkVigente_CheckedChanged(object sender, EventArgs e) {
            if((sender as CheckBox).Checked) {
                fechaVigencia = null;
            } else {
                fechaVigencia = new DateTime();
            }
        }
        
        private void EditarUsuarioAdminForm_FormClosing(object sender, FormClosingEventArgs e) {
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
