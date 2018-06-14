using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrigLab.Model.Persistencia;

namespace FrigLab.Model.Logica.Usuarios {
    class ControladorUsuarios {

        public ControladorUsuarios() {}

        public Usuario CrearNuevoUsuario(int idDeUsuario, string nombreUsuario, string apellidoUsuario, 
                                         EnumPermisoUsuario permisoUsuario, string correoUsuario, string passwordUsuario) {
			using (FrigLabContext ctx = new FrigLabContext()){
        		if(ctx.Usuarios.Find(idDeUsuario) != null) {
        			return null;
        		}
			
			Usuario nuevoUsuario = new Usuario {
                    UsuarioId = idDeUsuario,
                    NombreDeUsuario = nombreUsuario,
                    ApellidoDeUsuario = apellidoUsuario,
                    PermisoDeUsuario = permisoUsuario,
                    CorreoDeUsuario = correoUsuario
                };
                nuevoUsuario.CrearCredencial(passwordUsuario);
                ctx.Usuarios.Add(nuevoUsuario);
                ctx.SaveChanges();
				return nuevoUsuario;     
            }
        }

        public Usuario EditarUsuario(int idUsuario, string nombreUsuario, string apellidoUsuario, 
            string correoUsuario, EnumPermisoUsuario permisoUsuario) {
			using (FrigLabContext ctx = new FrigLabContext()){
				Usuario usuario = ctx.Usuarios.Find(idUsuario);
				usuario.NombreDeUsuario = nombreUsuario;
				usuario.ApellidoDeUsuario = apellidoUsuario;
				usuario.CorreoDeUsuario = correoUsuario;
                usuario.PermisoDeUsuario = permisoUsuario;
				ctx.SaveChanges();
				return usuario;
			}
        }
        
        
        public Usuario CambiarVigenciaUsuario(int idUsuario, bool vigente) {
			using (FrigLabContext ctx = new FrigLabContext()){
				Usuario usuario = ctx.Usuarios.Find(idUsuario);
				if (vigente){
					usuario.FechaNoVigente = null;
				} else {
					DateTime fecha = new DateTime();
					fecha = DateTime.Today;
					usuario.FechaNoVigente = fecha;
				}
				ctx.SaveChanges();
				return usuario;
			}
        }
        
        public IEnumerable<Usuario> ListarUsuarios(bool incluirNoVigentes = true) {
			using (FrigLabContext ctx = new FrigLabContext()){
				IEnumerable<Usuario> usuariosRegistrados = ctx.Usuarios.ToList();
				if (incluirNoVigentes){
					return usuariosRegistrados;
				}
				return usuariosRegistrados.Where(u => u.FechaNoVigente != null);
			}
        }
        
        public Usuario ObtenerUsuario(int idUsuario) {
			using (FrigLabContext ctx = new FrigLabContext()){
        		return ctx.Usuarios
        			.Include("Credencial")
        			.Single(u=>u.UsuarioId == idUsuario);
			}
        }
        
        public Usuario CambiarCredencial(int idUsuario, string passwordNuevo){
        	using (FrigLabContext ctx = new FrigLabContext()){
				Usuario usuario = ctx.Usuarios.Find(idUsuario);
				usuario.EliminarCredencial();
				usuario.CrearCredencial(passwordNuevo);
				ctx.SaveChanges();
				return usuario;
        	}
        }
    }
}
