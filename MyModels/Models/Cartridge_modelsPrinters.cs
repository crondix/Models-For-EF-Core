using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    public class Cartridge_modelsPrinters
    {
        [JsonIgnore]
        public int Cartridge_modelsid { get; set; }
        public virtual Cartridge_models? Cartridge_Models { get; set; }
        [JsonIgnore]
        public int Printersid { get; set; }
        [JsonIgnore]
        public virtual Printers? Printers { get; set; }
    }
}
