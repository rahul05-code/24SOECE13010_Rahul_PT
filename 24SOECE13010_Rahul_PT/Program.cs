using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                int rows = 5;
                for (int j = rows; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
