using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models_For_EF_Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureDeleted();   // удаляем бд со старой схемой
            Database.EnsureCreated();   // создаем бд с новой схемой
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=PrinterDB;",
                new MySqlServerVersion(new Version(8, 0, 25)));
            //  логгирование SQL-запросов
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PrintersDB;Trusted_Connection=True;");
        }
      
        // Используем рефлексию для автоматического добавления DbSet для всех моделей
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            var entityTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == "Models_For_EF_Core.Models" && t.IsClass);

            foreach (var entityType in entityTypes)
            {
                modelBuilder.Entity(entityType);
            }
       
        }
    }
}
