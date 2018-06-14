using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using FrigLab.Model.Dominio.Clases.Requisitos;

namespace FrigLab.Model.Dominio.Clases.Ensayos {
	public class Analisis {
		public int AnalisisId { get; set; }
		public DateTime? FechaDeAnalisis { get; set; }
		public DateTime? FechaDeVerificacion { get; set; }
		public EnumMotivoAnalisis OrigenDeAnalisis { get; set; }

		#region Asociaciones
		// Laboratorio
		public int LaboratorioId { get; set; }
		public virtual Laboratorio Laboratorio { get; set; }

		// Muestreo
		public int MuestreoId { get; set; }
		public virtual Muestreo Muestreo { get; set; }

		// Usuario
		public int? UsuarioVerificadorId { get; set; }
		public virtual Usuario UsuarioVerificador { get; set; }

		public int? UsuarioAnalistaId { get; set; }
		public virtual Usuario UsuarioAnalista { get; set; }

		// Ensayo
		public int EnsayoId { get; set; }
		public virtual Ensayo Ensayo { get; set; }

		// Resultados
		public virtual Resultado Resultado { get; set; }
		

		#endregion

		#region	Metodos

		// Constructores

		public Analisis() {

		}

		// Internos

		/// <summary>
		/// Se comprueba si el analisis fue realizado.
		/// </summary>
		/// <returns>True si el analisis contiene fecha de realizado y resultados.</returns>
		public bool EstaRealizado() {
			return this.FechaDeAnalisis != null && this.Resultado != null;
		}

		/// <summary>
		/// Se compara el resultado del analisis con el limite del ensayo para verificar si es aceptable.
		/// Se verifica segun el tipo de analisis y limite.
		/// Los valores marginales se consideran aceptables.
		/// </summary>
		/// <returns>Retorna true si es aceptable, false si no lo es.</returns>
		public bool EsAceptable() {
			if(EstaRealizado()){
				Limite limite = this.Ensayo.GetLimiteVigente();
				switch (this.Ensayo.TipoDeAnalisis){
					case EnumTipoAnalisis.Busqueda:
						return ((limite as Busqueda).EsAceptable((this.Resultado as Deteccion).ValorDeResultadoDeteccion));
						
					case EnumTipoAnalisis.RecuentoMarginal:
						return ((limite as Marginal).EsAceptable((this.Resultado as Recuento).ValorDeResultadoRecuento));
						
					default:
						return ((limite as Inaceptable).EsAceptable((this.Resultado as Recuento).ValorDeResultadoRecuento));
				}
			}
			return false;
		}
		
		public EnumInterpretacionResultado IntepretarResultado(){
			if(EstaRealizado()){
				Limite limite = this.Ensayo.GetLimiteVigente();
				switch (this.Ensayo.TipoDeAnalisis){
					case EnumTipoAnalisis.Busqueda:
						return ((limite as Busqueda).InterpretarResultado((this.Resultado as Deteccion).ValorDeResultadoDeteccion));
						
					case EnumTipoAnalisis.RecuentoMarginal:
						return ((limite as Marginal).InterpretarResultado((this.Resultado as Recuento).ValorDeResultadoRecuento));
						
					default:
						return ((limite as Inaceptable).InterpretarResultado((this.Resultado as Recuento).ValorDeResultadoRecuento));
				}
			}
			return EnumInterpretacionResultado.SinResultado;
		}

		// Resultados

		/// <summary>
		/// Se crea un resultado de recuento para un analisis
		/// </summary>
		/// <param name="observacionesDeResultado">Observaciones del analista sobre el resultado.</param>
		/// <param name="fechaDeResultado">Fecha en que fue ingresado el resultado.</param>
		/// <param name="valorResultado">Valor de recuento.</param>
		/// <param name="analistaQueRealizoAnalisis">Usuario analista que realizo el analisis.</param>
		/// <param name="fechaDeAnalisis">Fecha en que se realizo el analisis.</param>
		/// <returns>Retorna el nuevo resultado de recuento creado.</returns>
		public Resultado CrearResultadoRecuento(string observacionesDeResultado, DateTime fechaDeResultado,
		                                        float valorResultado, Usuario analistaQueRealizoAnalisis, DateTime fechaDeAnalisis) {
			Resultado nuevoResultado = new Recuento{
				ObservacionesDeResultado = observacionesDeResultado,
				FechaDeResultado = fechaDeResultado,
				ValorDeResultadoRecuento = valorResultado,
				Analisis = this
			};
			this.UsuarioAnalista = analistaQueRealizoAnalisis;
			this.FechaDeAnalisis = fechaDeAnalisis;
			this.Resultado = nuevoResultado;
			return nuevoResultado;
		}

		/// <summary>
		/// Se crea un resultado de una busqueda (deteccion) para un analisis.
		/// </summary>
		/// <param name="observacionesDeResultado">Observaciones del analista sobre el resultado.</param>
		/// <param name="fechaDeResultado">Fecha en que fue ingresado el resultado.</param>
		/// <param name="valorResultado">Valor representativo del resultado según el límite del ensayo.</param>
		/// <param name = "analistaQueRealizoAnalisis">Usuario analista que realizo el analisis.</param>
		/// <param name = "fechaDeAnalisis">Fecha en que se realizo el analisis.</param>
		/// <returns>Retorna el nuevo resultado de deteccion creado.</returns>
		public Resultado CrearResultadoDeteccion(string observacionesDeResultado, DateTime fechaDeResultado,
		                                         EnumValorDeteccion valorResultado, Usuario analistaQueRealizoAnalisis, DateTime fechaDeAnalisis) {
			Resultado nuevoResultado = new Deteccion{
				ObservacionesDeResultado = observacionesDeResultado,
				FechaDeResultado = fechaDeResultado,
				ValorDeResultadoDeteccion = valorResultado,
				Analisis = this
			};
			this.UsuarioAnalista = analistaQueRealizoAnalisis;
			this.FechaDeAnalisis = fechaDeAnalisis;
			this.Resultado = nuevoResultado;
			return nuevoResultado;
		}
		
		/// <summary>
		/// Se elimina el resultado del analisis si el analisis no fue aun verificado.
		/// Se elimina fecha de analisis.
		/// </summary>
		/// <returns>True si se fue elimiado el resultado, False si no lo fue.</returns>
		public bool EliminarResultado() {
			if (this.FechaDeVerificacion == null){
				this.Resultado.Analisis = null;
				this.Resultado = null;
				this.FechaDeAnalisis = null;
				return true;
			}
			return false;
		}

		#endregion

	}
}
