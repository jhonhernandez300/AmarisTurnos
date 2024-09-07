using Core.Modelos;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
                
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<TurnoHistorial> TurnoHistoriales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {                
                entity.HasKey(e => e.IdUsuario);  
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.HasKey(e => e.IdSucursal);
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasKey(e => e.IdTurno);
            });

            modelBuilder.Entity<TurnoHistorial>(entity =>
            {
                entity.HasKey(e => e.IdTurnoHistorial);
            });

            //modelBuilder.Entity<UserCompany>()
            //    .HasOne(uc => uc.User)
            //    .WithMany(u => u.UserCompanies)
            //    .HasForeignKey(uc => uc.IdUser);



            base.OnModelCreating(modelBuilder);
        }
    }
}
