using Models_For_EF_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core
{
    public class Start_data
    { 
        public List<Paper_sizes> Paper_sizes { get; set; }= new List<Paper_sizes>();
        public List<Print_colors> Print_colors { get; set; } = new List<Print_colors>();
        public List<Printer_types> Printer_types { get; set; } = new List<Printer_types>();
        public List<Measurement_units> Measurement_units { get; set; } = new List<Measurement_units>();
        public List<Printing_technologies> Printing_technologies { get; set; } = new List<Printing_technologies>();
        public List<Device_functions> Device_functions { get; set; } = new List<Device_functions>();
        public List<Companies> Companies { get; set; } = new List<Companies>();
        public List<Printer_Interfaces> Printer_Interfaces { get; set; } = new List<Printer_Interfaces>();
       
    }
}
