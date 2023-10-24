using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    [Index(nameof(speed), IsUnique = true)]
    public class Printing_Speed
    {
        
        public int id { get; set; }
        public ushort speed { get; set; }
    }
}
