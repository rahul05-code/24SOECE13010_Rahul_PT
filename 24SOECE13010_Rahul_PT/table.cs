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
            int num, res, i;
            Console.WriteLine("Enter number :");
            num = Convert.ToInt32(Console.ReadLine());

            i = 1;
            while (i <= 10)
            {
                res = num * i;
                Console.WriteLine("{0} * {2} = {1}",num,res,i);
                i++;

            }
        }
    }
}
