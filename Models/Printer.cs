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
        public bool AutomaticDoubleSidedPrinting { get; set; }
        /// <summary>
        /// Название модели принтера
        /// </summary>
        [Required]
        public string ModelName { get; set; } 
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
        public Printing_Speed? BWPrintingSpeed {  get; set; }
        /// <summary>
        /// Скорость цветной печати  
        /// </summary>
        public Printing_Speed? ColorPrintingSpeed { get; set; }
        /// <summary>
        /// Максимальный формат сканирования   
        /// </summary>
        public Paper_sizes? MaxScanFormat { get; set; }
        /// <summary>
        /// Максимальный формат печати  
        /// </summary>
        public Paper_sizes? MaxPrintFormat { get; set; }

        [Required]
        public Printer_types Types { get; set; }
        [Required]
        public Printing_technologies Technologis { get; set; }
        [Required]
        public Max_monthly_print_volumes MaxMonthlyPrintVolumes { get; set; }
        [Required]
        public List<Device_functions> DeviceFunctions { get; set; }
        public List<Cartridge_models> CartridgeModels { get; set; }
        public List<Printer_Interfaces> PrinterInterfaces { get; set; } 
   
        
    }
}
