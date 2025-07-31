using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    /// <summary>
    /// This is swapmethod class
    /// </summary>
    internal class swapmethod
    {
        /// <summary>
        /// This is SwapMethod to swap to element 
        /// </summary>
        /// <param name="a">a is ref variable </param>
        /// <param name="b">b is ref variable</param>
        static void swapMethod(ref int a,ref int b)
        {
            //int temp = a;
            //a = b;
            //b = temp;
            a = a + b;
            b = a - b;
            a = a - b;
        }
        /// <summary>
        /// This method is main method 
        /// </summary>
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
