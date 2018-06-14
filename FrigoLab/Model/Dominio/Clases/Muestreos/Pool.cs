/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 24/02/2018
 * Time: 11:28 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using System;
using System.Collections.Generic;

namespace FrigLab.Model.Dominio.Clases.Muestreos {
    /// <summary>
    /// Description of Pool.
    /// </summary>
    public class Pool:Muestreo {
        public DateTime FechaCreacionDePool { get; set; }
        public string DescripcionDePool { get; set; }
        public bool FueAbierto { get; set; }

        #region Asociaciones
        // Muestreos
        public virtual List<Muestreo> MuestreosDePool { get; set; }

        #endregion

        #region Metodos
        // Constructores

        public Pool() {
            this.MuestreosDePool = new List<Muestreo>();
        }

        // Muestreos

        /// <summary>
        /// Se agrega el muestreo al pool.
        /// </summary>
        /// <param name="muestreo"></param>
        public void AgregarMuestreo(Muestreo muestreo) {
            this.MuestreosDePool.Add(muestreo);
            (muestreo as Individual).Pool = this;
        }

        /// <summary>
        /// Se quita el muestreo del pool.
        /// </summary>
        /// <param name="muestreo"></param>
        public Muestreo QuitarMuestreo(Muestreo muestreo) {
            this.MuestreosDePool.Remove(muestreo);
            (muestreo as Individual).Pool = null;
            return muestreo;
        }
        #endregion

    }
}
