using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Hotel1802
{
    interface ICup
    {
        void Refill();

        void Wash();


        int Color { get; set; }
        int Volumn { get; set; }
    }
}
