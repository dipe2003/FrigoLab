
using FrigLab.Model.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Logica.Persistencia {
	public class ManejadorPersistencia: IDisposable {

		private FrigLabContext ctx;
        
		public ManejadorPersistencia() {
			this.ctx = new FrigLabContext();        	
		}

		/// <summary>
		/// Crea la entidad de tipo T en la base de datos.
		/// </summary>
		/// <param name="entidad"></param>
		/// <returns>Retorna la entidad T si fue creada, de lo contrario retorna null.</returns>
		public T CrearEntidad<T>(T entidad) where T : class {
			try			{
				DbSet<T> dbSet = ctx.Set<T>();
				dbSet.Add(entidad);
				ctx.SaveChanges();
				return entidad;
			}catch (Exception ex){
				throw new Exception("Excepcion: " + ex.Message);
			}

		}

		/// <summary>
		/// Actualiza la entidad de tipo T en la base de datos.
		/// </summary>
		/// <param name="idEntidad"></param>
		/// <param name="entidad"></param>
		/// <returns>Retorna la entidad T si fue actualizada, de lo contrario retorna null.</returns>
		public T ActualizarEntidad<T>(int idEntidad, T entidad) where T: class {
			try
			{
				DbSet<T> dbSet = ctx.Set<T>();
				var variable = dbSet.Find(idEntidad);
				ctx.Entry(variable).CurrentValues.SetValues(entidad);
				ctx.SaveChanges();
				return entidad;
			}catch (Exception ex){
				throw new Exception("Excepcion: " + ex.Message);
			}

		}

		/// <summary>
		/// Elimina de la base de datos la entidad T.
		/// </summary>
		/// <param name="entidad"></param>
		/// <returns>Retorna True si se elimino, de lo contrario false.</returns>
		public bool EliminarEntidad<T>(T entidad) where T: class {
			try{
				DbSet<T> dbSet = ctx.Set<T>();
				dbSet.Remove(entidad);
				ctx.SaveChanges();
				return true;
			}catch (Exception){
				return false;
			}
		}

		/// <summary>
		/// Devuelve todas las entidades del tipo T.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<T> ObtenerTodos<T>() where T: class {
			IEnumerable<T> lista = new List<T>();
			try{
				DbSet<T> dbSet = ctx.Set<T>();
				lista = dbSet.ToList();
			}catch(Exception ex){
				throw new Exception("Excepcion: " + ex.Message);
			}
			return lista;
		}

		/// <summary>
		/// Devuelve la entidad de tipo T espcificada.
		/// </summary>
		/// <param name="idEntidad"></param>
		/// <returns></returns>
		public T ObtenerEntidad<T>(int idEntidad) where T: class {
			try{
                DbSet<T> dbSet = ctx.Set<T>();
				return dbSet.Find(idEntidad);
			}catch (Exception ex){
				throw new Exception("Excepcion: " + ex.Message);
			}
		}

		#region IDisposable implementation
		public void Dispose() {
			if(ctx!=null){
				ctx.Dispose();
			}
		
		}
		#endregion
	}
}
