/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 05/03/2018
 * Time: 02:03 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Collections.Generic;
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using FrigLab.Model.Logica.Persistencia;
using System;
using FrigLab.Model.Persistencia;
using System.Linq;

namespace miniLabMuestreo.Model.Logica.Requisitos {
    /// <summary>
    /// Description of ManejadorRequisitos.
    /// </summary>
    public class ControladorRequisitos {
  
        public ControladorRequisitos() { }

        #region Requisitos
        public Requisito CrearNuevoRequisito(string nombreDeRequisito) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Requisito requisitoNuevo = new Requisito {
                    NombreDeRequisito = nombreDeRequisito
                };
                ctx.Requisitos.Add(requisitoNuevo);
                ctx.SaveChanges();
                return requisitoNuevo;
            }
        }

        public Requisito EditarRequisito(int idRequisito, string nombreRequisito) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                IEnumerable<Requisito> requisitos = ctx.Requisitos
                     .Where(r => r.NombreDeRequisito == nombreRequisito)
                     .Where(r => r.RequisitoId != idRequisito);

                if(requisitos.Any()) {
                    return null;
                }

                Requisito requisito = ctx.Requisitos.Find(idRequisito);
                requisito.NombreDeRequisito = nombreRequisito;
                ctx.SaveChanges();
                return requisito;
            }
        }

        public IEnumerable<Requisito> ListarRequisitos() {
            using(FrigLabContext ctx = new FrigLabContext()) {
                return ctx.Requisitos
                    .Include("LimitesDelRequisito.Ensayo")
                    .ToList();
			}
		}

        public bool EliminarRequisito(int idRequisito) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Requisito requisito = ctx.Requisitos.Find(idRequisito);

                if(requisito.LimitesDelRequisito.Any()) {
                    return false;
                }

                ctx.Requisitos.Remove(requisito);
                ctx.SaveChanges();
                return true;
            }
        }

        #endregion

        #region	Limites
        
        public Limite CrearNuevoLimiteBusqueda(int idDeRequisito, int idDeEnsayo, string referenciaDeLimite,
            EnumValorDeteccion valorAceptable, EnumValorDeteccion valorInaceptable) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Requisito requisito = ctx.Requisitos.Find(idDeRequisito);
                Ensayo ensayo = ctx.Ensayos.Find(idDeEnsayo);
                Limite limiteNuevo = requisito.CrearNuevoLimiteBusqueda(ensayo, referenciaDeLimite, valorAceptable, valorInaceptable);
                ctx.Limites.Add(limiteNuevo);
                ctx.SaveChanges();
                return limiteNuevo;
            }
        }

        public Limite CrearNuevoLimiteMarginal(int idDeRequisito, int idDeEnsayo, string referenciaDeLimite,
            float valorMarginal, float valorInaceptable) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Requisito requisito = ctx.Requisitos.Find(idDeRequisito);
                Ensayo ensayo = ctx.Ensayos.Find(idDeEnsayo);
                Limite limiteNuevo = requisito.CrearNuevoLimiteMarginal(ensayo, referenciaDeLimite, valorMarginal, valorInaceptable);
                ctx.Limites.Add(limiteNuevo);
                ctx.SaveChanges();
                return limiteNuevo;
            }
        }

        public Limite CrearNuevoLimiteInaceptable(int idDeRequisito, int idDeEnsayo, string referenciaDeLimite,
            float valorInaceptable) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Requisito requisito = ctx.Requisitos.Find(idDeRequisito);
                Ensayo ensayo = ctx.Ensayos.Find(idDeEnsayo);
                Limite limiteNuevo = requisito.CrearNuevoLimiteInaceptable(ensayo, referenciaDeLimite, valorInaceptable);
                ctx.Limites.Add(limiteNuevo);
                ctx.SaveChanges();
                return limiteNuevo;
            }
        }
        
		public IEnumerable<Limite> ListarLimites() {
            using(FrigLabContext ctx = new FrigLabContext()) {
                return ctx.Limites.ToList();
			}
		}
        
        #endregion
    }
}
