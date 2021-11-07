using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Hotel1802
{
    abstract class HotDrink
    {
        public abstract void Drink();

        public abstract void AddMilk();

        public abstract void AddSugar();

        public int Milk { get; set; }

        public int Sugar { get; set; }
    }
}
