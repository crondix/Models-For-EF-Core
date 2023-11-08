using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Models_For_EF_Core
{
    public class NavigationPropertyConverter<T> : JsonConverter<T> where T : class
    {
        private readonly ApplicationContext _context;

        public NavigationPropertyConverter(ApplicationContext context)
        {
            _context = context;
        }
        public NavigationPropertyConverter()
        {
         
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                JObject jObject = JObject.Load(reader);
                return GetNavigationProperty(jObject);
            }
            else if (reader.TokenType == JsonToken.Integer)
            {
                // Обработка целых чисел
                int id = Convert.ToInt32(reader.Value);
                return GetObjectById(id);
            }

            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            // Здесь можно реализовать сериализацию навигационного свойства обратно в JSON, если необходимо
            throw new NotImplementedException("Serialization is not supported in this converter.");
        }

        private T GetNavigationProperty(JObject jObject)
        {
            if (jObject.TryGetValue(typeof(T).Name, out JToken propertyValue) && propertyValue is JValue jValue)
            {
                int id = jValue.Value<int>();
                return GetObjectById(id);
            }

            return null;
        }
        private T GetObjectById(int id)
        {
            PropertyInfo idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null)
            {
                return _context.Set<T>().FirstOrDefault(e => (int)idProperty.GetValue(e) == id);
            }

            return null;
        }
    }
}
