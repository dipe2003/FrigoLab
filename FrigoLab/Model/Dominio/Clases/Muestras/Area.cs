/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 23/02/2018
 * Time: 02:08 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace FrigLab.Model.Dominio.Clases.Muestras {

	public class Area {

		public int AreaId { get; set; }
        public string NombreDeArea { get; set; }
		public DateTime? FechaNoVigente { get; set; }
		
		#region	Asociaciones
		// Especificacion de Muestras
		public virtual List<EspecificacionDeMuestra> EspecificacionesDeMuestras { get; set; }
		
		// Muestras
		public virtual List<Muestra> Muestras { get; set; }

        #endregion

        #region Metodos
        // Constructores
        public Area() {
            this.EspecificacionesDeMuestras = new List<EspecificacionDeMuestra>();
			this.Muestras = new List<Muestra>();
        }

        #endregion


    }
}
