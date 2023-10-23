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
    public class Cartridge_models
    {
        public int Id { get; set; }
        [Required]
        public string Model { get; set; } = ""; 
        public int? PrintResource {  get; set; }
        public bool Refueling {  get; set; }
        [Required]
        public List<Print_colors> Print_colors { get; set; }= new List<Print_colors>();
    }
}
