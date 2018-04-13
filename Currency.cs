using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Currency
    {
        //This 2 arrays only used when buying platinum.
        public int[] Platinum = { 75, 170, 370, 1000, 2100, 4300 };
        /* 75 plat = 41kronor
         * 170 plat = 82kr
         * 370 plat = 164kr
         * 1000 plat = 410kr
         * 2100 plat = 820 kr
         * 4300 plat = 1640 kr
         */
        public int[] Money = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        
        
    }
}
