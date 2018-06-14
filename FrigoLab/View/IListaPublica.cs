/*
 * Creado por SharpDevelop.
 * Usuario: dperez
 * Fecha: 26/03/2018
 * Hora: 02:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace FrigLab.View {
	/// <summary>
	/// Description of IListaPublica.
	/// </summary>
	public interface IListaPublica<T> where T: class {
		void AddEntidad(T entidad);
		
		void RemoveEntidad(T entidad);
	}
}
	
