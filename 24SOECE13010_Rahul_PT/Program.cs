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

            for (int i = 1; i <= 9; i++)
            {

                int k = i <= 5 ? i : 10 - i;
                for (int j = 1; j <= k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
