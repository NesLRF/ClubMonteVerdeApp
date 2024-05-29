using ClubMonteVerde.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMonteVerde.Repository.Entrada
{
    public class EntradaContext : DbContext
    {
        public DbSet<Membresia> membresia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["MONTEVERDECONEXION"].ConnectionString;

                optionsBuilder.UseMySQL(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Membresia>()
                .HasOne(m => m.Titular) // Relación: Membresia tiene un titular
                .WithMany()
                .HasForeignKey(m => m.socio_titular_id); // Clave foránea

            modelBuilder.Entity<Membresia>()
                .HasMany(m => m.Pases)
                .WithOne(p => p.Membresia)
                .HasForeignKey(p => p.membresia_id);

            modelBuilder.Entity<Membresia>()
                .HasMany(m => m.Familiares)
                .WithOne(f => f.Membresia)
                .HasForeignKey(f => f.membresia_id);


            modelBuilder.Entity<Socio>()
                .HasOne(s => s.Membresia)
                .WithMany()
                .HasForeignKey(s => s.id);

            modelBuilder.Entity<Socio>()
                .HasMany(m => m.Pases)
                .WithOne()
                .HasForeignKey(p => p.socio_id);

            modelBuilder.Entity<Socio>()
                .HasOne(s => s.Estatus)
                .WithMany()
                .HasForeignKey(s => s.estatus_id);
        }

    }
}
