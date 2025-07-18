using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int num = Console.ReadLine();
            for (int i = num; i <= 10; i++)
            {
                for(int j = i; j <= 10; j++)
                {
                    int k = i * j;
                    Console.WriteLine(i + "*" + j + " = "+ k);
                }
                Console.ReadLine();
            }
        }
    }
}
