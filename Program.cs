// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Models_For_EF_Core;
using Models_For_EF_Core.Models;
using System.Collections;
using System.Reflection;
//using Newtonsoft.Json;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

ApplicationContext db = new ApplicationContext();

// Чтение JSON файла
 string json = File.ReadAllText($"../../../start_data.json");

Start_data models = JsonSerializer.Deserialize<Start_data>(json);
Type startDataType = typeof(Start_data);
PropertyInfo[] properties = startDataType.GetProperties();


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
            db.AddRange(item);// в этой строке просто в дбшку добавляется, синтакси EF Core
        }
    }
}
db.SaveChanges();

Console.WriteLine("Start DB");