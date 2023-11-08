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
        public Printer_Interfaces()
        {

        }
        public Printer_Interfaces(int value)
        {
            this.id = value;
        }
        public static implicit operator Printer_Interfaces(int value)
        {
            return new Printer_Interfaces(value);
        }
        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string InterfaceName { get; set; }
        [Required]
       public ICollection<Printers> Printers { get; set;}
    }
}
