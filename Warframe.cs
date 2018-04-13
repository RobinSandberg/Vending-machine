using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    abstract class Warframe
    {

        public string Name { get; set; }

        public int Price { get; set; }

        public string Info { get; set; }

        public string Use { get; set; }

        public abstract void Information();

        public abstract void Using();
    }
}
