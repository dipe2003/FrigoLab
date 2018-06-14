using FrigLab.Model.Dominio.Clases.Muestras;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Persistencia.Configuraciones {
    class MuestraOperarioConfiguration: EntityTypeConfiguration<Operario> {
        public MuestraOperarioConfiguration() {
            ToTable("MuestrasOperario");

            Property(p => p.HorarioDeMuestra).IsRequired();
            Property(p => p.PadronDeOperario).IsRequired();
            Property(p => p.NombreDeOperario).IsRequired().HasMaxLength(100);
    }
    }
}
