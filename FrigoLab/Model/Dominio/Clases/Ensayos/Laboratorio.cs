using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Dominio.Clases.Ensayos {

    public class Laboratorio {

        public int LaboratorioId { get; set; }
        public string NombreDeLaboratorio { get; set; }
        public EnumTipoLaboratorio TipoDeLaboratorio { get; set; }

        #region Asociaciones
        public virtual List<Analisis> AnalisisRealizados { get; set; }

        #endregion

        public Laboratorio() {

        }
    }
}
