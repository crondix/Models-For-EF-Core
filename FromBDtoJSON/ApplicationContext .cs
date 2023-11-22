
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyModels.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FromBDtoJSON
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
          
            Database.EnsureCreated();   // создаем бд с новой схемой
        }
        public DbSet<Speeds> Printing_Speed { get; set; }
        public DbSet<Measurement_units> Measurement_units { get; set; }
        public DbSet<Paper_sizes> Paper_sizes { get; set; }
        public DbSet<Print_colors> Print_colors { get; set; }
        public DbSet<Printer_types> Printer_types { get; set; }
        public DbSet<Printing_technologies> Printing_technologies { get; set; }
        public DbSet<Device_functions> Device_functions { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Printer_Interfaces> Printer_Interfaces { get; set; }
        public DbSet<Max_monthly_print_volumes> Max_monthly_print_volumes { get; set; }
        public DbSet<Cartridge_models> Cartridge_models { get; set; }
        public DbSet<Printers> Printers { get; set; }
        public DbSet<Scanner_type> Scanner_type { get; set; }
        public DbSet<Resolution> Scanner_resolution { get; set; }
        public DbSet<Scanner> Scanner { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=PrinterDB;",
            //    new MySqlServerVersion(new Version(8, 0, 25)));
            //  логгирование SQL-запросов
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PrintersDB;Trusted_Connection=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        // Используем рефлексию для автоматического добавления DbSet для всех моделей
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Printer_InterfacesPrinters>().HasKey(u => new { u.Printersid, u.Printer_Interfacesid });
            modelBuilder.Entity<Device_functionsPrinters>().HasKey(u => new { u.Printersid, u.Device_functionsid });
            modelBuilder.Entity<Cartridge_modelsPrinters>().HasKey(u => new { u.Printersid, u.Cartridge_modelsid });
            //var entityTypes = Assembly.GetExecutingAssembly().GetTypes()
            //    .Where(t => t.Namespace == "Models_For_EF_Core.Models" && t.IsClass);

            //foreach (var entityType in entityTypes)
            //{
            //    modelBuilder.Entity(entityType);
            //}

        }

    }
}
