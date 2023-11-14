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
    /// Класс описывает Функции устройства, например: копир, принтер, сканер
    /// </summary>
    [Index(nameof(function), IsUnique = true)]
    public class Device_functions
    {
        [JsonIgnore]
        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string function { get; set; }
        [JsonIgnore]
        public virtual ICollection<Device_functionsPrinters> Printers { get; set; }
    }
}
