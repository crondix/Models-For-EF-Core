using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{ /// <summary>
  /// Тип сканера
  /// </summary>
    public class Scanner_type
    {
         
        public int id { get; set; }
        [MaxLength(40)]
        public string type { get; set; }
    }
}
