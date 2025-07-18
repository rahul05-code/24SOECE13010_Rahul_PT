using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class pattern2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int no;
            no = Convert.ToInt32(Console.ReadLine());

            //int[][] ints = new int [no][];
            Console.WriteLine(no+" "+no+" "+no);
            for (int i = 1; i <= no; i++)
            {
                Console.WriteLine(no+" "+i+" "+no);
            }


        }
    }
}
