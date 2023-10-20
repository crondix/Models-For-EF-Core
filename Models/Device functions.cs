using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    /// <summary>
    /// Класс описывает Функции устройства, например: копир, принтер, сканер
    /// </summary>
    public class Device_functions
    {
        public int id { get; set; }
        public string function { get; set; }
    }
}
