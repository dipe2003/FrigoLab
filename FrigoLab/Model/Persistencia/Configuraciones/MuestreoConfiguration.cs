/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 09:01 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Usuarios;

namespace FrigLab.Model.Persistencia.Configuraciones {
	/// <summary>
	/// Description of MuestreoConfiguration.
	/// </summary>
	public class MuestreoConfiguration:EntityTypeConfiguration<Muestreo> {
		public MuestreoConfiguration() {
			ToTable("Muestreos");

            HasMany<Analisis>(m => m.AnalisisDelMuestreo)
                .WithRequired(a => a.Muestreo)
                .HasForeignKey(a => a.MuestreoId);

            HasOptional<Muestra>(muestreo => muestreo.Muestra)
                .WithOptionalPrincipal(muestra => muestra.Muestreo);

            HasRequired<Usuario>(m => m.Usuario)
                .WithMany(u => u.MuestreosTomados)
                .HasForeignKey(m => m.UsuarioId);
		}
	}
}
