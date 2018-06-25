using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using FrigLab.Model.Dominio.Enumeraciones.Muestreos;
using FrigLab.Model.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using miniLabMuestreo.Model.Logica.Ensayos;

namespace FrigLab.Model.Logica.Muestreos {
	public class ControladorMuestreos {
		
		private ControladorEnsayos cEnsayos = new ControladorEnsayos();

		public ControladorMuestreos() { }

		#region Muestreo.Individual

		public List<Muestreo> CrearNuevoMuestreoIndividual(int idDeUsuarioMonitor, DateTime fechaDeHoraMuestreo,
		                                                   string observacionesDeMuestreo, EnumAlmacenamientoMuestreo almacenamientoDeMuestreo, EnumTipoMuestreo tipoDeMuestreo,
		                                                   int numeroDeMuestreo) {
			using(FrigLabContext ctx = new FrigLabContext()) {
				Usuario usuario = ctx.Usuarios.Find(idDeUsuarioMonitor);
				List<Muestreo> muestreos = new List<Muestreo>();
				for(int i = 0; i < numeroDeMuestreo; i++) {
					Muestreo muestreo = usuario.CrearMuestreoIndividual(fechaDeHoraMuestreo, observacionesDeMuestreo, i + 1,
					                                                    almacenamientoDeMuestreo, tipoDeMuestreo);
					ctx.Muestreos.Add(muestreo);
					muestreos.Add(muestreo);
				}
				ctx.SaveChanges();
				return muestreos;
			}
		}
		
		public bool EliminarMuestreo(int idMuestreo){
			using (FrigLabContext ctx = new FrigLabContext()) {
				Muestreo muestreo = ctx.Muestreos.Find(idMuestreo);
				for (int i = 0; i < muestreo.AnalisisDelMuestreo.Count; i++) {
					Analisis analisis = muestreo.AnalisisDelMuestreo.ElementAt(i);
					analisis.Ensayo.EliminarAnalisis(analisis);
					i--;
					ctx.Analisis.Remove(analisis);
				}
				try {
					ctx.Muestras.Remove(muestreo.Muestra);
					ctx.Muestreos.Remove(muestreo);
					ctx.SaveChanges();
					return true;
				} catch (Exception) {}
				return false;
			}
		}

		#endregion


		#region	Muestreo

		public int ActualizarMuestreoIndividual(int idMuestreo, DateTime fechaDeHoraMuestreo, string observacionesDeMuestreo,
		                                        EnumAlmacenamientoMuestreo almacenamientoDeMuestreo, int numeroDeMuestreo) {
			using(FrigLabContext ctx = new FrigLabContext()) {
				Individual muestreo = ctx.Muestreos.Find(idMuestreo) as Individual;
				muestreo.FechaHoraDeMuestreo = fechaDeHoraMuestreo;
				muestreo.ObservacionesDeMuestreo = observacionesDeMuestreo;
				muestreo.AlmacenamientoDeMuestreo = almacenamientoDeMuestreo;
				muestreo.NumeroDeMuestreo = numeroDeMuestreo;

				return ctx.SaveChanges();
			}
		}


		public IEnumerable<Muestreo> ListarMuestreosIndividuales() {
			using(FrigLabContext ctx = new FrigLabContext()) {
				return ctx.MuestreosIndividuales
					.Include("Muestra.Area.EspecificacionesDeMuestras")
					.Include("AnalisisDelMuestreo.Ensayo.LimitesDeEnsayo.Requisito")
					.Include("AnalisisDelMuestreo.Resultado")
					.Include("AnalisisDelMuestreo.Laboratorio")
					.Include("AnalisisDelMuestreo.UsuarioAnalista")
					.Include("Muestra.EspecificacionDeMuestra")
					.Include("Usuario")
                    .Include("Pool")
					.ToList();
			}
		}
		
		public IEnumerable<Muestreo> ListarPoolesDeMuestreos() {
			using(FrigLabContext ctx = new FrigLabContext()) {
				return ctx.PoolesMuestreos
					.Include("MuestreosDePool.Muestra.Area.EspecificacionesDeMuestras")
					.Include("AnalisisDelMuestreo.Ensayo.LimitesDeEnsayo.Requisito")
					.Include("AnalisisDelMuestreo.Resultado")
					.Include("AnalisisDelMuestreo.Laboratorio")
					.Include("AnalisisDelMuestreo.UsuarioAnalista")
					.Include("Muestra.EspecificacionDeMuestra")
					.Include("Usuario")
					.ToList();
			}
		}
		
		public Muestreo ObtenerMuestreoIndividual(int idMuestreo){
			using(FrigLabContext ctx = new FrigLabContext()) {
				return ctx.MuestreosIndividuales
					.Include("Muestra.Area.EspecificacionesDeMuestras")
					.Include("Muestra.EspecificacionDeMuestra")
					.Include("AnalisisDelMuestreo.Ensayo.LimitesDeEnsayo.Requisito")
					.Include("AnalisisDelMuestreo.Resultado")
					.Include("AnalisisDelMuestreo.Laboratorio")
					.Include("AnalisisDelMuestreo.UsuarioVerificador")
					.Include("AnalisisDelMuestreo.UsuarioAnalista")
					.Include("Usuario")
					.Include("Pool")
					.Single(m=>m.MuestreoId == idMuestreo);
			}
		}

		public void AgregarMuestra(int idMuestra, int idMuestreo) {
			using(FrigLabContext ctx = new FrigLabContext()) {
				Muestreo muestreo = ctx.Muestreos.Find(idMuestreo);
				Muestra muestra = ctx.Muestras.Find(idMuestra);
				muestreo.Muestra = muestra;
				ctx.SaveChanges();
			}
		}
		#endregion
	}
}
