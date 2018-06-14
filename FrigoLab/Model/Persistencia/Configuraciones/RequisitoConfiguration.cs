/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 09:21 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Requisitos;

namespace FrigLab.Model.Persistencia.Configuraciones {
    /// <summary>
    /// Description of RequisitoConfiguration.
    /// </summary>
    public class RequisitoConfiguration:EntityTypeConfiguration<Requisito> {
        public RequisitoConfiguration() {
            ToTable("Requisitos");

            HasMany<Limite>(r => r.LimitesDelRequisito)
                .WithRequired(l => l.Requisito)
                .HasForeignKey(l => l.RequisitoId)
                .WillCascadeOnDelete(false);

            Property(r => r.NombreDeRequisito).IsRequired();
        }
    }
}
