using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    /// <summary>
    /// Класс описывает тип принтера например лазерный,с труйный и т.д.
    /// </summary>
    [Index(nameof(type), IsUnique = true)]
    public class Printer_types
    {
        public int Id { get; set; }
        [Required]
        public string type { get; set; } 
     
    }
}
