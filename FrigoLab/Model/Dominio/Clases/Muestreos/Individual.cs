using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestreos;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrigLab.Model.Dominio.Clases.Muestreos {
	public class Individual:Muestreo {
		public string ObservacionesDeMuestreo { get; set; }
		public int NumeroDeMuestreo { get; set; }
		public DateTime FechaHoraDeMuestreo { get; set; }
		public EnumAlmacenamientoMuestreo AlmacenamientoDeMuestreo { get; set; }
		public EnumTipoMuestreo TipoDeMuestreo { get; set; }

		#region Asociaciones
		//	Pooles
		public int PoolId { get; set; }
		public virtual Pool Pool { get; set; }        

		#endregion

		#region Metodos

		// Internos

		/// <summary>
		/// Se comprueba si el muestreo pertenecio a un pool.
		/// Se verifica si existe al menos un analisis originado por pool abierto.
		/// </summary>
		/// <returns>Retorna True si el muestreo pertenecio a un pool que fue abierto, False de lo contrario.</returns>
		public bool FueAbierto() {
			Analisis analisis = this.AnalisisDelMuestreo.Find(m => m.OrigenDeAnalisis == EnumMotivoAnalisis.PoolAbierto);
			return analisis != null;
		}

		#endregion
	}
}
