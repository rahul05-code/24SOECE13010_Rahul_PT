using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class no
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Mobile Number: ");
            string m = Console.ReadLine();

            if (m.Length > 5)
            {
                string firstPart = m.Substring(0, m.Length - 5);
                string lastPart = new string('X', 5);
                string maskedNumber = firstPart + lastPart;
                Console.WriteLine("Masked Mobile Number: " + maskedNumber);
            }
            else
            {
                Console.WriteLine("Mobile number is too short to mask.");
            }

            Console.ReadLine();

        }
    }
}
