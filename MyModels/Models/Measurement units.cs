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
    /// Класс описывает единицы измерения  
    /// </summary>
    [Index(nameof(units), IsUnique = true)]
    public class Measurement_units
    {
         
        public int id { get; set; }

        /// <summary>
        /// Единицы измерения  
        /// </summary>
        [MaxLength(20)]
        public string units { get; set; }
        public override string ToString() => units;
    }
}
