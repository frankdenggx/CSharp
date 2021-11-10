
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

using Org.Hotel1802.InnerTest;

/*modified by yoyudeng*/

namespace Org.Hotel1802
{
    #region
    public enum YesNoEnum
    {
        [Description("是")]
        Yes,
        [Description("否")]
        No
    }
    #endregion

    public static class EnumUtil
    {

        #region FetchDescription

        public static string FetchDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }


        #endregion
    }

    namespace InnerTest
    {
        class StaticData
        {
            static int GLOBAL_TIME_INTERVAL = 100;

            public int getInterval()
            {
                return GLOBAL_TIME_INTERVAL;
            }
        }
    }
    class Helloworld
    {

        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }

        enum Orientation
        {
            NORTH, EAST, SOUTH, WEST
        }

        enum NewOrientation : long
        {
            NORTH = 10L,
            EAST = 11L,
            SOUTH = 12L,
            WEST = 13L

        }

        struct RouteN
        {
            public Orientation direction; // 方向
            public double distince; // 距离

            public string detail() => String.Concat("{direction=", direction.ToString(), ",distance=", distince, "}");
        }

        private Helloworld()
        {

        }

        public Helloworld(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public void DoDrink(HotDrink hotDrink)
        {
            hotDrink.AddMilk();
            hotDrink.AddSugar();
            hotDrink.Drink();
        }

        public void testGitPost(HotDrink hotDrink)
        {
            // git 测试
            hotDrink.Drink();
        }

        static void paramsMethod(string param1, params int[] unlimitArr)
        {
            WriteLine($"param1={param1}");
            foreach(int i in unlimitArr)
            {
                WriteLine($"item={i}");
            }
        }

        static void refMethod(ref int val)
        {
            val *= 2;
        }

        static void Main(string[] args)
        {
            Calc c = Calc.getInstance();
            
            Helloworld instance = new Helloworld();
            instance.Age = 10;

            LinQDemo.testLinQ();


            int contParams = 5;
            refMethod(ref contParams);
            WriteLine($"contParams={contParams}");

            paramsMethod("abc", 1, 2);

            string testStr = "abcd";
            WriteLine(testStr.revert());

            var newVar1 = "abc";
            newVar1 = Convert.ToString(5);


            YesNoEnum yesNoEnum = YesNoEnum.Yes;
            string description = yesNoEnum.FetchDescription();
            WriteLine($"description={description}");
            
            RouteN routeN;
            routeN.direction = Orientation.WEST;
            routeN.distince = 10.13D;
            WriteLine("routeN={0}", routeN.direction);
            WriteLine("routeN={0}", routeN.detail());

            int[] myIntArray = { 1, 2, 3, 4, 5 };
            int[] myIntArray1 = new int[6];

            foreach (int item in myIntArray)
            {
                WriteLine("item{0}", item);
            }

            double[,] dataN = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach (double item in dataN)
            {
                WriteLine(item);
            }

            WriteLine("=============================");

            int[][] jaggedArray = { new int[] { 1 }, new int[] { 2, 3 }, new int[] { 4, 5, 6 } };
            foreach (int[] itemArray in jaggedArray)
            {
                foreach (int item in itemArray)
                {
                    WriteLine(item);
                }
            }

            WriteLine("=============================");
            char[] trims = { 'a' };
            string trimString = "abaca";
            trimString = trimString.Trim(trims);
            WriteLine("trimString={0}", trimString);

            WriteLine("trimString={0}", trimString.PadRight(10) + "efg");

            string myStrig = "A-B-C";
            string[] myStringArr = myStrig.Split(new char[] { '-'});
            foreach(string item in myStringArr)
            {
                WriteLine("item={0}", item);
            }


            Orientation orientation = Orientation.EAST;
            NewOrientation newOrientation = NewOrientation.WEST;

            WriteLine($"orientation={orientation}");
            WriteLine($"newOrientation={(long)newOrientation}");

            WriteLine("10L={0}", Enum.GetName(typeof(NewOrientation), 10L));

            NewOrientation newOrientation1 = (NewOrientation) Enum.Parse(typeof(NewOrientation), newOrientation.ToString());

            Array values = Enum.GetValues(newOrientation.GetType());
            WriteLine($"newOrientation.val={values.GetValue(0)}");

            //Calc calc = new Calc();
            //calc.output();

            StaticData staticData = new StaticData();
            WriteLine($"staticData={staticData.getInterval()}");

            #region 提供控制台操作
            Console.WriteLine("Hello World!");
            
            #endregion

            int MyInteger = 17;
            string MyString = "\"MyInteger=\"";
            Console.WriteLine($"{MyString}{MyInteger}");

            int __ = 11;
            Console.WriteLine(__);

            long dataLong = 100L;
            Console.WriteLine(dataLong);

            //char c = (char)0x0007;

            //Console.WriteLine(c);

            string data = "Beijing\'s data";
            string data1 = @"Beijing\'s data";
            Console.WriteLine(data);
            Console.WriteLine(data1);

            int var1, var3, var2 = -10;
            var1 = +var2;
            var3 = -var2;
            Console.WriteLine(var1);
            Console.WriteLine(var3);

            Console.WriteLine("input:");
            double sndNumber;
            int data3;
            /*
            try
            {
                sndNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {

                //throw;
            }
            */

            int var6, var7, var4 = 5, var5 = 10;
            var6 = var4 * var5++;
            var7 = var4 * ++var5;
            Console.WriteLine($"var4={var4}");
            Console.WriteLine($"var5={var5}");
            Console.WriteLine($"var6={var6}");
            Console.WriteLine($"var7={var7}");

            Debug.WriteLine("");
            Trace.WriteLine("");

            try
            {
                if (var7 > 10)
                {
                    throw new System.Exception("var7 > 10");
                }
            }
            catch (Exception e) when(var7 > 10)
            {

                WriteLine(e.Message);
            }


            /*
            string inputString = Console.ReadLine();
            Type type = inputString.GetType();
            Console.WriteLine($"type={type.ToString()}");
            if (inputString=="1")
            {
                Console.WriteLine("true");
            }
            */

            return;
        }
    }
}
