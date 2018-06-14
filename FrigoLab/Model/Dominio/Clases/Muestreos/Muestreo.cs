/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 24/02/2018
 * Time: 11:29 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrigLab.Model.Dominio.Clases.Muestreos {
    /// <summary>
    /// Description of Muestreo.
    /// </summary>
    public abstract class Muestreo {

    	public int MuestreoId { get; set; }

        #region	Asociaciones

        // Muestras
        public int MuestraId { get; set; }
        public virtual Muestra Muestra { get; set; }

        // Usuarios
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }        

        // Analisis
        public virtual List<Analisis> AnalisisDelMuestreo { get; set; }

        #endregion

        #region Metodos
        
        // Constructores
        
        public Muestreo() {
            this.AnalisisDelMuestreo = new List<Analisis>();
        }

        // Internos

        /// <summary>
        /// Se comprueba si el muestreo esta habilitado para los requisitos.
        /// Se verifica que todos los analisis tienen resultados aceptables.
        /// </summary>
        /// <returns>Retorna True si el muestreo esta habilitado, False si no lo esta o no tiene analisis asociados.</returns>
        public bool EstaHabilitado() {
            if(!this.AnalisisDelMuestreo.Any()) {
                return false;
            } else {
                bool aceptable = true;
                foreach(Analisis analisis in AnalisisDelMuestreo) {
                    if(!analisis.EsAceptable()) {
                        aceptable = false;
                        break;
                    } else {
                        if(analisis.FechaDeVerificacion == null) {
                            aceptable = false;
                        }
                    }
                }
                return aceptable;
            }
        }
        
        /// <summary>
        /// Se genera un nuevo lote de analisis sin resultados basados en los realizados para el muestreo con resultado indeterminado o 
        /// potencial.
        /// </summary>
        public void ConfirmarResultado() {
            foreach(Analisis analisis in this.AnalisisDelMuestreo) {
                if((analisis.Resultado as Deteccion).ValorDeResultadoDeteccion == EnumValorDeteccion.Indeterminado || 
                    ((analisis.Resultado as Deteccion).ValorDeResultadoDeteccion == EnumValorDeteccion.Potencial)) {
                    analisis.Ensayo.CrearAnalisis(analisis.Laboratorio, this, EnumMotivoAnalisis.Confirmacion);
                }
            }
        }
        
        /// <summary>
        /// Se quita el analisis de los analisis del muestreo.
        /// PRE: El analisis no puede estar realizado ni tener resultado asociado.
        /// </summary>
        /// <param name="analisisAQuitar">Analisis que se va a quitar del muestreo.</param>
        /// <returns>True si se fue elimiado el analisis, False si no lo fue.</returns>
        public bool QuitarAnalisis(Analisis analisisAQuitar) {
            if(!analisisAQuitar.EstaRealizado()) {
                Analisis analisis = this.AnalisisDelMuestreo.Find(a => a.AnalisisId == analisisAQuitar.AnalisisId);
                analisis.Muestreo = null;
                this.AnalisisDelMuestreo.Remove(analisis);
				return true;
			}
			return false;
        }

        /// <summary>
        /// Verifica que existan analisis del ensayo indicado, asociados al muestreo
        /// </summary>
        /// <param name="idEnsayo"></param>
        /// <returns>True: si esta asociado.</returns>
        public bool EsEnsayoAsociado(int idEnsayo) {
            foreach(Analisis analisis in this.AnalisisDelMuestreo) {
                if(analisis.Ensayo.EnsayoId == idEnsayo) {
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>
        /// Verifica que el muestreo contenga por lo menos 1 resultado.
        /// </summary>
        /// <returns></returns>
        public bool ExistenResultados(){
			if (this.AnalisisDelMuestreo.Any()){
				for (int i = 0; i < this.AnalisisDelMuestreo.Count; i++){
        			if(AnalisisDelMuestreo.ElementAt(i).EstaRealizado()){
						return true;
        			}
				}
			}
			return false;
        }

        /// <summary>
        /// Verifica si todos los analisis con resultados estan verificados.
        /// </summary>
        /// <returns></returns>
        public bool EstaVerificado(){
            int contador = AnalisisDelMuestreo.Where(a => a.FechaDeVerificacion != null).ToList().Count;
            return contador == AnalisisDelMuestreo.Count;
        }

        /// <summary>
        /// Verifica si todos los analisis agregados al muestreo contienen resultados.
        /// </summary>
        /// <returns></returns>
        public bool EstaAnalizado() {
            int contador = AnalisisDelMuestreo.Where(a => a.Resultado != null).ToList().Count;
            return contador == AnalisisDelMuestreo.Count;
        }
        #endregion

    }
}
