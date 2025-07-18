using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of terms:");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number:");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    Console.Write(b+"+"+b++);
                }

            }

            Console.ReadLine();
        }
    }
}
