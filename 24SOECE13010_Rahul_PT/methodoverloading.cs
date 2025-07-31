using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    class methodoverloading
    {
        //int x;
        //int y;
        //int z;
        static void Sum(ref int x,ref int y)
        {
            //x = x;
            //y = y;
            int sum = x+ y;
            Console.WriteLine("sum of {0} and {1} is :{2}",x,y,sum);
        }

        static void Sum(ref int x,ref int y,ref int z)
        {
            //x = x;
            //y = y;
            //z = z;
            int sum = x+ y+z;
            Console.WriteLine("sum of {0} + {1} + {2} is :{3}",x,y,z,sum);

        }

         public static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = 30;

            Sum(ref x,ref y);
            Sum(ref x,ref y,ref z);

        }

    }
}
