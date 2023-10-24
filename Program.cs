// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Models_For_EF_Core;
using Models_For_EF_Core.Models;
using Newtonsoft.Json;

ApplicationContext db = new ApplicationContext();

// Чтение JSON файла
var json = File.ReadAllText($"../../../start_data.json");
Start_data models = JsonConvert.DeserializeObject<Start_data>(json);
// Десериализация JSON в объекты
//var paperSizes = JsonConvert.DeserializeObject<List<Paper_sizes>>(json); // Замените на вашу модель

    // Добавление данных в базу данных
    db.AddRange(models.Print_colors); // Замените на ваш DbSet
    db.SaveChanges();

Console.WriteLine("Start DB");