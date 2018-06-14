/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 08:56 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Muestras;

namespace FrigLab.Model.Persistencia.Configuraciones {
	/// <summary>
	/// Description of AreaConfiguration.
	/// </summary>
	public class AreaConfiguration:EntityTypeConfiguration<Area> {
		public AreaConfiguration() {
			ToTable("Areas");

            HasMany<EspecificacionDeMuestra>(area => area.EspecificacionesDeMuestras)
                .WithMany(esp => esp.Areas);

            HasMany<Muestra>(a => a.Muestras)
                .WithRequired(m => m.Area)
                .HasForeignKey(m => m.AreaId);

			Property(a => a.NombreDeArea).IsRequired().HasMaxLength(100);
		}
	}
}
