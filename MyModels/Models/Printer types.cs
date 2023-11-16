using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    /// <summary>
    /// Класс описывает тип принтера например лазерный,струйный и т.д.
    /// </summary>
    [Index(nameof(type), IsUnique = true)]
    public class Printer_types
    {
        public Printer_types()
        {

        }
        public Printer_types(int value)
        {
            id = value;
        }
        public static implicit operator Printer_types(int value)
        {
            return new Printer_types(value);
        }
         
        public int id { get; set; }
        [MaxLength(40)]
        public string type { get; set; }

    }
}
