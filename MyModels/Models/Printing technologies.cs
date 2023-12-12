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
    /// Класс описывает технологии печати н.р: струйная
    /// </summary>
    [Index(nameof(technology), IsUnique = true)]
    public class Printing_technologies
    {
     
         
        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string technology { get; set; }
        public override string ToString() => technology;
    }
}
