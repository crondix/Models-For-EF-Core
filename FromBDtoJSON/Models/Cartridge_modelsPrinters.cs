using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromBDtoJSON.Models
{
    public class Cartridge_modelsPrinters
    {
        public int Cartridge_modelsid { get; set; }
        public virtual Cartridge_models? Cartridge_Models { get; set; }
        public int Printersid { get; set; }
        public virtual Printers? Printers { get; set; }
    }
}
