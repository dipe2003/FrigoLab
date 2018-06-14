/*
 * Created by SharpDevelop.
 * User: dperez
 * Date: 08/03/2018
 * Time: 09:24 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Usuarios;

namespace FrigLab.Model.Persistencia.Configuraciones {
    /// <summary>
    /// Description of UsuarioConfiguration.
    /// </summary>
    public class UsuarioConfiguration:EntityTypeConfiguration<Usuario> {
        public UsuarioConfiguration() {
            ToTable("Usuarios");
            HasKey(u => u.UsuarioId)
                .Property(u => u.UsuarioId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired<Credencial>(u => u.Credencial)
                .WithRequiredPrincipal(c => c.Usuario);

            HasMany<Muestreo>(u => u.MuestreosTomados)
                .WithRequired(m => m.Usuario)
                .HasForeignKey(m => m.UsuarioId);

            HasMany<Analisis>(u => u.AnalisisRealizados)
                .WithOptional(a => a.UsuarioAnalista)
                .HasForeignKey(a => a.UsuarioAnalistaId);

            HasMany<Analisis>(u => u.AnalisisVerificados)
                .WithOptional(a => a.UsuarioVerificador)
                .HasForeignKey(a => a.UsuarioVerificadorId);

            Property(u => u.NombreDeUsuario).IsRequired().HasMaxLength(100);
            Property(u => u.ApellidoDeUsuario).IsRequired().HasMaxLength(100);
            Ignore(u => u.NombreCompleto);
        }
    }
}
