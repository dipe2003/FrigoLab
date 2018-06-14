using FrigLab.Model.Dominio.Clases.Ensayos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Dominio.Clases.Muestreos;

namespace FrigLab.Model.Persistencia.Configuraciones {
    public class AnalisisConfiguration:EntityTypeConfiguration<Analisis> {

        public AnalisisConfiguration() {
			ToTable("Analisis");
			
            HasRequired<Muestreo>(a => a.Muestreo)
                .WithMany(m => m.AnalisisDelMuestreo)
                .HasForeignKey(a => a.MuestreoId);

            HasOptional<Resultado>(a => a.Resultado)
                .WithRequired(r => r.Analisis)
                .WillCascadeOnDelete(true);

            HasRequired<Ensayo>(a => a.Ensayo)
                .WithMany(e => e.AnalisisDelEnsayo)
                .HasForeignKey(a => a.EnsayoId);

            HasRequired<Laboratorio>(a => a.Laboratorio)
                .WithMany(l => l.AnalisisRealizados)
                .HasForeignKey(a => a.LaboratorioId);

            HasOptional<Usuario>(a => a.UsuarioAnalista)
                .WithMany(u => u.AnalisisRealizados)
                .HasForeignKey(a => a.UsuarioAnalistaId);

            HasOptional<Usuario>(a => a.UsuarioVerificador)
                .WithMany(u => u.AnalisisVerificados)
                .HasForeignKey(a => a.UsuarioVerificadorId);

        }
    }
}
