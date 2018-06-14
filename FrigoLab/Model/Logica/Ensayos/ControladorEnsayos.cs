/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 06/03/2018
 * Time: 12:41 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Ensayos;
using FrigLab.Model.Dominio.Enumeraciones.Requisitos;
using FrigLab.Model.Logica.Persistencia;
using FrigLab.Model.Persistencia;
using System.Linq;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;

namespace miniLabMuestreo.Model.Logica.Ensayos {
    /// <summary>
    /// Description of ManejadorEnsayos.
    /// </summary>
    public class ControladorEnsayos {

        public ControladorEnsayos() { }

        #region Laboratorio
        public Laboratorio CrearNuevoLaboratorio(string nombreDeLaboratorio, EnumTipoLaboratorio tipoDeLaboratorio) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Laboratorio nuevoLaboratorio = new Laboratorio {
                    NombreDeLaboratorio = nombreDeLaboratorio,
                    TipoDeLaboratorio = tipoDeLaboratorio
                };
                ctx.Laboratorios.Add(nuevoLaboratorio);
                ctx.SaveChanges();
                return nuevoLaboratorio;
            }
        }

        public Laboratorio EditarLaboratorio(int idLaboratorio, EnumTipoLaboratorio tipoLaboratorio, string nombreLaboratorio) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                IEnumerable<Laboratorio> laboratorios = ctx.Laboratorios
                    .Where(l => l.NombreDeLaboratorio == nombreLaboratorio)
                    .Where(l => l.LaboratorioId != idLaboratorio);

                if(laboratorios.Any()) {
                    return null;
                }

                Laboratorio laboratorio = ctx.Laboratorios.Find(idLaboratorio);
                laboratorio.NombreDeLaboratorio = nombreLaboratorio;
                laboratorio.TipoDeLaboratorio = tipoLaboratorio;
                ctx.SaveChanges();
                return laboratorio;
            }
        }

        public IEnumerable<Laboratorio> ListarLaboratorios() {
            using(FrigLabContext ctx = new FrigLabContext()) {
                return ctx.Laboratorios
                	.Include("AnalisisRealizados")
                	.ToList();
            }
        }
        
        public bool EliminarLaboratorio(int idLaboratorio){
        	using(FrigLabContext ctx = new FrigLabContext()) {
				Laboratorio laboratorio = ctx.Laboratorios.Find(idLaboratorio);
				
				if(laboratorio.AnalisisRealizados.Any()){
					return false;
				}
				
				ctx.Laboratorios.Remove(laboratorio);
				ctx.SaveChanges();
				return true;
            }
        }
        #endregion

        #region Ensayos

        public Ensayo CrearNuevoEnsayo(string nombreDeEnsayo, string metodoDeEnsayo, 
            EnumTipoAnalisis tipoAnalisis, EnumClaseMuestra claseMuestra) {
            using(FrigLabContext ctx = new FrigLabContext()) {
				IEnumerable<Ensayo> especificaciones = ctx.Ensayos
        			.Where(es => es.NombreDeEnsayo == nombreDeEnsayo)
        			.Where(es => es.MetodoDeEnsayo == metodoDeEnsayo)
                    .Where(es => es.ClaseDeMuestra == claseMuestra)
        			.ToList();
				
				if(especificaciones.Any()){
					return null;
				}
				
                Ensayo nuevaEspecificacion = new Ensayo {
                    NombreDeEnsayo = nombreDeEnsayo,
                    MetodoDeEnsayo = metodoDeEnsayo,
                    TipoDeAnalisis = tipoAnalisis,
                    ClaseDeMuestra = claseMuestra
                };
				
                ctx.Ensayos.Add(nuevaEspecificacion);
                ctx.SaveChanges();
                return nuevaEspecificacion;
            }
        }

        public Ensayo EditarEnsayo(int idDeEnsayo, string nombreDeEnsayo, string metodoDeEnsayo, 
            EnumTipoAnalisis tipoAnalisis, EnumClaseMuestra claseMuestra) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                IEnumerable<Ensayo> ensayos = ctx.Ensayos
                    .Where(e => e.NombreDeEnsayo == nombreDeEnsayo)
                    .Where(e => e.MetodoDeEnsayo == metodoDeEnsayo)
                    .Where(e => e.ClaseDeMuestra == claseMuestra)
                    .Where(e => e.EnsayoId != idDeEnsayo);

                if(ensayos.Any()) {
                    return null;
                }

                Ensayo ensayo = ctx.Ensayos.Find(idDeEnsayo);
                ensayo.NombreDeEnsayo = nombreDeEnsayo;
                ensayo.MetodoDeEnsayo = metodoDeEnsayo;
                ensayo.TipoDeAnalisis = tipoAnalisis;
                ensayo.ClaseDeMuestra = claseMuestra;
                ctx.SaveChanges();
                return ensayo;
            }
        }

        public IEnumerable<Ensayo> ListarEnsayos() {
            using(FrigLabContext ctx = new FrigLabContext()) {
        		return ctx.Ensayos
                    .Include("LimitesDeEnsayo.Requisito")
        			.Include("AnalisisDelEnsayo")
                    .ToList();
            }
        }
        
        public bool ElminarEnsayo(int idDeEnsayo){
        	using(FrigLabContext ctx = new FrigLabContext()) {
				Ensayo especificacion = ctx.Ensayos
                    .Include("AnalisisDelEnsayo")
                    .Single(esp=>esp.EnsayoId == idDeEnsayo);

				if(especificacion.AnalisisDelEnsayo.Any()){
				   	return false;
				   }

				ctx.Ensayos.Remove(especificacion);
				ctx.SaveChanges();
				return true;
            }
        }
        #endregion
       
        #region	Analisis

        public Analisis CrearNuevoAnalisis(int idDeEnsayo, int idDeMuestreo, EnumMotivoAnalisis origenDeAnalisis, int idDeLaboratorio) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Ensayo ensayo = ctx.Ensayos.Find(idDeEnsayo);
                Muestreo muestreo = ctx.Muestreos.Find(idDeMuestreo);
                Laboratorio laboratorio = ctx.Laboratorios.Find(idDeLaboratorio);
                Analisis analisisNuevo = ensayo.CrearAnalisis(laboratorio, muestreo, origenDeAnalisis);
                ctx.Analisis.Add(analisisNuevo);
                ctx.SaveChanges();
                return analisisNuevo;
            }
        }

        public Analisis ActualizarAnalisis(int idAnalisis, EnumMotivoAnalisis origenDeAnalisis, int idDeLaboratorio) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Analisis analisis = ctx.Analisis.Find(idAnalisis);

                analisis.OrigenDeAnalisis = origenDeAnalisis;

                if(analisis.Laboratorio.LaboratorioId != idDeLaboratorio) {
                    Laboratorio laboratorio = ctx.Laboratorios.Find(idDeLaboratorio);
                    analisis.Laboratorio = laboratorio;
                }

                ctx.SaveChanges();
                return analisis;
            }
        }

        public IEnumerable<Analisis> ListarAnalisis() {
            using(FrigLabContext ctx = new FrigLabContext()) {
                return ctx.Analisis.Include("Resultado").ToList();
            }
        }
        
        public bool EliminarAnalisis(int idEnsayo, int idAnalisis){
        	using(FrigLabContext ctx = new FrigLabContext()) {
                Analisis analisis = ctx.Analisis.Find(idAnalisis);
                try {
                    ctx.Analisis.Remove(analisis);
                    ctx.SaveChanges();
                    return true;
                } catch(Exception ex) {}
            }
            return false;
        }
        
        #endregion

        #region Resultados
        public Resultado CrearNuevoResultadoRecuento(int idAnalisis, int idUsuarioAnalista, string observacionesResultado,
            DateTime fechaDeAnalisis, DateTime fechaDeResultado, float recuento) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Analisis analisis = ctx.Analisis.Find(idAnalisis);
                Usuario usuarioAnalista = ctx.Usuarios.Find(idUsuarioAnalista);
                Resultado nuevoResultado = analisis.CrearResultadoRecuento(
                                          observacionesResultado,
                                          fechaDeAnalisis,
                                          recuento,
                                          usuarioAnalista,
                                          fechaDeResultado
                                      );
                ctx.Resultados.Add(nuevoResultado);
                ctx.SaveChanges();
                return nuevoResultado;
            }
        }
        
           public Resultado CrearNuevoResultadoDeteccion(int idAnalisis, int idUsuarioAnalista, string observacionesResultado,
            DateTime fechaDeAnalisis, DateTime fechaDeResultado, EnumValorDeteccion valorDeteccion) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Analisis analisis = ctx.Analisis.Find(idAnalisis);
                Usuario usuarioAnalista = ctx.Usuarios.Find(idUsuarioAnalista);
                Resultado nuevoResultado = analisis.CrearResultadoDeteccion(
                                          observacionesResultado,
                                          fechaDeAnalisis,
                                          valorDeteccion,
                                          usuarioAnalista,
                                          fechaDeResultado
                                      );
                ctx.Resultados.Add(nuevoResultado);
                ctx.SaveChanges();
                return nuevoResultado;
            }
        }


        public Resultado ObtenerResultadoDeAnalisis(int idAnalisis) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Analisis analisis = ctx.Analisis.Include("Resultado").Single(a => a.AnalisisId == idAnalisis);
                return analisis.Resultado;
            }
        }

        public IEnumerable<Resultado> ListarResultados() {
            using(FrigLabContext ctx = new FrigLabContext()) {
                return ctx.Resultados.ToList();
            }
        }

        public bool EliminarResultado(int idAnalisis) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Analisis analisis = ctx.Analisis.Find(idAnalisis);
                Resultado resultado = analisis.Resultado;
                if(analisis.EliminarResultado()) {
                    ctx.Resultados.Remove(resultado);
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        
        public void VerificarResultado(int idAnalisis, int idUsuario){
        	using(FrigLabContext ctx = new FrigLabContext()) {
                Analisis analisis = ctx.Analisis.Find(idAnalisis);
				Usuario verificador = ctx.Usuarios.Find(idUsuario);
                DateTime hoy = new DateTime();
                hoy = DateTime.Today;
				verificador.VerificarAnalisis(analisis, hoy);
				ctx.SaveChanges();
            }
        }
        #endregion
    }
}
