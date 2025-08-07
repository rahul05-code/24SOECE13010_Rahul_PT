using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    class student
    {
        private string fname;
        //private string lname;

        //
        public string getName()// with out property
        {
            return fname;
        }
        public string setLname(string fname)//without property
        {
            return fname;
        }
        //

        public string FirstName//with property
        {
            get {  return fname; }
            set { fname = value; }
        }
    }
    internal class property
    {
        public static void Main(string[] args)
        {
            student s1 = new student();

            s1.setLname("RK");// without property
            Console.WriteLine(s1.getName());

            s1.FirstName = "RK"; // this is using property
            Console.WriteLine(s1.FirstName);
            //string t = s1.FirstName;
        }
    }
}
