using Models_For_EF_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_For_EF_Core
{
    public abstract class AbstractModel
    {
        public int id { get; set; }
        public AbstractModel()
        {

        }
        public AbstractModel(int value)
        {
            this.id = value;
        }
       
       


    }
}
