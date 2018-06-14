using FrigLab.Model.Dominio.Clases.Ensayos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Dominio.Clases.Requisitos {

	public abstract class Limite {

		public int LimiteId { get; set; }
        public string ReferenciaDeLimite { get; set; }
        public DateTime? FechaNoVigente { get; set; }

        #region Asociaciones
        // Requisitos
        public int RequisitoId { get; set; }
        public virtual Requisito Requisito { get; set; }        

        // Ensayos
        public int EnsayoId { get; set; }
        public virtual Ensayo Ensayo { get; set; }
        
        #endregion

        #region	Metodos
        // Constructores
        public Limite() {

        }
		
        #endregion
        
    }
}
