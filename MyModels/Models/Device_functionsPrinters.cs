﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    public class Device_functionsPrinters
    {
         
        public int Device_functionsid { get; set; }
        public virtual Device_functions? Device_functions { get; set; }
         
        public int Printersid { get; set; }
         
        public virtual Printers? Printers { get; set; }
    }
}
