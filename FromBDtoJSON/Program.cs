// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using FromBDtoJSON;
using FromBDtoJSON.Models;
using System.Collections;
using System.Reflection;
//using Newtonsoft.Json;
using System.Text.Json;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Extensions.Logging;
using System.Runtime.Intrinsics.X86;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

//ApplicationContext db = new ApplicationContext();
using (var db = new ApplicationContext())
{
    //// Чтение JSON файла
    //string json = File.ReadAllText($"../../../start_data.json");
    //Start_data models = JsonConvert.DeserializeObject<Start_data>(json);

    //Type startDataType = typeof(Start_data);
    //PropertyInfo[] properties = startDataType.GetProperties();
    ////Start_data models = JsonSerializer.Deserialize<Start_data>(json);
    ////Type startDataType = typeof(Start_data);
    ////PropertyInfo[] properties = startDataType.GetProperties();

    //var loggerFactory = LoggerFactory.Create(builder =>
    //{
    //    builder.AddConsole(); // Логгирование в консоль
    //});

    //var logger = loggerFactory.CreateLogger<Program>();
    //// Переберите свойства и добавьте их в db.AddRange
    //foreach (PropertyInfo property in properties)
    //{
    //    if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
    //    {
    //        // Если свойство является списком, добавьте его содержимое в db.AddRange
    //        var propertyValue = (IEnumerable)property.GetValue(models);
    //        if (propertyValue != null)
    //        {
    //            foreach (var item in propertyValue)
    //                db.AddRange(item);// в этой строке просто в дбшку добавляется, (синтакси EF Core)
    //        }
    //    }
    //    db.SaveChanges();
    //}

    //logger.LogInformation("Application started.");
    //Console.WriteLine("Start DB");
    //var model = db.Printers.ToList();
    //var printer = db.Printers
    //    .Include(p => p.Company_name)
    //    .Include(p => p.BWPrintingSpeed)
    //    .Include(p => p.ColorPrintingSpeed)
    //    .Include(p => p.MaxScanFormat)
    //    .Include(p => p.MaxPrintFormat)
    //    .Include(p => p.Types)
    //    .Include(p => p.Technologis)
    //    .Include(p => p.MaxMonthlyPrintVolumes)
    //    .FirstOrDefault(p => p.Id == 1);     

   
  
    var printer = db.Printers.FirstOrDefault(p => p.Id == 1);
    if (printer != null)
    {
        Console.WriteLine("Technologis:" + printer.Printer_InterfacesPrinters.Count);
    }
    //File.WriteAllText("C:\\Users\\Dudarev.Aleksey\\Documents\\json\\output.json", JsonConvert.SerializeObject(printer));

    ////var converter = new FromBDtoJSON(db);
    ////converter.ExportDataToJson("C:\\Users\\Dudarev.Aleksey\\Documents\\json\\output.json");
    //Console.WriteLine("Должен был создаться JSON");
}