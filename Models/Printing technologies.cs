﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    /// <summary>
    /// Класс описывает технологии печати н.р: струйная
    /// </summary>
    [Index(nameof(technology), IsUnique = true)]
    public class Printing_technologies
    {
        public int id {  get; set; }
        [Required]
        public string technology { get; set; }
    }
}
