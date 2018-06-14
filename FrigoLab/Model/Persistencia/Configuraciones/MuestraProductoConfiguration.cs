using FrigLab.Model.Dominio.Clases.Muestras;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Persistencia.Configuraciones {
    class MuestraProductoConfiguration: EntityTypeConfiguration<Producto> {
        public MuestraProductoConfiguration() {
            ToTable("MuestrasProducto");

            Property(p => p.FechaDeFaena).IsRequired();
            Property(p => p.FechaDeProduccion).IsRequired();
            Property(p => p.LoteDeProducto).IsOptional().HasMaxLength(30);
        }
    }
}
