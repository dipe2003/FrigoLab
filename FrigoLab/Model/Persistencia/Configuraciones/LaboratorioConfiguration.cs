/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 08:52 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Ensayos;

namespace FrigLab.Model.Persistencia.Configuraciones {
	/// <summary>
	/// Description of LaboratorioConfiguration.
	/// </summary>
	public class LaboratorioConfiguration:EntityTypeConfiguration<Laboratorio> {
		public LaboratorioConfiguration() {
			ToTable("Laboratorios");

            HasMany<Analisis>(l => l.AnalisisRealizados)
                .WithRequired(a => a.Laboratorio)
                .HasForeignKey(a => a.LaboratorioId);

			Property(l => l.NombreDeLaboratorio).IsRequired().HasMaxLength(100);
		}
	}
}
