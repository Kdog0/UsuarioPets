using Microsoft.EntityFrameworkCore;
using UsuariosPets.Contexts.Maps;
using UsuariosPets.Models;

namespace UsuariosPets.Contexts
{
    public class Context : DbContext
    {  
            public Context(DbContextOptions<Context> options):base(options) { }

            public DbSet<Pet> Pets { get; set; }

            public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PetMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
