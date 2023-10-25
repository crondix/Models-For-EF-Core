using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    public class Companies
    {

        public int Id { get; set; }
        public string name { get; set; }
        public List<Printer>? Printers { get; set; }
    }
}
