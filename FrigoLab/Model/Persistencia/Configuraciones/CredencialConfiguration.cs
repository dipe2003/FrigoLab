/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 09:50 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Usuarios;

namespace FrigLab.Model.Persistencia.Configuraciones {
    /// <summary>
    /// Description of CredencialConfiguration.
    /// </summary>
    public class CredencialConfiguration:EntityTypeConfiguration<Credencial> {
        public CredencialConfiguration() {
            ToTable("Credencial");
            HasKey(c => c.UsuarioId);
            Property(c => c.UsuarioId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
      
        }
    }
}
