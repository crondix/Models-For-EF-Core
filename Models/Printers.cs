using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    /// <summary>
    /// Класс описывает свойства модели принтер
    /// </summary>
    public class Printers
    {
        public int Id { get; set; }
        /// <summary>
        /// Имеет ли принтер: систему непрерывной подачи чернил 
        /// </summary>
        public bool CISS { get; set; }
        /// <summary>
        /// Имеет ли принтер: Автоматическую двухстороннюю печать 
        /// </summary>
        public bool AutomaticDoubleSidedPrinting { get; set; }
        /// <summary>
        /// Название модели принтера
        /// </summary>
        [Required]
        [MaxLength(40)]
        public string ModelName { get; set; } 
        /// <summary>
        /// Название модели принтера
        /// </summary>
        [Required]
        public int Company_nameid { get; set; }
        public Companies? Company_name { get; set; } 
        /// <summary>
        /// Возможность цветной печати
        /// </summary>
        public bool СolorPrinting { get; set; }
        /// <summary>
        /// Имеется ли автоподатчик бумаги у сканера 
        /// </summary>
        public bool AutomaticFeedDeviceForScan { get; set; }

        /// <summary>
        /// Скорость черно-белой печати  
        /// </summary>
        [JsonConverter(typeof(NavigationPropertyConverter<Printing_Speed>))]
        public Printing_Speed BWPrintingSpeed {  get; set; }
        /// <summary>
        /// Скорость цветной печати  
        /// </summary>
        [JsonConverter(typeof(NavigationPropertyConverter<Printing_Speed>))]
        public Printing_Speed ColorPrintingSpeed { get; set; }
        /// <summary>
        /// Максимальный формат сканирования   
        /// </summary>
        [JsonConverter(typeof(NavigationPropertyConverter<Paper_sizes>))]
        public Paper_sizes MaxScanFormat { get; set; }
        /// <summary>
        /// Максимальный формат печати  
        /// </summary>
        [JsonConverter(typeof(NavigationPropertyConverter<Paper_sizes>))]
        public Paper_sizes MaxPrintFormat { get; set; }

        [Required]
        [JsonConverter(typeof(NavigationPropertyConverter<Printer_types>))]
        public Printer_types Types { get; set; }
        [Required]
        [JsonConverter(typeof(NavigationPropertyConverter<Printing_technologies>))]
        public Printing_technologies Technologis { get; set; }
        [Required]
        [JsonConverter(typeof(NavigationPropertyConverter<Max_monthly_print_volumes>))]
        public Max_monthly_print_volumes MaxMonthlyPrintVolumes { get; set; }
        [Required]
        [JsonConverter(typeof(NavigationPropertyConverter<Device_functions>))]
        public ICollection<Device_functions> DeviceFunctions { get; set; }
        [JsonConverter(typeof(NavigationPropertyConverter<Cartridge_models>))]
        public ICollection<Cartridge_models> CartridgeModels { get; set; }
        [JsonConverter(typeof(NavigationPropertyConverter<Printer_Interfaces>))]
        public ICollection<Printer_Interfaces> PrinterInterfaces { get; set; } 
   
        
    }
}
