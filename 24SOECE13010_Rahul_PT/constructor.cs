using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class constructor
    {
        int eid;
        string name;
        string city;
        public constructor()
        {

        }

        public constructor(int eid, string name)
        {
            this.eid = eid;
            this.name = name;
        }

        public constructor(int eid, string name, string city) : this(eid, name)
        {
            this.city = city;
        }

        public void Display()
        {
            Console.WriteLine("EID :" + eid);
            Console.WriteLine("Name :"+name);
            Console.WriteLine("City :"+city);
        }

        public static void Main(string[] args)
        {
            constructor c1 = new constructor();
            constructor c2 = new constructor(1,"RK","Morbi");
            c2.Display();
        }
    }
}
