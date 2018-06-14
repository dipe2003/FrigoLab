using FrigLab.Model.Dominio.Clases.Ensayos;
using FrigLab.Model.Dominio.Clases.Muestras;
using FrigLab.Model.Dominio.Clases.Muestreos;
using FrigLab.Model.Dominio.Clases.Requisitos;
using FrigLab.Model.Dominio.Clases.Usuarios;
using FrigLab.Model.Persistencia.Configuraciones;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigLab.Model.Persistencia {
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FrigLabContext:DbContext {

		public FrigLabContext():base("mySQLFrigLabConnection") {
			//this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FrigLabContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<FrigLabContext>());
        }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            modelBuilder.Configurations.Add<Area>(new AreaConfiguration());
            modelBuilder.Configurations.Add<Ensayo>(new EnsayoConfiguration());
            modelBuilder.Configurations.Add<Laboratorio>(new LaboratorioConfiguration());
            modelBuilder.Configurations.Add<Analisis>(new AnalisisConfiguration());
            modelBuilder.Configurations.Add<EspecificacionDeMuestra>(new EspecificacionesMuestrasConfiguration());
			modelBuilder.Configurations.Add<Muestra>(new MuestraConfiguration());
            modelBuilder.Configurations.Add<Operario>(new MuestraOperarioConfiguration());
            modelBuilder.Configurations.Add<Ambiente>(new MuestraAmbienteConfiguration());
            modelBuilder.Configurations.Add<Superficie>(new MuestraSuperficieConfiguration());
            modelBuilder.Configurations.Add<Producto>(new MuestraProductoConfiguration());
            modelBuilder.Configurations.Add<Otra>(new MuestraOtraConfiguration());
            modelBuilder.Configurations.Add<Muestreo>(new MuestreoConfiguration());
            modelBuilder.Configurations.Add<Requisito>(new RequisitoConfiguration());
            modelBuilder.Configurations.Add<Limite>(new LimiteConfiguration());			
			modelBuilder.Configurations.Add<Usuario>(new UsuarioConfiguration());
			modelBuilder.Configurations.Add<Credencial>(new CredencialConfiguration());
            modelBuilder.Configurations.Add<Resultado>(new ResultadoConfiguration());

            modelBuilder.Properties()
            .Where(x => x.PropertyType == typeof(bool))
            .Configure(x => x.HasColumnType("bit"));

        }

		public DbSet<Area> Areas { get; set; }
		public DbSet<EspecificacionDeMuestra> EspecificacionesDeMuestras { get; set; }
		public DbSet<Muestra> Muestras { get; set; }
		public DbSet<Muestreo> Muestreos { get; set; }
		public DbSet<Individual> MuestreosIndividuales { get; set; }
		public DbSet<Pool> PoolesMuestreos { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Ensayo> Ensayos { get; set; }
        public DbSet<Analisis> Analisis { get; set; } 
        public DbSet<Requisito> Requisitos { get; set; }
		public DbSet<Limite> Limites { get; set; }
		public DbSet<Laboratorio> Laboratorios { get; set; }
        public DbSet<Resultado> Resultados { get; set; }

    }
}
