﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    public class Measurement_units
    {
        public int id {  get; set; }
        [MaxLength(20)]
        public string units { get; set; }
    }
}
