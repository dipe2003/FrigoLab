/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 16/05/2018
 * Hora: 01:24 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Collections.Generic;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Logica.Muestras;
using FrigLab.Model.Logica.Muestreos;
using FrigLab.Model.Persistencia;
using miniLabMuestreo.Model.Logica.Ensayos;

namespace FrigLab.Model.Logica.Muestreos
{
	/// <summary>
	/// Description of ControladorPooles.
	/// </summary>
	public class ControladorPooles{
		
		private ControladorMuestreos cMuestreos = new ControladorMuestreos();
		
		public ControladorPooles(){}
		#region Muestreo.Pool

		public Muestreo CrearNuevoPool(int idDeUsuarioMonitor, DateTime fechaHoraPool, string descripcionPool) {
			using(FrigLabContext ctx = new FrigLabContext()) {
				Usuario usuario = ctx.Usuarios.Find(idDeUsuarioMonitor);
				Muestreo pool = usuario.CrearPool(descripcionPool, fechaHoraPool);
				ctx.Muestreos.Add(pool);
				ctx.SaveChanges();
				return pool;
			}
		}
		
		public int ActualizarPool(int idPool, DateTime fechaPool, string descripcionPool){
			using(FrigLabContext ctx = new FrigLabContext()) {
				Muestreo pool = ctx.PoolesMuestreos.Find(idPool);
				(pool as Pool).FechaCreacionDePool = fechaPool;
				(pool as Pool).DescripcionDePool = descripcionPool;
				ctx.SaveChanges();
				return pool.MuestreoId;
			}
		}
		
		public Muestreo ObtenerPool(int idPool){
			using(FrigLabContext ctx = new FrigLabContext()) {
				return ctx.PoolesMuestreos
					.Include("MuestreosDePool.AnalisisDelMuestreo.Ensayo")
					.Include("MuestreosDePool.Muestra.EspecificacionDeMuestra")
					.Include("MuestreosDePool.Muestra.Area")
					.Include("Usuario")
					.FirstOrDefault(m => m.MuestreoId == idPool);
			}
		}		

		public int AgregarMuestreosAPool(int idDePoolDeMuestreo, List<int> idDeMuestreoIndividual) {
			using(FrigLabContext ctx = new FrigLabContext()) {
				Pool pool = ctx.Muestreos.Find(idDePoolDeMuestreo) as Pool;
				List<Muestreo> muestreos = ctx.Muestreos.Where(m => idDeMuestreoIndividual.Contains(m.MuestreoId)).ToList();
				foreach (Muestreo muestreo in muestreos) {
					pool.AgregarMuestreo(muestreo);
				}
				return ctx.SaveChanges();
			}
		}

		public bool QuitarMuestreoDePool(int idDePoolDeMuestreo, int idDeMuestreoIndividual) {
			using(FrigLabContext ctx = new FrigLabContext()) {
				Pool pool = ctx.Muestreos.Find(idDePoolDeMuestreo) as Pool;
				Muestreo muestreo = ctx.Muestreos.Find(idDeMuestreoIndividual);
				pool.QuitarMuestreo(muestreo);
				ctx.SaveChanges();
				return true;
			}
		}

		public void EliminarPool(int idDePool) {
			using(FrigLabContext ctx = new FrigLabContext()) {
				Pool pool = ctx.PoolesMuestreos.Find(idDePool);
				ctx.PoolesMuestreos.Remove(pool);
				ctx.SaveChanges();
			}
		}

        public void MarcarPoolAbierto(int idPool) {
            using(FrigLabContext ctx = new FrigLabContext()) {
                Pool pool = ctx.PoolesMuestreos.Find(idPool);
                pool.FueAbierto = true;
                ctx.SaveChanges();
            }
        }
		#endregion
	}

}
