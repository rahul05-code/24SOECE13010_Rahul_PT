using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class pattern
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                int rows = 5;
                for (int j = 1; j <= rows; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
