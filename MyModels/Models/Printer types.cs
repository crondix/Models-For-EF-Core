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
     
         
        public int id { get; set; }
        [MaxLength(40)]
        public string type { get; set; }
        public override string ToString() => type;

    }
}
