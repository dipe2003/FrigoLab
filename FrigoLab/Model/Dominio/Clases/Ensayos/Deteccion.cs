using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Dominio.Clases.Ensayos {
    public class Deteccion:Resultado {
        public EnumValorDeteccion ValorDeResultadoDeteccion { get; set; }

        #region Metodos
        // Constructores
        public Deteccion() {

        }
        #endregion

    }
}
