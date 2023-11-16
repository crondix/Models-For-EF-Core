
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models
{
    /// <summary>
    /// Класс описывает свойства модели принтер
    /// </summary>
    public class Printers
    {
        public int Id { get; set; }
        public string? image { get; set; }
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
        public virtual Companies? Company_name { get; set; }
        /// <summary>
        /// Возможность цветной печати
        /// </summary>       
        public bool СolorPrinting { get; set; }


        /// <summary>
        /// Скорость черно-белой печати  
        /// </summary>
 
        public int BWPrintingSpeedid { get; set; }
        public virtual Speeds? BWPrintingSpeed { get; set; }
        /// <summary>
        /// Скорость цветной печати  
        /// </summary>

        public int ColorPrintingSpeedid { get; set; }
        public virtual Speeds? ColorPrintingSpeed { get; set; }


        /// <summary>
        /// Максимальный формат печати  
        /// </summary>
  
        public int MaxPrintFormatid { get; set; }
        public virtual Paper_sizes? MaxPrintFormat { get; set; }

        [Required]
   
        public int Typesid { get; set; }
        public virtual Printer_types? Types { get; set; }
        [Required]
 
        public int Technologisid { get; set; }
        public virtual Printing_technologies? Technologis { get; set; }
        [Required]
  
        public int MaxMonthlyPrintVolumesid { get; set; }
        public virtual Max_monthly_print_volumes? MaxMonthlyPrintVolumes { get; set; }
        //[Required]
        // 
        //public int Scanerid { get; set; }
        //public virtual Scanner? Scanner { get; set; }
      

        public virtual ICollection<Device_functionsPrinters> DeviceFunctions { get; set; }

        public virtual ICollection<Cartridge_modelsPrinters> CartridgeModels { get; set; }

        public virtual ICollection<Printer_InterfacesPrinters> PrinterInterfaces { get; set; }


    }
}
