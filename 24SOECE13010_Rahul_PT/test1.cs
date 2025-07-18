using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class test1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int a;
            a = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++) {


                if (a == 0)
                {
                    Console.WriteLine("Zero");
                    return;
                }
                else if (a == 1)
                {
                    Console.WriteLine("One"); return;
                }
                else if (a == 2)
                {
                    Console.WriteLine("Two");
                    return;
                }
                else if (a == 3)
                {
                    Console.WriteLine("Three");
                    return;
                }
                else if (a == 4)
                {
                    Console.WriteLine("Four");
                    return;
                }
                else if (a == 5)
                {
                    Console.WriteLine("Five");
                    return;
                }
                else if (a == 6)
                {
                    Console.WriteLine("Six");
                    return;
                }
                else if (a == 7)
                {
                    Console.WriteLine("Seven");
                    return;
                }
                else if (a == 8)
                {
                    Console.WriteLine("Eight");
                }
                else if (a == 9)
                {
                    Console.WriteLine("Nine");
                }
            }

            }
        }
    }
}
