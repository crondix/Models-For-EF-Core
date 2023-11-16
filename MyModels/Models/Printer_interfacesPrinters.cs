using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    public class Printer_InterfacesPrinters
    {
         
        public int Printer_Interfacesid { get; set; }
        public virtual Printer_Interfaces? Printer_Interfaces { get; set; }
         
        public int Printersid { get; set; }
         
        public virtual Printers? Printers { get; set; }
    }
}
