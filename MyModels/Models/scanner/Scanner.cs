﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.Models

{
    /// <summary>
    /// Модуль сканера принтера
    /// </summary>
    public class Scanner
    {
        public int id { get; set; }
         
        public int Scanner_resolutionid { get; set; }
        public virtual Scanner_resolution? Scanner_resolution { get; set; }
         
        public int Scaner_Typeid { get; set; }
        public virtual Scanner_type? Scaner_Type { get; set; }
        /// <summary>
        /// Максимальный формат сканирования 
        /// </summary>
         
        public int Scan_Speedid { get; set; }
        /// <summary>
        /// Максимальный формат сканирования 
        /// </summary>
        public virtual Speeds? Scan_Speed { get; set; }
        /// <summary>
        /// Максимальный формат сканирования 
        /// </summary>
        public int MaxScanFormatid { get; set; }
        /// <summary>
        /// Максимальный формат сканирования 
        /// </summary>
        public virtual Paper_sizes? MaxScanFormat { get; set; }
        /// <summary>
        /// Имеется ли автоподатчик бумаги у сканера 
        /// </summary>
        public bool AutomaticFeedDeviceForScan { get; set; }
        /// <summary>
        /// двухстороннее устройство автоподачи Duplex Automatic Document Feeder
        /// </summary>

        public bool DADF { get; set; }

    }
}
