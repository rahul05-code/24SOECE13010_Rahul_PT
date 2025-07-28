using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class addition
    {
        public static void Main(string[] args)
        {
            //Add ad = new Add();
            int a = 20, b = 10;
            int ra;
            ra = Add(a, b);
            Console.WriteLine("Addition :" + ra);

            ra = Sub(a, b);
            Console.WriteLine("Subtrsction :" + ra);

            ra = Multi(a, b);
            Console.WriteLine("Multiplication :" + ra);

            ra = Div(a, b);
            Console.WriteLine("Division :" + ra);
        }
        static int Add(int a,int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Multi(int a, int b)
        {
            return a * b;
        }

        static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
