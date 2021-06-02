using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using api.Models.Traffic;

namespace api.Models
{
    public class GlobalContext : DbContext
    {

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RutaBranch>()
                .HasKey(rb => new { rb.RutaId, rb.BranchId });
        }

        

        public GlobalContext(DbContextOptions options) : base (options) { }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Ruta> RutaBranch { get; set; }
        public DbSet<Valija> Valijas { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Gestion> Gestiones { get; set; }
        public DbSet<Extra> Extras { get; set; }
        

    }


}