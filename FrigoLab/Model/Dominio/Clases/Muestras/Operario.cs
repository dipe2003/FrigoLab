/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 24/02/2018
 * Time: 10:15 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.ComponentModel.DataAnnotations;
using FrigLab.Model.Dominio.Enumeraciones.Muestras;
using System;

namespace FrigLab.Model.Dominio.Clases.Muestras {
	/// <summary>
	/// Description of Operario.
	/// </summary>
	public class Operario: Muestra {
		public int PadronDeOperario { get; set; }
		public string NombreDeOperario { get; set; }
		public EnumHorario HorarioDeMuestra { get; set; }
		
		public Operario() {
		}
	}
}
