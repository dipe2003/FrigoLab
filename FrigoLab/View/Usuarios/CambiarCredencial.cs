/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 19/03/2018
 * Hora: 09:20 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Usuarios;
using FrigLab.Model.Sesion;
using System;
using System.Windows.Forms;

namespace FrigLab.View.Usuarios {
    /// <summary>
    /// Description of CambiarCredencialForm.
    /// </summary>
    public partial class CambiarCredencial : Form, ICerrar{
		
		private static CambiarCredencial instancia;
		
		private ControladorUsuarios cUsuarios = new ControladorUsuarios();
		
		private static Usuario usuarioSeleccionado;
		
		private string passwordActual;
		private string passwordNuevo;
		private string passwordConfirmacion;
		
		private CambiarCredencial(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if(EsAdministrador()){
				txtPass.ReadOnly = true;
				txtPass.Enabled = false;
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public static CambiarCredencial GetInstancia(Usuario usuarioAEditar){
			if(instancia==null){
				instancia = new CambiarCredencial();
				usuarioSeleccionado = instancia.cUsuarios.ObtenerUsuario(usuarioAEditar.UsuarioId);				
			}
			return instancia;
		}

		private void BtnGuardarClick(object sender, EventArgs e) {
			CargarDatos();
			if(!EsAdministrador() && passwordActual!= "" && !usuarioSeleccionado.ValidarCredencial(passwordActual)){
				txtMensaje.Clear();
				txtMensaje.Text = "El password actual no es correto.";
				txtMensaje.Visible = true;
			}else{
				txtMensaje.Clear();
				txtMensaje.Visible = false;
				if(passwordNuevo != "" && passwordConfirmacion == passwordNuevo){
					Usuario usuario;
					if((usuario = cUsuarios.CambiarCredencial(usuarioSeleccionado.UsuarioId, passwordNuevo))!=null){
						SesionDeUsuario.ActualizarFormulariosAbiertos(this);
						// comprobar si es necesario actualizar info de sesion y actualizar.
						if(SesionDeUsuario.UsuarioLogueado.UsuarioId == usuarioSeleccionado.UsuarioId) {
							SesionDeUsuario.UsuarioLogueado = usuario;
							SesionDeUsuario.ActualizarMain();
						}
						MessageBox.Show("El usuario fue guardado");
						this.Close();
					}
				}else{
					txtMensaje.Clear();
					txtMensaje.Text = "Se ingresaron datos incorrectos.";
					txtMensaje.Visible = true;
				}
			}
		}
		
		private bool EsAdministrador(){
			if(SesionDeUsuario.UsuarioLogueado.PermisoDeUsuario== EnumPermisoUsuario.Administrador){				
				return true;
			}
			return false;
		}
		
		private void BtnCancelar_Click(object sender, EventArgs e) {
			this.Close();
		}
		
		private void CargarDatos(){
			passwordActual = txtPass.Text;
			passwordNuevo = txtPassNuevo.Text;
			passwordConfirmacion = txtConfirmPass.Text;
		}
		
		private void CambiarCredencialFormFormClosing(object sender, FormClosingEventArgs e) {
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
