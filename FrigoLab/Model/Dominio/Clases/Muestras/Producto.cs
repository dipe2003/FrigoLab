/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 23/02/2018
 * Time: 02:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace FrigLab.Model.Dominio.Clases.Muestras {
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto: Muestra{
		public DateTime FechaDeFaena { get; set; }
		public DateTime FechaDeProduccion { get; set; }
		public string LoteDeProducto { get; set; }
		
		public Producto() {
		}
	}
}
