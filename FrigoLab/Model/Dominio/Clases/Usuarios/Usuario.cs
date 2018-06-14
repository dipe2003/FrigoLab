using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Enumeraciones.Muestreos;
using FrigLab.Model.Dominio.Enumeraciones.Usuarios;
using FrigLab.Model.Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrigLab.Model.Dominio.Clases.Usuarios {

	public class Usuario {

		public int UsuarioId { get; set; }
		public string NombreDeUsuario { get; set; }
		public string ApellidoDeUsuario { get; set; }
		public string CorreoDeUsuario { get; set; }
		public DateTime? FechaNoVigente { get; set; }
		public EnumPermisoUsuario PermisoDeUsuario { get; set; }
        public string NombreCompleto { get {
                return NombreDeUsuario + " " + ApellidoDeUsuario;
            }
		}

        #region Asociaciones
        // Credenciales
        public virtual Credencial Credencial { get; set; }

		// Muestreos
		public List<Muestreo> MuestreosTomados { get; set; }

		// Analisis
		public List<Analisis> AnalisisVerificados { get; set; }
		public List<Analisis> AnalisisRealizados { get; set; }

		#endregion

		#region Metodos
		// Constructores
		public Usuario() {
			this.MuestreosTomados = new List<Muestreo>();
			this.AnalisisRealizados = new List<Analisis>();
			this.AnalisisVerificados = new List<Analisis>();
		}

		#region Credenciales
		// Credenciales
		/// <summary>
		/// Crea la credencial del usuario.
		/// </summary>
		/// <param name="password">Password ingresado.</param>
		public Credencial CrearCredencial(string password) {
			string passwordSeguro = ControladorCredenciales.getPasswordSeguro(password);
			this.Credencial = new Credencial {
				PasswordCredencial = passwordSeguro,
				Usuario = this
			};
			return this.Credencial;
        }

		/// <summary>
		/// Se comprueba que el password ingresado contra el password de la credencial de usuario sean coincidentes.
		/// </summary>
		/// <param name="password">Password ingresado para comprobacion.</param>
		/// <returns>True si coinciden, False en caso contrario.</returns>
		public bool ValidarCredencial(string password) { 
			return ControladorCredenciales.ValidatePassword(password, this.Credencial.PasswordCredencial);
		}
		
		public Credencial EliminarCredencial(){
			Credencial credencial = this.Credencial;
			this.Credencial.Usuario = null;
			this.Credencial = null;
			return credencial;
		}

		#endregion

		#region Muestreos
		// Pool
		/// <summary>
		/// Se crea un nuevo pool.
		/// </summary>
		/// <param name="descripcionDePool">Descripcion del pool.</param>
		/// <param name="fechaDePool">Fecha de creacion del pool.</param>
		/// <returns>Retorna el nuveo pool creado.</returns>
		public Muestreo CrearPool(string descripcionDePool, DateTime fechaDePool) {
			Muestreo nuevoPool = new Pool{
				DescripcionDePool = descripcionDePool,
				FechaCreacionDePool = fechaDePool,
				Usuario = this
			};
			return nuevoPool;
		}

		/// <summary>
		/// Se crea un nuevo muestreo.
		/// </summary>
		/// <param name="fechaHoraDeMuestreo"></param>
		/// <param name="observacionesDeMuestreo"></param>
		/// <param name="numeroDeMuestreo"></param>
		/// <param name="almacenamientoMuestreo"></param>
		/// <param name="tipoMuestreo"></param>
		/// <returns></returns>
		public Muestreo CrearMuestreoIndividual(DateTime fechaHoraDeMuestreo, string observacionesDeMuestreo, 
			int numeroDeMuestreo, EnumAlmacenamientoMuestreo almacenamientoMuestreo, EnumTipoMuestreo tipoMuestreo) {
			Muestreo nuevoMuestreo = new Individual{
				FechaHoraDeMuestreo = fechaHoraDeMuestreo,
				ObservacionesDeMuestreo = observacionesDeMuestreo,
				NumeroDeMuestreo = numeroDeMuestreo,
				AlmacenamientoDeMuestreo = almacenamientoMuestreo,
				TipoDeMuestreo = tipoMuestreo,
				Usuario = this
			};
			this.MuestreosTomados.Add(nuevoMuestreo);
			return nuevoMuestreo;
		}
        
		#endregion
        
		#region	Analisis
          
		/// <summary>
		/// Se completan los atributos fecha de verificación y verificador del analisis.
		/// Se agrega el analisis verificado a la lista de analisis del usuario.
		/// PRE: el analisis fue realizado y tiene un resultado asociado.
		/// </summary>
		/// <param name="analisisVerificado">Analisis verificado por el usuario.</param>
		/// <param name="fechaDeVerificacion">Fecha en que se realizo la verificacion.</param>
		/// <returns>True si se verifico de lo contrario false.</returns>
		public bool VerificarAnalisis(Analisis analisisVerificado, DateTime fechaDeVerificacion) {
			if (analisisVerificado.Resultado != null){
				analisisVerificado.FechaDeVerificacion = fechaDeVerificacion;
				this.AnalisisVerificados.Add(analisisVerificado);
				return true;
			} 
			return false;              
		}
		#endregion

		#endregion

	}
}
