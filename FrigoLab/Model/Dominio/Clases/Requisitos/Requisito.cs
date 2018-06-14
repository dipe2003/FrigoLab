using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Dominio.Clases.Requisitos {

	public class Requisito {

        public int RequisitoId { get; set; }
        public string NombreDeRequisito { get; set; }

        #region Asociaciones

        // Limites
        public virtual List<Limite> LimitesDelRequisito { get; set; }

        #endregion

        #region	Metodos

        // Constructores
        public Requisito() {
            this.LimitesDelRequisito = new List<Limite>();
        }

        // Limites

        /// <summary>
        /// Se crea el límite de busqueda y se asocia al requisito y ensayo correspondiente.
        /// </summary>
        /// <param name="referenciaDeLimite">Documento que establece el limite.</param>
        /// <param name="ensayo">Documento que establece el limite.</param>
        /// <param name="valorAceptable">Valor definido como resultado aceptable.</param>
        /// <param name="valorInaceptable">Valor definido como resultado inaceptable.</param>
        /// <returns>Retorna el nuevo limite creado.</returns>
        public Limite CrearNuevoLimiteBusqueda(Ensayo ensayo, string referenciaDeLimite,EnumValorDeteccion valorAceptable, 
                                               EnumValorDeteccion valorInaceptable) {            
            Busqueda limite = new Busqueda {
                ReferenciaDeLimite = referenciaDeLimite,
                ValorInaceptableDeBusqueda = valorInaceptable,
                ValorAceptableDeBusqueda = valorAceptable,
                Ensayo = ensayo
            };

            Limite existente = this.LimitesDelRequisito
                .Where(l => l.Ensayo.EnsayoId == ensayo.EnsayoId)
                .Where(l => l.Ensayo.ClaseDeMuestra == ensayo.ClaseDeMuestra)
                .Where(l => l.Ensayo.TipoDeAnalisis == ensayo.TipoDeAnalisis)
                .Where(l => l.FechaNoVigente == null)
                .FirstOrDefault();

            if(existente != null) {
                DarDeBajaLimite(existente);
            }

            this.LimitesDelRequisito.Add(limite);
            ensayo.LimitesDeEnsayo.Add(limite);
            return limite;
        }

        /// <summary>
        /// Se crea el límite de recuento con valores marginal e inaceptable. Se asocia al requisito y ensayo correspondiente.
        /// Todos los límites vigentes del requisito y ensayo anteriores quedan anulados (fecha no vigente).
        /// </summary>
        /// <param name="referenciaDeLimite">Documento que establece el limite.</param>
        /// <param name="ensayo">Ensayo para el cual se esta creando el limite.</param>
        /// <param name="valorMarginal">Valor definido como resultado marginal.</param>
        /// <param name="valorInaceptable">Valor definido como resultado inaceptable.</param>
        /// <returns>Retorna el nuevo limite creado.</returns>
        public Limite CrearNuevoLimiteMarginal(Ensayo ensayo, string referenciaDeLimite, float valorMarginal, float valorInaceptable) {
            Marginal limite = new Marginal {
                ReferenciaDeLimite = referenciaDeLimite,
                ValorMarginalDeRecuento = valorMarginal,
                ValorInaceptableDeRecuento = valorInaceptable,
                Ensayo = ensayo
            };

            Limite existente = this.LimitesDelRequisito
                .Where(l => l.Ensayo.EnsayoId == ensayo.EnsayoId)
                .Where(l => l.Ensayo.ClaseDeMuestra == ensayo.ClaseDeMuestra)
                .Where(l => l.Ensayo.TipoDeAnalisis == ensayo.TipoDeAnalisis)
                .Where(l => l.FechaNoVigente == null)
                .FirstOrDefault();

            if(existente != null) {
                DarDeBajaLimite(existente);
            }

            this.LimitesDelRequisito.Add(limite);
            ensayo.LimitesDeEnsayo.Add(limite);
            return limite;
        }

        /// <summary>
        /// Se crea el límite de recuento con valor inaceptable. Se asocia al requisito y ensayo correspondiente.
        /// </summary>
        /// <param name="ensayo">Ensayo para el cual se esta creando el limite.</param>
        /// <param name="referenciaDeLimite">Documento que establece el limite.</param>
        /// <param name="valorInaceptable">Valor definido como resultado inaceptable.</param>
        /// <returns>Retorna el nuevo limite creado.</returns>
        public Limite CrearNuevoLimiteInaceptable(Ensayo ensayo, string referenciaDeLimite,float valorInaceptable) {
            Inaceptable limite = new Inaceptable {
                ReferenciaDeLimite= referenciaDeLimite,
                ValorInaceptableDeRecuento = valorInaceptable,
                Ensayo = ensayo
            };

            Limite existente = this.LimitesDelRequisito
                .Where(l => l.Ensayo.EnsayoId == ensayo.EnsayoId)
                .Where(l => l.Ensayo.ClaseDeMuestra == ensayo.ClaseDeMuestra)
                .Where(l=>l.Ensayo.TipoDeAnalisis == ensayo.TipoDeAnalisis)
                .Where( l=> l.FechaNoVigente == null)
                .FirstOrDefault();
            if(existente != null) {
                DarDeBajaLimite(existente);
            }

            this.LimitesDelRequisito.Add(limite);
            ensayo.LimitesDeEnsayo.Add(limite);
            return limite;
        }

        /// <summary>
        /// Se agrega fecha no vigente igual a la actual al limite.
        /// </summary>
        /// <param name="limiteParaBaja"></param>
        public void DarDeBajaLimite(Limite limiteParaBaja) {
            Limite limite = this.LimitesDelRequisito.Find(l => l.LimiteId == limiteParaBaja.LimiteId);
            limite.FechaNoVigente = new DateTime();
            limite.FechaNoVigente = DateTime.Today;
        }

        /// <summary>
        /// Se elimina fecha no vigente igual a la actual al limite.
        /// Todos los limites del requisito y ensayo quedan no vigentes.
        /// </summary>
        /// <param name="limiteParaAlta"></param>
        public void DarDeAltaLimite(Limite limiteParaAlta) {
            List<Limite> limites = this.LimitesDelRequisito.FindAll(l => l.Ensayo.Equals(limiteParaAlta.Ensayo));
            foreach(Limite lim in limites) {
                lim.FechaNoVigente = new DateTime();
                lim.FechaNoVigente = DateTime.Today;
            }
            Limite limite = this.LimitesDelRequisito.Find(l => l.LimiteId == limiteParaAlta.LimiteId);
            limite.FechaNoVigente = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limiteAEliminar"></param>
        /// <returns></returns>
        public bool EliminarLimite(Limite limiteAEliminar) {
            if(!limiteAEliminar.Ensayo.AnalisisDelEnsayo.Any()) {
                Limite limite = this.LimitesDelRequisito.Find(l => l.LimiteId == limiteAEliminar.LimiteId);
                limite.Ensayo.LimitesDeEnsayo.Remove(limite);
                limite.Ensayo = null;
                limite.Requisito = null;
                this.LimitesDelRequisito.Remove(limite);
                return true;
            }
            return false;
        }
        #endregion

    }
}
