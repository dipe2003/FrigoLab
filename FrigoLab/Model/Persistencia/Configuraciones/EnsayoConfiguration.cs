using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Requisitos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrigLab.Model.Persistencia.Configuraciones {
    class EnsayoConfiguration:EntityTypeConfiguration<Ensayo> {

        public EnsayoConfiguration() {
			ToTable("Ensayos");

			HasMany<Limite>(e => e.LimitesDeEnsayo)
				.WithRequired(l => l.Ensayo)
				.HasForeignKey(l => l.EnsayoId);

            Property(e => e.NombreDeEnsayo).IsRequired().HasMaxLength(100);
        }
    }
}
