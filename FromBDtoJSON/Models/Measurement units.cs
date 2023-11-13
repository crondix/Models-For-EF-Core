using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromBDtoJSON.Models
{
    [Index(nameof(units), IsUnique = true)]
    public class Measurement_units
    {
        public int id { get; set; }
        [MaxLength(20)]
        public string units { get; set; }
    }
}
