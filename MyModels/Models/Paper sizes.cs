using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    /// <summary>
    /// Класс описывает форматы бумаги A4, A3 и т.д.
    /// </summary>
    [Index(nameof(paper_size), IsUnique = true)]
    public class Paper_sizes
    {


        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string paper_size { get; set; }
        public ushort width { get; set; }
        public ushort height { get; set; }
     
        public int unitsid { get; set; }
        public virtual Measurement_units? units { get; set; }
        public override string ToString() => paper_size;
    }
}
