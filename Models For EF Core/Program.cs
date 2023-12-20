// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Models_For_EF_Core;

using System.Collections;
using System.Reflection;
//using Newtonsoft.Json;
using System.Text.Json;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Extensions.Logging;
using System.Runtime.Intrinsics.X86;
using MyModels.Models;

//ApplicationContext db = new ApplicationContext();
using (var db = new ApplicationContext())
{
    // Чтение JSON файла
    string json = File.ReadAllText($"../../../start_data.json");
    Start_data models = JsonConvert.DeserializeObject<Start_data>(json);

    Type startDataType = typeof(Start_data);
    PropertyInfo[] properties = startDataType.GetProperties();
    //Start_data models = JsonSerializer.Deserialize<Start_data>(json);
    //Type startDataType = typeof(Start_data);
    //PropertyInfo[] properties = startDataType.GetProperties();

    var loggerFactory = LoggerFactory.Create(builder =>
    {
        builder.AddConsole(); // Логгирование в консоль
    });
   
    var logger = loggerFactory.CreateLogger<Program>();


    // Переберите свойства и добавьте их в db.AddRange
    foreach (PropertyInfo property in properties)
    {
        if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
        {
            // Если свойство является списком, добавьте его содержимое в db.AddRange
            var propertyValue = (IEnumerable)property.GetValue(models);
            if (propertyValue != null)
            {
                foreach (var item in propertyValue)
                {
                    if (propertyValue != typeof(Measurement_units))
                    {
                        db.AddRange(item);// в этой строке просто в дбшку добавляется, (синтакси EF Core)
                    }
                }
                try
                {
                    // Ваш код сохранения изменений в базе данных
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    // Обработка ошибки
                    Console.WriteLine($"Ошибка сохранения изменений: {ex.Message}");

                    // Вывод внутреннего исключения, чтобы увидеть дополнительные детали
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"Внутреннее исключение: {ex.InnerException.Message}");
                    }
                }
             
            }

        }

    }
  

    logger.LogInformation("Application started.");
    Console.WriteLine("Start DB");
 
   
    //var converter = new FromBDtoJSON(db);
    //converter.ExportDataToJson("C:\\Users\\Dudarev.Aleksey\\Documents\\json\\output.json");
 
}