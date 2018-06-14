/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 23/02/2018
 * Time: 02:11 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using FrigLab.Model.Dominio.Clases.Muestreos;
using System;

namespace FrigLab.Model.Dominio.Clases.Muestras {
    /// <summary>
    /// Description of Muestra.
    /// </summary>

    public abstract class Muestra {

        public int MuestraId { get; set; }
        public string IdentificacionDeMuestra { get; set; }
        public bool EsRepeticion { get; set; }

        #region	Asociaciones
        // Especificacion de Muestras  
        public int EspecificacionDeMuestraId { get; set; }
        public virtual EspecificacionDeMuestra EspecificacionDeMuestra { get; set; }
        
        // Muestreos
        public int MuestreoId { get; set; }        
        public virtual Muestreo Muestreo { get; set; }
        
        // Area
        public int AreaId { get; set; }
        public virtual Area Area { get; set; }
        
        #endregion

        #region Metodods
        // Constructores
        public Muestra() {
        }

        #endregion

    }
}
