using MauiAppCrud.Modelos;
using MauiAppCrud.Utilidades;
using Microsoft.EntityFrameworkCore;


namespace MauiAppCrud.DataAcces
{
    public class EmpleadoDbContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDb = $"Filename={ConexionDb.DevolverRuta("empleados.db")}";
            optionsBuilder.UseSqlite(conexionDb);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(col => col.IdEmpleado);
                entity.Property(col => col.IdEmpleado).IsRequired().ValueGeneratedOnAdd();
            });

        }

    }
}
