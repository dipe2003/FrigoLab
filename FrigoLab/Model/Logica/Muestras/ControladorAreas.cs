/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 14/03/2018
 * Hora: 10:49 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using FrigLab.Model.Dominio.Clases.Muestras;
using System.Linq;
using FrigLab.Model.Persistencia;

namespace FrigLab.Model.Logica.Muestras
{
	/// <summary>
	/// Description of ControladorAreas.
	/// </summary>
	public class ControladorAreas{
		
		public ControladorAreas(){}
		
		public Area CrearNuevaArea(string nombreDeArea){
			using (FrigLabContext ctx = new FrigLabContext()){
				IEnumerable<Area> areasRegistradas = ctx.Areas
					.Where(a => a.NombreDeArea == nombreDeArea);
				
				if (areasRegistradas.Any()){
					return null;
				}
				
				Area nuevaArea = new Area{
					NombreDeArea = nombreDeArea
				};
				
				ctx.Areas.Add(nuevaArea);
				ctx.SaveChanges();
				return nuevaArea;
			}
		}
		
		public Area EditarArea(int idDeArea, string nombreDeArea){
			using (FrigLabContext ctx = new FrigLabContext()){
				IEnumerable<Area> areasRegistradas = ctx.Areas
					.Where(a => a.NombreDeArea == nombreDeArea)
					.Where(a => a.AreaId != idDeArea);
				
				if (areasRegistradas.Any()){
					return null;
				}
				
				Area area = ctx.Areas.Find(idDeArea);
				area.NombreDeArea = nombreDeArea;
				ctx.SaveChanges();
				return area;
			}
		}
		
		public Area CambiarVigencia(int idDeArea, bool vigente){
			using (FrigLabContext ctx = new FrigLabContext()){
				Area area = ctx.Areas.Find(idDeArea);
				if (vigente){
					area.FechaNoVigente = null;
				} else {
					DateTime fecha = new DateTime();
					fecha = DateTime.Today;
					area.FechaNoVigente = fecha;
				}
				ctx.SaveChanges();
				return area;
			}
		}
		
		public bool EliminarArea(int idArea){
			using (FrigLabContext ctx = new FrigLabContext()){
				Area area = ctx.Areas.Find(idArea);
				if (area.EspecificacionesDeMuestras.Any()){
					return false;
				}
				ctx.Areas.Remove(area);
				ctx.SaveChanges();				
			}
			return true;
		}
		
		public Area ObtenerArea(int idArea){
			using (FrigLabContext ctx = new FrigLabContext()){
				return ctx.Areas.Find(idArea);
			}
		}
		
		public IEnumerable<Area> ListarAreas(bool incluirNoVigentes = true){
			using (FrigLabContext ctx = new FrigLabContext()){
				IEnumerable<Area> areasRegistradas = ctx.Areas
                    .Include("EspecificacionesDeMuestras.Areas")
                    .Include("Muestras")
                    .ToList();
				if (incluirNoVigentes){
					return areasRegistradas;
				}
				return areasRegistradas.Where(a => a.FechaNoVigente == null);
			}
		}
	}
}
