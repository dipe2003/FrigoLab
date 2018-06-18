using System;
using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Usuarios;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using FrigLab.View;


namespace FrigLab.Model.Sesion {
    /// <summary>
    /// Clase estatica que contiene la sesion del usuario.
    /// Mantiene una lista de los formularios abiertos que necesitan ser actualizados 
    /// cuando se realizan cambios en los registros.
    /// </summary>
    public static class SesionDeUsuario {

        private static ControladorUsuarios cUsuarios = new ControladorUsuarios();

        public static Usuario UsuarioLogueado { get; set; }

        public static List<Form> formulariosAbiertos = new List<Form>();

        public static Usuario IniciarSesion(int padronDeUsuario, string passwordDeUsuario) {
        	try{
                Usuario usuario = cUsuarios.ObtenerUsuario(padronDeUsuario);
                if(usuario!=null && usuario.ValidarCredencial(passwordDeUsuario)) {
                    UsuarioLogueado = usuario;
					return UsuarioLogueado;
                }
        	}catch(Exception ex) {
                MessageBox.Show("Existe un problema de comunicacion con la base de datos.\nContacte con el administrador.");
				Application.Exit();
            }
            return null;
        }

        public static bool HaySesionIniciada() {
            return UsuarioLogueado!=null;
        }

        public static void CerrarSesion() {
        	foreach (Form frm in formulariosAbiertos) {
        		try {
        			(frm as ICerrar).CerrarInstancia();
        		} catch (Exception) {}
        	}
        	formulariosAbiertos.Clear();
        	UsuarioLogueado = null;
        }
        
        public static EnumPermisoUsuario PermisoUsuario(){
			return UsuarioLogueado.PermisoDeUsuario;
        }

        public static void ActualizarFormulariosAbiertos(Form formularioAExcluir) {
            foreach(Form formulario in formulariosAbiertos) {
                if(formulario.Name != formularioAExcluir.Name) {
                    formulario.Refresh();
                }
            }
        }

        public static void AgregarFormularioAbierto(Form formularioAbierto) {
            if(!formulariosAbiertos.Contains(formularioAbierto)) {
                formulariosAbiertos.Add(formularioAbierto);
            }
        }

        public static void RemoverFormularioAbierto(Form formularioAbierto) {
            Form form = formulariosAbiertos.FirstOrDefault(f => f.Name == formularioAbierto.Name);
            if(form != null) {
                formulariosAbiertos.Remove(form);
            }
        }

        public static void ActualizarMain() {
            Form form = formulariosAbiertos.FirstOrDefault(f => f.Name == "MainForm");
            if(form != null) {
                (form as FormMain).CambiarInfoSesion();
            }
        }
    }
}
