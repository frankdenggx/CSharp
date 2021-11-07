using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using static Org.Hotel1802.Dgx;

namespace Org.Hotel1802
{
    class Calc
    {
        private static Calc calc = new Calc();
        private Calc() 
        {
        }
        public static Calc getInstance()
        {
            return calc;
        }

        ~Calc()
        {
            System.Console.WriteLine("析构函数被调用");
        }
        
        InnerTest.StaticData staticData = new InnerTest.StaticData();
        
        public void output()
        {
            Console.WriteLine($"staticData={staticData.getInterval()}");
        }
    }
}
