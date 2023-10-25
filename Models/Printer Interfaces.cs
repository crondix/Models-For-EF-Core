using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    [Index(nameof(InterfaceName), IsUnique = true)]
    public class Printer_Interfaces
    {
        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string InterfaceName { get; set; }
        [Required]
       public List<Printer> Printers { get; set;}
    }
}
