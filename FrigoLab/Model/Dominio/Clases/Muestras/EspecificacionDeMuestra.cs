/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 23/02/2018
 * Time: 02:09 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FrigLab.Model.Dominio.Clases.Muestras {
    /// <summary>
    /// Description of EspecificacionMuestra.
    /// </summary>
    /// 
    public class EspecificacionDeMuestra {

        public int EspecificacionDeMuestraId { get; set; }
        public string NombreDeEspecificacionDeMuestra { get; set; }
        public DateTime? FechaNoVigente { get; set; }
        public EnumClaseMuestra ClaseDeMuestra { get; set; }

        #region	Asociaciones
        // Areas
        public virtual List<Area> Areas { get; set; }

        // Muestras
        public virtual List<Muestra> MuestrasDeEspecifcacionDeMuestra { get; set; }

        #endregion

        #region Metodos
        // Constructores

        public EspecificacionDeMuestra() {
            this.MuestrasDeEspecifcacionDeMuestra = new List<Muestra>();
            this.Areas = new List<Area>();
        }
        
        // Areas
        /// <summary>
        /// Modifica la lista de areas.
        /// Si la especificacion no tiene el area listada, se agrega.
        /// Si la especificacion tienen el30 area no listada se remueve.
        /// </summary>
        /// <param name="areas"></param>
        public void ModificarAreas(List<Area> areas){
        	for (int i = 0; i < this.Areas.Count; i++) {
				Area area = this.Areas.ElementAt(i);
				if(!areas.Contains(area)){
					this.Areas.Remove(area);
					i--;
				}
        	}

        	foreach (Area area in areas) {
        		if(!this.Areas.Contains(area)){
					this.Areas.Add(area);
        		}
        	}
        }

        // Muestras

        /// <summary>
        /// Se crea una muestra de producto y se relaciona con la especificacion.
        /// </summary>
        /// <param name="fechaDeFaena">Fecha de faena del producto.</param>
        /// <param name="fechaDeProduccion">Fecha de produccion del producto.</param>
        /// <param name="identificacionDeMuestra">Identificacion de la muestra de producto</param>
        /// <param name="loteDeProducto">Lote del producto muestreado.</param>
        /// <param name="esRepeticion">Indica si la muestra fue tomada para repetir un ensayo.</param>
        /// <returns>Retorna una nueva muestra de producto.</returns>
		/// <param name = "area"></param>
        public Muestra CrearMuestraDeProducto(string identificacionDeMuestra, DateTime fechaDeFaena, DateTime fechaDeProduccion,
            string loteDeProducto, bool esRepeticion, Area area) {
            Muestra muestraDeProducto = new Producto {
                FechaDeFaena = fechaDeFaena,
                FechaDeProduccion = fechaDeProduccion,
                IdentificacionDeMuestra = identificacionDeMuestra,
                LoteDeProducto = loteDeProducto,
                EsRepeticion = esRepeticion,
                Area = area,
                EspecificacionDeMuestra = this
            };
            this.MuestrasDeEspecifcacionDeMuestra.Add(muestraDeProducto);
            return muestraDeProducto;
        }

        /// <summary>
        /// Se crea una muestra de superficie y se relaciona con la especificacion.
        /// </summary>
        /// <param name="identificacionDeMuestra">Identificacion de la muestra de superficie.</param>
        /// <param name="horarioDeMuestra">Momento en que fue tomada la muestra (preoperativo u operativo).</param>
        /// <param name="enContactoConProducto">True si la superficie muestreada esta en contacto con el producto.</param>
        /// <param name="esRepeticion">Indica si la muestra fue tomada para repetir un ensayo.</param>
        /// <returns>Retorna una nueva muestra de superficie.</returns>
		/// <param name = "area"></param>
        public Muestra CrearMuestraDeSuperficie(string identificacionDeMuestra, EnumHorario horarioDeMuestra, bool enContactoConProducto,
                                               bool esRepeticion, Area area) {
            Muestra muestraDeSuperficie = new Superficie {
                IdentificacionDeMuestra = identificacionDeMuestra,
                HorarioDeMuestra = horarioDeMuestra,
                EnContactoConProducto = enContactoConProducto,
                EsRepeticion = esRepeticion,
                Area = area,
                EspecificacionDeMuestra = this
            };
            this.MuestrasDeEspecifcacionDeMuestra.Add(muestraDeSuperficie);
            return muestraDeSuperficie;
        }

        /// <summary>
        /// Se crea una muestra de operario y se relaciona con la especificacion.
        /// </summary>
        /// <param name="identificacionDeMuestra">Identificacion de la muestra de operario.</param>
        /// <param name="horarioDeMuestra">Momento en que fue tomada la muestra (preoperativo u operativo).</param>
        /// <param name="padronOperario">Numero unico que identifica al operario muestreado.</param>
        /// <param name="nombreDeOperario">Nombre y Apellido del operario muestreado.</param>
        /// <param name="esRepeticion">Indica si la muestra fue tomada para repetir un ensayo.</param>
        /// <returns>Retorna una nueva muestra de operario.</returns>
		/// <param name = "area"></param>
        public Muestra CrearMuestraDeOperario(string identificacionDeMuestra, EnumHorario horarioDeMuestra, int padronOperario,
            string nombreDeOperario, bool esRepeticion, Area area) {
            Muestra muestraDeOperario = new Operario {
                IdentificacionDeMuestra = identificacionDeMuestra,
                HorarioDeMuestra = horarioDeMuestra,
                PadronDeOperario = padronOperario,
                NombreDeOperario = nombreDeOperario,
                EsRepeticion = esRepeticion,
                Area = area,
                EspecificacionDeMuestra = this
            };
            this.MuestrasDeEspecifcacionDeMuestra.Add(muestraDeOperario);
            return muestraDeOperario;
        }

        /// <summary>
        /// Se crea una muestra de ambiente y se relaciona con la especificacion.
        /// </summary>
        /// <param name="identificacionDeMuestra">Identificacion de la muestra de ambiente.</param>
        /// <param name="horarioDeMuestra">Momento en que fue tomada la muestra (preoperativo u operativo).</param>
        /// <param name="esRepeticion">Indica si la muestra fue tomada para repetir un ensayo.</param>
        /// <returns>Retorna una nueva muestra de ambiente.</returns>
        public Muestra CrearMuestraDeAmbiente(string identificacionDeMuestra, EnumHorario horarioDeMuestra, bool esRepeticion, Area area) {
            Muestra muestraDeAmbiente = new Ambiente {
                IdentificacionDeMuestra = identificacionDeMuestra,
                HorarioDeMuestra = horarioDeMuestra,
                EsRepeticion = esRepeticion,
                Area = area,
                EspecificacionDeMuestra = this
            };
            this.MuestrasDeEspecifcacionDeMuestra.Add(muestraDeAmbiente);
            return muestraDeAmbiente;
        }

        /// <summary>
        /// Se crea una muestra de tipo Otra y se relaciona con la especificacion.
        /// </summary>
        /// <param name="identificacionDeMuestra">Identificacion de la muestra tomada.</param>
        /// <param name="esRepeticion">Indica si la muestra fue tomada para repetir un ensayo.</param>
        /// <returns>Retorna una nueva muestra.</returns>
		/// <param name = "enContactoProducto"></param>
		/// <param name = "area"></param>
        public Muestra CrearOtraMuestra(string identificacionDeMuestra, bool esRepeticion, Area area, bool enContactoProducto) {
            Muestra otraMuestra = new Otra {
                IdentificacionDeMuestra = identificacionDeMuestra,
                EsRepeticion = esRepeticion,
                EnContactoConProducto = enContactoProducto,
                Area = area,
                EspecificacionDeMuestra = this
            };
            this.MuestrasDeEspecifcacionDeMuestra.Add(otraMuestra);
            return otraMuestra;
        }

        #endregion

    }
}
