using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Dominio.Clases.Ensayos {

    public abstract class Resultado {
public int ResultadoId { get; set; }
        public string ObservacionesDeResultado { get; set; }
        public DateTime FechaDeResultado { get; set; }

        #region Asociaciones
        public int AnalisisId { get; set; }
        public virtual Analisis Analisis { get; set; }        

        #endregion
        #region Metodos
        // Constructores
        public Resultado() {

        }
        #endregion

    }
}
