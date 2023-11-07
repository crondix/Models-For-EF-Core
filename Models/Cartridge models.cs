using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    /// <summary>
    /// Класс описывает свойства модели картриджа
    /// </summary>
    [Index(nameof(Model), IsUnique = true)]
    public class Cartridge_models
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Model { get; set; } 
        public ushort? PrintResource {  get; set; }
        public bool? Refueling {  get; set; }
        public int Print_colorsId { get; set; }
        public Print_colors? Print_colors { get; set; }
        public ICollection<Printer> Printers { get; set; }
    }
}
