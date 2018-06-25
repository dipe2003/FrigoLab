using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Dominio.Clases.Ensayos {
    public class Ensayo {

        public int EnsayoId { get; set; }
        public string NombreDeEnsayo { get; set; }
        public string MetodoDeEnsayo{ get; set; }
        public EnumTipoAnalisis TipoDeAnalisis { get; set; }
        public EnumClaseMuestra ClaseDeMuestra { get; set; }

        #region Asociaciones

        // Limite
        public virtual List<Limite> LimitesDeEnsayo { get; set; }

        // Analisis
        public  List<Analisis> AnalisisDelEnsayo { get; set; }

        #endregion

        #region	Metodos

        // Constructores        
        public Ensayo() {
			this.LimitesDeEnsayo = new List<Limite>();
			this.AnalisisDelEnsayo = new List<Analisis>();
        }

        // Analisis 

        /// <summary>
        /// Se crea un nuevo analisis para el muestreo especificado a realizar en el laboratorio determinado.
        /// Se asocia al ensayo.
        /// </summary>
        /// <param name="laboratorioDeAnalisis">Laboratorio responsable del analisis.</param>
		/// <param name = "muestreoAnalizado"></param>
        /// <param name="origenDeAnalisis">Origen del analisis (por requisito, por confirmacion, o por pool abierto).</param>
        /// <returns>Retorna el nuevo analisis creado.</returns>
        public Analisis CrearAnalisis(Laboratorio laboratorioDeAnalisis, Muestreo muestreoAnalizado, EnumMotivoAnalisis origenDeAnalisis) {
            Analisis nuevoAnalisis = new Analisis {
                Laboratorio = laboratorioDeAnalisis,
                OrigenDeAnalisis = origenDeAnalisis,
                Muestreo = muestreoAnalizado,
                Ensayo = this
            };
            this.AnalisisDelEnsayo.Add(nuevoAnalisis);
            return nuevoAnalisis;
        }

        /// <summary>
        /// Se elimina el analisis del sistema.
        /// PRE: el analisis no puede estar realizado ni tener resultado asociado.
        /// </summary>
        /// <param name="analisisAEliminar">Analisis que va a ser eliminado.</param>
        /// <returns>True si fue eliminado el analisis, False si no lo fue.</returns>
        public bool EliminarAnalisis(Analisis analisisAEliminar) {
            if(!analisisAEliminar.EstaRealizado()) {
                Analisis analisis = this.AnalisisDelEnsayo.Find(a => a.AnalisisId == analisisAEliminar.AnalisisId);
                analisis.Muestreo.QuitarAnalisis(analisis);
                analisis.Ensayo = null;
                this.AnalisisDelEnsayo.Remove(analisis);
                return true;
            }
            return false;
        }
        
        public bool ContieneAnalisis(Analisis analisis){
			return this.AnalisisDelEnsayo.Any(a => a.AnalisisId == analisis.AnalisisId);
        }
        // Limites

        /// <summary>
        /// Se busca en los limites asociados el limite vigente (sin fecha de no vigencia).
        /// </summary>
        /// <returns>Limite vigente.</returns>
        public Limite GetLimiteVigente() {
            return this.LimitesDeEnsayo.Find(l => l.FechaNoVigente == null);
        }
        #endregion


    }
}
