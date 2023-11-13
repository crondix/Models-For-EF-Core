using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FromBDtoJSON.Models
{
    /// <summary>
    /// Класс описывает свойства модели картриджа
    /// </summary>
    [Index(nameof(Model), IsUnique = true)]
    public class Cartridge_models
    {
        public Cartridge_models()
        {

        }
        public Cartridge_models(int value)
        {
            id = value;
        }
        public static implicit operator Cartridge_models(int value)
        {
            return new Cartridge_models(value);
        }
        public int id { get; set; }
        [MaxLength(100)]
        public string Model { get; set; }
        public ushort? PrintResource { get; set; }
        public bool? Refueling { get; set; }
        public int Print_colorsid { get; set; }
        public virtual Print_colors? Print_colors { get; set; }
        public virtual ICollection<Cartridge_modelsPrinters> Printers { get; set; }
    }
}
