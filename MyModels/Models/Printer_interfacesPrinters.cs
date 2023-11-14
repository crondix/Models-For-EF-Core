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
        [JsonIgnore]
        public int Printer_Interfacesid { get; set; }
        public virtual Printer_Interfaces? Printer_Interfaces { get; set; }
        [JsonIgnore]
        public int Printersid { get; set; }
        [JsonIgnore]
        public virtual Printers? Printers { get; set; }
    }
}
