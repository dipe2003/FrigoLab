using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;

namespace FrigLab.Model.Dominio.Clases.Requisitos {
    public class Marginal:Limite {
        public float ValorMarginalDeRecuento { get; set; }
        public float ValorInaceptableDeRecuento { get; set; }

        #region Metodos
        // Constructores
        public Marginal() {

        }

		// Internos

		/// <summary>
		/// Se compara el valor recibido con el valor del limite.
		/// </summary>
		/// <param name="valorDeResultado">Valor a comparar.</param>
		/// <returns>True si el resultado es aceptable, false si no es aceptable.</returns>
		public bool EsAceptable(float valorDeResultado) { 
			return ValorInaceptableDeRecuento > valorDeResultado;
		}

		public EnumInterpretacionResultado InterpretarResultado(float valorDeResultado){
			if(valorDeResultado > ValorInaceptableDeRecuento){
				return EnumInterpretacionResultado.Inaceptable;
			}else if(valorDeResultado < ValorInaceptableDeRecuento && valorDeResultado > ValorMarginalDeRecuento){
				return EnumInterpretacionResultado.Marginal;
			}
			return EnumInterpretacionResultado.Inaceptable;
		}
		
        #endregion



    }
}
