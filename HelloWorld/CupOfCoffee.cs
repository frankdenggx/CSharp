using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Hotel1802
{
    class CupOfCoffee : HotDrink, ICup
    {
        public int Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Volumn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Refill()
        {
            throw new NotImplementedException();
        }

        public void Wash()
        {
            throw new NotImplementedException();
        }

        public override void AddMilk()
        {
            throw new NotImplementedException();
        }

        public override void AddSugar()
        {
            throw new NotImplementedException();
        }

        public override void Drink()
        {
            throw new NotImplementedException();
        }

        public int BeanType { get; set; }
    }
}
