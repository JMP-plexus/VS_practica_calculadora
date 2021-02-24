using System;
using System.Collections.Generic;
using System.Linq;
using CochesCutresEntity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace CochesCutresEntity.Models
{
    public class ConcesionarioContext : DbContext
    {

        public ConcesionarioContext() : base("ConcesionarioContext")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Coche> Coches { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Compraventa> Compraventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}