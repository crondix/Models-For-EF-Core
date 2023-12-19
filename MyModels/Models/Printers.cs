
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;

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
        /// Возможность цветной печати
        /// </summary>       
        public bool СolorPrinting { get; set; }
        [Required]
        public int Company_nameid { get; set; }
        public virtual Companies? Company_name { get; set; }
        /// <summary>
        /// Максимальное разрешение черно-белой печати 
        /// </summary>
        public int MaxPrintResolutionBWid { get; set; } 
        /// <summary>
        /// Максимальное разрешение черно-белой печати 
        /// </summary>
        public virtual Resolution? MaxPrintResolutionBW { get; set; }
        /// <summary>
        /// Максимальное разрешение цветной печати 
        /// </summary>
        public int MaxPrintResolutionColorid { get; set; }
        /// <summary>
        /// Максимальное разрешение цветной печати 
        /// </summary>
        public virtual Resolution? MaxPrintResolutionColor { get; set; }


        /// <summary>
        /// Скорость черно-белой печати  
        /// </summary>
        public ushort BWPrintingSpeed { get; set; }
        /// <summary>
        /// Скорость цветной печати  
        /// </summary>
        public ushort? ColorPrintingSpeed { get; set; }

        public int? SpeedUnitsid { get; set; }
        public virtual Measurement_units? SpeedUnits { get; set; }


        /// <summary>
        /// Максимальный формат печати  
        /// </summary>
        public int? MaxPrintFormatid { get; set; }
        public virtual Paper_sizes? MaxPrintFormat { get; set; }

      

        public int? Typesid { get; set; }
        public virtual Printer_types? Types { get; set; }
      
 
        public int? Technologisid { get; set; }
        public virtual Printing_technologies? Technologis { get; set; }
    
  
        public int? MaxMonthlyPrintVolumes { get; set; }
        //public virtual Max_monthly_print_volumes? MaxMonthlyPrintVolumes { get; set; }
        public int? RecommendedMonthlyPrintVolumes { get; set; }

        public int? MonthlyPrintVolumesUnitsid { get; set; }
        
        public virtual Measurement_units? MonthlyPrintVolumesUnits { get; set; }

        public int? Scanerid { get; set; }
        public virtual Scanner? Scanner { get; set; }


        public virtual ICollection<Device_functionsPrinters> DeviceFunctions { get; set; }

        public virtual ICollection<Cartridge_modelsPrinters> CartridgeModels { get; set; }

        public virtual ICollection<Printer_InterfacesPrinters> PrinterInterfaces { get; set; }



        public Printers Clone()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping(); // Импорт расширения для глубокого клонирования
                cfg.CreateMap<Printers, Printers>();
                cfg.CreateMap<Resolution, Resolution>();
                cfg.CreateMap<Companies, Companies>();
                cfg.CreateMap<Measurement_units, Measurement_units>();
                cfg.CreateMap<Paper_sizes, Paper_sizes>();
                cfg.CreateMap<Printer_types, Printer_types>();
                cfg.CreateMap<Printing_technologies, Printing_technologies>();
                cfg.CreateMap<Scanner, Scanner>();
                cfg.CreateMap<Device_functionsPrinters, Device_functionsPrinters>();
                cfg.CreateMap<Cartridge_modelsPrinters, Cartridge_modelsPrinters>();
                cfg.CreateMap<Printer_InterfacesPrinters, Printer_InterfacesPrinters>();

                // Добавьте дополнительные настройки для вложенных объектов, если необходимо
            });

            IMapper mapper = configuration.CreateMapper();
            return mapper.Map<Printers>(this);
        }




    }
}
