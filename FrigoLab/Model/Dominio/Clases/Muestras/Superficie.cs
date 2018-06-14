/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 24/02/2018
 * Time: 10:15 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using System;

namespace FrigLab.Model.Dominio.Clases.Muestras {
	/// <summary>
	/// Description of Superficie.
	/// </summary>
	public class Superficie:Muestra {
		public EnumHorario HorarioDeMuestra { get; set; }

		public bool EnContactoConProducto { get; set; }

		public Superficie() {
		}
	}
}
