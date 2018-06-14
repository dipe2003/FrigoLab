using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Dominio.Clases.Requisitos {
    public class Busqueda : Limite{
        public EnumValorDeteccion ValorAceptableDeBusqueda { get; set; }
        public EnumValorDeteccion ValorInaceptableDeBusqueda { get; set; }

        #region Metodos
        // Constructores
        public Busqueda() {

        }

		// Internos

		/// <summary>
		/// Se compara el valor recibido con el valor del limite.
		/// </summary>
		/// <param name="valorDeteccion">Valor a comparar.</param>
		/// <returns>True si el resultado es aceptable, false si no es aceptable.</returns>
		public bool EsAceptable(EnumValorDeteccion valorDeteccion) { 
			return valorDeteccion == ValorAceptableDeBusqueda;
		}
		
		public EnumInterpretacionResultado InterpretarResultado(EnumValorDeteccion valorDeteccion){
			if(valorDeteccion == ValorAceptableDeBusqueda){
				return EnumInterpretacionResultado.Aceptable;
			}
			return EnumInterpretacionResultado.Inaceptable;
		}

        #endregion
        
    }
}
