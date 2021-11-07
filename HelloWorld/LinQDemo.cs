using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
namespace Org.Hotel1802
{
    class LinQDemo
    {
        public static void testLinQ()
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            IEnumerable<int> lowNums = from n in numbers
                                      where n < 8
                                      select n;
            foreach (var item in lowNums)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
