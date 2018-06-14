using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrigLab.Model.Persistencia;

namespace FrigLab.Model.Logica.Muestras {
    class ControladorMuestras {

        #region Especificacion de Muestras
        public EspecificacionDeMuestra CrearEspecificacionDeMuestra(List<int> idsArea, string nombre, EnumClaseMuestra claseMuestra) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                IEnumerable<EspecificacionDeMuestra> especificacionesRegistradas = ctx.EspecificacionesDeMuestras
                    .Include("Areas")
                    .Where(a => a.NombreDeEspecificacionDeMuestra.ToLower() == nombre.ToLower())
                    .Where(a => a.ClaseDeMuestra == claseMuestra);

                if(especificacionesRegistradas.Any()) {
                    return null;
                }
                EspecificacionDeMuestra especificacion = new EspecificacionDeMuestra {
                    ClaseDeMuestra = claseMuestra,
                    NombreDeEspecificacionDeMuestra = nombre
                };
                foreach(int id in idsArea) {
                    Area area = ctx.Areas.Find(id);
                    especificacion.Areas.Add(area);
                }
                ctx.EspecificacionesDeMuestras.Add(especificacion);
                ctx.SaveChanges();
                return especificacion;
            }
        }

        public EspecificacionDeMuestra ObtenerEspecificacionDeMuestra(int idEspecificacion) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                return ctx.EspecificacionesDeMuestras.Find(idEspecificacion);
            }
        }

        public IEnumerable<EspecificacionDeMuestra> ListarEspecificacionesDeMuestras(bool incluirNoVigentes = true) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                IEnumerable<EspecificacionDeMuestra> especificacionDeMuestras = ctx.EspecificacionesDeMuestras
                	.Include("MuestrasDeEspecifcacionDeMuestra")
                	.Include("Areas").ToList();
                if(!incluirNoVigentes) {
                    return especificacionDeMuestras.Where(esp => esp.FechaNoVigente == null);
                }

                return especificacionDeMuestras;
            }
        }

        public EspecificacionDeMuestra EditarEspecificacionDeMuestra(IList<int> idsArea, int idEspecificacion, string nombreEspecificacion, EnumClaseMuestra claseMuestra) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                IEnumerable<EspecificacionDeMuestra> especificacionesRegistradas = ctx.EspecificacionesDeMuestras
                    .Where(a => a.NombreDeEspecificacionDeMuestra == nombreEspecificacion)
                    .Where(a => a.ClaseDeMuestra == claseMuestra)
                    .Where(a => a.EspecificacionDeMuestraId != idEspecificacion);

                if(especificacionesRegistradas.Any()) {
                    return null;
                }

                EspecificacionDeMuestra especificacion = ctx.EspecificacionesDeMuestras
                    .Include("Areas")
                    .Single(es => es.EspecificacionDeMuestraId == idEspecificacion);

                especificacion.NombreDeEspecificacionDeMuestra = nombreEspecificacion;
                especificacion.ClaseDeMuestra = claseMuestra;

                IEnumerable<Area> areas = ctx.Areas.Where(a => idsArea.Contains(a.AreaId));
                especificacion.ModificarAreas(areas.ToList());
                ctx.SaveChanges();
                return especificacion;
            }
        }

        public bool EliminarEspecificacionDeMuestra(int idEspecificacion) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                EspecificacionDeMuestra especificacion = ctx.EspecificacionesDeMuestras.Find(idEspecificacion);
                if(especificacion.MuestrasDeEspecifcacionDeMuestra.Any()) {
                    return false;
                }
                ctx.EspecificacionesDeMuestras.Remove(especificacion);
                ctx.SaveChanges();
            }
            return true;
        }

        #endregion

        #region Muestra

        public Muestra CrearNuevaMuestraProducto(int idEspecificacionDeMuestra, string identificacionDeMuestra, bool esRepeticion,
                                                 DateTime fechaDeFaena, DateTime fechaDeProduccion, string loteProducto, int idArea) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                EspecificacionDeMuestra especificacion = ctx.EspecificacionesDeMuestras.Find(idEspecificacionDeMuestra);
                Area area = ctx.Areas.Find(idArea);
                Muestra nuevaMuestra = especificacion.CrearMuestraDeProducto(identificacionDeMuestra, 
                                                                             fechaDeFaena,
                                                                             fechaDeProduccion,
                                                                             loteProducto,
                                                                             esRepeticion,
                                                                             area);
				
                ctx.Muestras.Add(nuevaMuestra);
                ctx.SaveChanges();
                return nuevaMuestra;
            }
        }

        public Muestra CrearNuevaMuestraAmbiente(int idEspecificacionDeMuestra, string identificacionDeMuestra, bool esRepeticion,
                                                EnumHorario horarioDeMuestra, int idArea) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                EspecificacionDeMuestra especificacion = ctx.EspecificacionesDeMuestras.Find(idEspecificacionDeMuestra);
                Area area = ctx.Areas.Find(idArea);
                Muestra nuevaMuestra = especificacion.CrearMuestraDeAmbiente(identificacionDeMuestra,
                                                                             horarioDeMuestra,
                                                                             esRepeticion,
                                                                             area);
                ctx.Muestras.Add(nuevaMuestra);
                ctx.SaveChanges();
                return nuevaMuestra;
            }
        }

        public Muestra CrearNuevaMuestraSuperficie(int idEspecificacionDeMuestra, string identificacionDeMuestra, bool esRepeticion,
                                               EnumHorario horarioDeMuestra, bool enContactoConProducto, int idArea) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                EspecificacionDeMuestra especificacion = ctx.EspecificacionesDeMuestras.Find(idEspecificacionDeMuestra);
                 Area area = ctx.Areas.Find(idArea);
                Muestra nuevaMuestra = especificacion.CrearMuestraDeSuperficie(identificacionDeMuestra, 
                                                                                horarioDeMuestra,
                                                                                enContactoConProducto, 
                                                                                esRepeticion,
                                                                                area);
                ctx.Muestras.Add(nuevaMuestra);
                ctx.SaveChanges();
                return nuevaMuestra;
            }
        }

        public Muestra CrearNuevaOtraMuestra(int idEspecificacionDeMuestra, string identificacionDeMuestra, bool esRepeticion,  
                                             bool enContactoConProducto, int idArea) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                EspecificacionDeMuestra especificacon = ctx.EspecificacionesDeMuestras.Find(idEspecificacionDeMuestra);
                 Area area = ctx.Areas.Find(idArea);
                Muestra nuevaMuestra = especificacon.CrearOtraMuestra(identificacionDeMuestra, 
                                                                       esRepeticion,
                                                                       area,
                                                                       enContactoConProducto);
                ctx.Muestras.Add(nuevaMuestra);
                ctx.SaveChanges();
                return nuevaMuestra;
            }
        }

        public Muestra CrearNuevaMuestraOperario(int idEspecificacionDeMuestra, string identificacionDeMuestra, bool esRepeticion,
            EnumHorario horarioDeMuestra, int idOperario, string nombreOperario, int idArea) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                EspecificacionDeMuestra especificacion = ctx.EspecificacionesDeMuestras.Find(idEspecificacionDeMuestra);
                 Area area = ctx.Areas.Find(idArea);
                Muestra nuevaMuestra = especificacion.CrearMuestraDeOperario(identificacionDeMuestra,
                                                                                horarioDeMuestra, 
                                                                                idOperario, 
                                                                                nombreOperario,
                                                                                esRepeticion,
                                                                                area);
                ctx.Muestras.Add(nuevaMuestra);
                ctx.SaveChanges();
                return nuevaMuestra;
            }
        }

        public Muestra ActualizarMuestra(Muestra muestra) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                EnumClaseMuestra clase = muestra.EspecificacionDeMuestra.ClaseDeMuestra;
                Muestra muestraBD = ctx.Muestras.Find(muestra.MuestraId);
                // Datos de Muestra
                if(muestraBD.EspecificacionDeMuestra.EspecificacionDeMuestraId != muestra.EspecificacionDeMuestra.EspecificacionDeMuestraId) {
                    muestraBD.EspecificacionDeMuestra = ctx.EspecificacionesDeMuestras.Find(muestra.EspecificacionDeMuestra.EspecificacionDeMuestraId);
                }
                if(muestraBD.Area.AreaId != muestra.Area.AreaId) {
                    muestraBD.Area = ctx.Areas.Find(muestra.Area.AreaId);
                }
                muestraBD.EsRepeticion = muestra.EsRepeticion;
                muestraBD.IdentificacionDeMuestra = muestra.IdentificacionDeMuestra;
                // Datos por Clase
                switch(clase) {
                    case EnumClaseMuestra.Producto:
                        Producto producto = muestraBD as Producto;
                        producto.FechaDeProduccion = (muestra as Producto).FechaDeProduccion;
                        producto.FechaDeFaena = (muestra as Producto).FechaDeFaena;
                        producto.LoteDeProducto = (muestra as Producto).LoteDeProducto;
                        break;

                    case EnumClaseMuestra.Superficie:
                        Superficie superficie = muestraBD as Superficie;
                        superficie.HorarioDeMuestra = (muestra as Superficie).HorarioDeMuestra;
                        superficie.EnContactoConProducto = (muestra as Superficie).EnContactoConProducto;
                        break;

                    case EnumClaseMuestra.Ambiente:
                        Ambiente ambiente = muestraBD as Ambiente;
                        ambiente.HorarioDeMuestra = (muestra as Ambiente).HorarioDeMuestra;
                        break;

                    case EnumClaseMuestra.Operario:
                        Operario operario = muestraBD as Operario;
                        operario.HorarioDeMuestra = (muestra as Operario).HorarioDeMuestra;
                        operario.PadronDeOperario = (muestra as Operario).PadronDeOperario;
                        operario.NombreDeOperario = (muestra as Operario).NombreDeOperario;
                        break;

                    default:
                        Otra otra = muestraBD as Otra;
                        otra.EnContactoConProducto = (muestra as Otra).EnContactoConProducto;
                        break;
                }
                ctx.SaveChanges();
                return muestraBD;
            }
        }

        public IEnumerable<Muestra> ListarMuestras() {
            using(FrigLabContext ctx = new FrigLabContext()) {
                return ctx.Muestras
                    .Include("EspecificacionDeMuestra")
                    .Include("Muestreo")
                	.Include("Area")
                    .ToList();
            }
        }

        #endregion
    }
}
