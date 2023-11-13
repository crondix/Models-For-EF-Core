using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromBDtoJSON.Models
{
    /// <summary>
    /// Класс описывает Функции устройства, например: копир, принтер, сканер
    /// </summary>
    [Index(nameof(function), IsUnique = true)]
    public class Device_functions
    {

        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string function { get; set; }
        public virtual ICollection<Device_functionsPrinters> Printers { get; set; }
    }
}
