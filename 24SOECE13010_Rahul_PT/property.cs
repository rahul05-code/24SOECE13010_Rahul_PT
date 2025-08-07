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
        private string lname;

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
            get {  return lname; }
            set { lname = value; }
        }
    }
    internal class property
    {
        public static void Main(string[] args)
        {
            student s1 = new student();

            s1.setLname("RK");// without property

            s1.FirstName = "RK"; // this is using property
        }
    }
}
