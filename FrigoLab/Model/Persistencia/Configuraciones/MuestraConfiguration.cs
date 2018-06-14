/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 08:57 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;

namespace FrigLab.Model.Persistencia.Configuraciones {
	/// <summary>
	/// Description of MuestraConfiguration.
	/// </summary>
	public class MuestraConfiguration:EntityTypeConfiguration<Muestra> {
		public MuestraConfiguration() {
			ToTable("Muestras");

            HasOptional<Muestreo>(muestra => muestra.Muestreo)
                .WithOptionalDependent(muestreo => muestreo.Muestra);

            HasRequired<EspecificacionDeMuestra>(m => m.EspecificacionDeMuestra)
                .WithMany(m => m.MuestrasDeEspecifcacionDeMuestra)
                .HasForeignKey(m => m.EspecificacionDeMuestraId);
            
			HasRequired<Area>(m => m.Area)
            	.WithMany(a => a.Muestras)
            	.HasForeignKey(m => m.AreaId);
			
			Property(m => m.IdentificacionDeMuestra).IsRequired().HasMaxLength(100);
		}
	}
}
