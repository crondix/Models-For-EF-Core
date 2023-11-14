using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    //Почему отдельная таблица? Существуют модели принтеров одной линейки отличающиеся именованием, и некоторыми функиями, но имеющие одинаковую скорость печати  
    [Index(nameof(speed), IsUnique = true)]
    public class Printing_Speed
    {
        public Printing_Speed()
        {

        }
        public Printing_Speed(int value)
        {
            id = value;
        }
        public static implicit operator Printing_Speed(int value)
        {
            return new Printing_Speed(value);
        }
        [JsonIgnore]
        public int id { get; set; }
        public ushort speed { get; set; }
        [JsonIgnore]
        public int unitsid { get; set; }
        public virtual Measurement_units? units { get; set; }
    }
}
