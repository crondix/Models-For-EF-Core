using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    /// <summary>
    /// Под максимальным месячным объемом печати понимается рекомендованное количество отпечатков, которое вы сможете выполнить с помощью принтера в течение месяца. 
    /// (Превышение объема приведет к сокращению срока службы устройства.)
    /// </summary
    [Index(nameof(volume), IsUnique = true)]
    public class Max_monthly_print_volumes
    {
        public int id { get; set; }
        [Required]
        public ushort volume { get; set; }
    }
}
