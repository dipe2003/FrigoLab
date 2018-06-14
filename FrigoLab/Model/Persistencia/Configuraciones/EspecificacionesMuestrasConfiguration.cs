/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 08:48 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Muestras;

namespace FrigLab.Model.Persistencia.Configuraciones {
	/// <summary>
	/// Description of EspecificacionesMuestrasConfiguration.
	/// </summary>
	public class EspecificacionesMuestrasConfiguration:EntityTypeConfiguration<EspecificacionDeMuestra> {
		public EspecificacionesMuestrasConfiguration() {
			ToTable("EspecificacionesMuestras");

            HasMany<Area>(esp => esp.Areas)
                 .WithMany(a => a.EspecificacionesDeMuestras);

            HasMany<Muestra>(esp => esp.MuestrasDeEspecifcacionDeMuestra)
                .WithRequired(m => m.EspecificacionDeMuestra)
                .HasForeignKey(m => m.EspecificacionDeMuestraId);

			Property(e => e.NombreDeEspecificacionDeMuestra).IsRequired().HasMaxLength(100);
		}
	}
}
