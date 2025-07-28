using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class outdemo
    {
        static void change(ref int a,ref int b)
        {
            a = 100;
            //b= 200;
        }

        static void Out(out int x,out int y)
        {
            x= 100;
            y= 200;
        }


        static void Main()
        {
            int a = 10, b = 20;
            int x = 20, y = 30;
            Console.WriteLine("Before change : a = {0} and b = {1}", a, b);
            change(ref a, ref b);
            Console.WriteLine("After change : a = {0} and b = {1}", a, b);

            Console.WriteLine("Before out : x = {0} and y = {1}", x, y);
            Out(out x, out y);
            Console.WriteLine("After out : x = {0} and y = {1}", x, y);
        }
    }
}
