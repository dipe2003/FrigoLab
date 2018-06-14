/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 08:54 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Ensayos;

namespace FrigLab.Model.Persistencia.Configuraciones {
	/// <summary>
	/// Description of ResultadoConfiguration.
	/// </summary>
	public class ResultadoConfiguration:EntityTypeConfiguration<Resultado> {
		public ResultadoConfiguration() {
			ToTable("Resultados");
			
			Property(r => r.FechaDeResultado).IsRequired();
            Property(p => p.AnalisisId).IsRequired();
		}
		
	}
}
