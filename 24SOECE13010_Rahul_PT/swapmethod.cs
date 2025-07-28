using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class swapmethod
    {
        static void swapMethod(ref int a,ref int b)
        {
            //int temp = a;
            //a = b;
            //b = temp;
            a = a + b;
            b = a - b;
            a = a - b;
        }

        static void Main()
        {
            //swapMethod sw = new swapmethod();
            int a =10,b =20;
            Console.WriteLine("Before swap : a = {0} and b = {1}",a,b);
            swapMethod(ref a,ref b);
            Console.WriteLine("After swap : a = {0} and b = {1}",a,b);
        }
    }
}
