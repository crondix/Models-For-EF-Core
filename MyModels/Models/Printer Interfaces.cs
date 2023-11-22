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
    [Index(nameof(InterfaceName), IsUnique = true)]
    public class Printer_Interfaces
    {
        public Printer_Interfaces()
        {

        }
        public Printer_Interfaces(int value)
        {
            id = value;
        }
        public static implicit operator Printer_Interfaces(int value)
        {
            return new Printer_Interfaces(value);
        }
        public override string ToString() => InterfaceName;
        public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string InterfaceName { get; set; }
        [Required]
         
        public virtual ICollection<Printer_InterfacesPrinters> Printers { get; set; }
    }
}
