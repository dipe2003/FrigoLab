/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 09:17 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Requisitos;

namespace FrigLab.Model.Persistencia.Configuraciones {
	/// <summary>
	/// Description of LimiteConfiguration.
	/// </summary>
	public class LimiteConfiguration:EntityTypeConfiguration<Limite> {
		public LimiteConfiguration() {
			ToTable("Limites");

            HasRequired<Requisito>(l => l.Requisito)
                .WithMany(r => r.LimitesDelRequisito)
                .HasForeignKey(l => l.RequisitoId);

            HasRequired<Ensayo>(l => l.Ensayo)
                .WithMany(e => e.LimitesDeEnsayo)
                .HasForeignKey(l => l.EnsayoId);

		}
	}
}
