﻿using Microsoft.EntityFrameworkCore;
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
    /// Класс описывает цвета кратриджей
    /// </summary>
    [Index(nameof(color), IsUnique = true)]
    public class Print_colors
    {
         
        public int Print_colorsid { get; set; }
        [Required]
        [MaxLength(20)]
        public string color { get; set; }
         
        //public virtual ICollection<Cartridge_models> Cartridge_models { get; set; }

    }
}
