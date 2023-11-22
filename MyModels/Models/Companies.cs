using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyModels.Models
{
    [Index(nameof(name), IsUnique = true)]
    /// <summary>
    /// Название компании производителя
    /// </summary>
    public class Companies
    {
         
        public int Id { get; set; }
        public string name { get; set; }



    }
}
