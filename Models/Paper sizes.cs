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
    /// Класс описывает форматы бумаги A4, A3 и т.д.
    /// </summary>
    [Index(nameof(paper_size), IsUnique = true)]
    public class Paper_sizes 
    {
        public Paper_sizes()
        {

        }
        public Paper_sizes(int value)
        {
            this.id = value;
        }
        public static implicit operator Paper_sizes(int value)
        {
            return new Paper_sizes(value);
        }
        public int id {  get; set; }
        [Required]
        [MaxLength(40)]
        public string paper_size { get; set; } 
        public ushort width { get; set; } 
        public ushort height { get; set; } 
        public int unitsid { get; set; }
        public Measurement_units? units { get; set; }
        
    }
}
