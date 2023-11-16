using Microsoft.EntityFrameworkCore;
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
    /// Под максимальным месячным объемом печати понимается рекомендованное количество отпечатков, которое вы сможете выполнить с помощью принтера в течение месяца. 
    /// (Превышение объема приведет к сокращению срока службы устройства.)
    /// </summary
    [Index(nameof(volume), IsUnique = true)]
    public class Max_monthly_print_volumes
    {
        public Max_monthly_print_volumes()
        {

        }
        public Max_monthly_print_volumes(int value)
        {
            id = value;
        }
        public static implicit operator Max_monthly_print_volumes(int value)
        {
            return new Max_monthly_print_volumes(value);
        }
         
        public int id { get; set; }
        public ushort volume { get; set; }
         
        public int unitsid { get; set; }
        public virtual Measurement_units? units { get; set; }
    }
}
