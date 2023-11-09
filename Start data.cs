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
        //Важно соблюдать порядок, инициализации таблиц данными!!!!
        //Неверный порядок добавления информации в таблицы ведет к ошибкам:
        //EF core пытается добавить запись в таблицу, которая ссылается на внешний ключь записи другой таблицы, которого(внешнего ключа) еще не существет
        public List<Measurement_units> Measurement_units { get; set; } = new List<Measurement_units>();
        public List<Paper_sizes> Paper_sizes { get; set; }= new List<Paper_sizes>();
        public List<Print_colors> Print_colors { get; set; } = new List<Print_colors>();
        public List<Printer_types> Printer_types { get; set; } = new List<Printer_types>();     
        public List<Printing_technologies> Printing_technologies { get; set; } = new List<Printing_technologies>();
        public List<Device_functions> Device_functions { get; set; } = new List<Device_functions>();
        public List<Companies> Companies { get; set; } = new List<Companies>();
        public List<Printer_Interfaces> Printer_Interfaces { get; set; } = new List<Printer_Interfaces>();
        public List<Printing_Speed> Printing_Speed { get; set; } = new List<Printing_Speed>();
        public List<Max_monthly_print_volumes> Max_monthly_print_volumes { get; set; } = new List<Max_monthly_print_volumes>();
        public List<Cartridge_models> Cartridge_models { get; set; } = new List<Cartridge_models>();
        //public List<Printers> Printers { get; set; } = new List<Printers>();
       
    }
}
