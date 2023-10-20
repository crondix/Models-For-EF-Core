using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    /// <summary>
    /// Класс описывает форматы бумаги A4, A3 и т.д.
    /// </summary>
    internal class Paper_sizes
    {
       
        public int id {  get; set; }
        public string paper_size { get; set; }
    }
}
