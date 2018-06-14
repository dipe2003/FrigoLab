using FrigLab.Model.Dominio.Clases.Muestras;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Persistencia.Configuraciones {
    class MuestraSuperficieConfiguration : EntityTypeConfiguration<Superficie>{
        public MuestraSuperficieConfiguration() {
            ToTable("MuestrasSuperficie");

            Property(p => p.EnContactoConProducto).IsRequired();
            Property(p => p.HorarioDeMuestra).IsRequired();
        }
    }
}
