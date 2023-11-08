using Microsoft.EntityFrameworkCore;
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
    public class IntToObjectArrayConverter<T> : JsonConverter<T[]> where T : class
    {
        public override T[] ReadJson(JsonReader reader, Type objectType, T[] existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartArray)
            {
                List<T> result = new List<T>();

                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                {
                    if (reader.TokenType == JsonToken.Integer)
                    {
                        int intValue = Convert.ToInt32(reader.Value);

                        // Создайте объект T на основе intValue
                        T item = CreateObjectFromInt(intValue);

                        if (item != null)
                        {
                            result.Add(item);
                        }
                    }
                }

                return result.ToArray();
            }

            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, T[] value, JsonSerializer serializer)
        {
            // Здесь можно реализовать логику преобразования массива объектов T обратно в int при сериализации
            // Но это зависит от ваших потребностей
            throw new NotImplementedException("Serialization is not supported in this converter.");
        }

        private T CreateObjectFromInt(int value)
        {
            // Здесь реализуйте логику создания объекта T на основе value
            // В этом методе определите, какой класс должен быть создан для данного value
            // Например, можно использовать switch для выбора нужного класса.
            // Здесь приведен пример создания Printing_Speed:
            var entityTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == "Models_For_EF_Core.Models" && t.IsClass);

            foreach (var entityType in entityTypes)
            {
                if (typeof(T) == entityType)
                {
                    // Создание экземпляра объекта типа T с передачей аргумента value
                    var instance = Activator.CreateInstance(entityType, value);

                    // Приведение созданного объекта к типу T
                    return (T)instance;
                }
            }

            // Добавьте другие логики для других классов, если необходимо
            throw new InvalidOperationException($"Conversion from int to {typeof(T).Name} is not supported.");
        }
    }
}
