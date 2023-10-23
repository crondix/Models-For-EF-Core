using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    /// <summary>
    /// Класс описывает свойства модели принтер
    /// </summary>
    public class Printer
    {
        public int Id { get; set; }
        /// <summary>
        /// Имеет ли принтер: систему непрерывной подачи чернил 
        /// </summary>
        public bool CISS { get; set; }
        /// <summary>
        /// Имеет ли принтер: Автоматическую двухстороннюю печать 
        /// </summary>
        public bool automatic_double_sided_printing { get; set; }
        /// <summary>
        /// Название модели принтера
        /// </summary>
        public string model_name { get; set; } = "";
        /// <summary>
        /// Возможность цветной печати
        /// </summary>
        public bool сolor_printing { get; set; }
        public Printer_types types { get; set; }
        public Printing_technologies technologis { get; set; }
        
    }
}
