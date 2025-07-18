using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class test2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            String[] ints = {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};

            int digit;
            while (a > 0)
            {
                digit = a % 10;
                a = a / 10;
                Console.WriteLine(digit);
            }
            for (int i = a; i < ints.Length; i++)
            {
                Console.WriteLine();

                

            }

            

            
            
        }
    }
}
