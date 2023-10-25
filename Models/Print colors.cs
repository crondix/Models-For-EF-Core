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
    /// Класс описывает цвета кратриджей
    /// </summary>
    [Index(nameof(color), IsUnique = true)]
    public class Print_colors
    {
        
        public ushort Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string color { get; set; } 
    }
}
