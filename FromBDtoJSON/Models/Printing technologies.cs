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
    /// Класс описывает технологии печати н.р: струйная
    /// </summary>
    [Index(nameof(technology), IsUnique = true)]
    public class Printing_technologies
    {
        public Printing_technologies()
        {

        }
        public Printing_technologies(int value)
        {
            id = value;
        }
        public static implicit operator Printing_technologies(int value)
        {
            return new Printing_technologies(value);
        }
        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string technology { get; set; }
    }
}
