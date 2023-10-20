using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core.Models
{
    //to do: подумать кажется это должно уйти в основной класс в bool
    /// <summary>
    /// Класс описывает цвет печати принтера: цветной ,чб, и т.д.
    /// </summary>

    public class Printing_color_types
    {
        public int id {  get; set; }
        public string type { get; set; }
    }
}
