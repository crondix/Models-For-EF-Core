using MyModels.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models

{
    /// <summary>
    /// Оптическое разрешение сканера
    /// </summary>
    public class Scanner_resolution
    {
        public int id { get; set; }
        public ushort width { get; set; }
        public ushort height { get; set; }
        public int unitsid { get; set; }
        public virtual Measurement_units? units { get; set; }


    }
}
