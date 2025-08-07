using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    class Student
    {
        private string enroll;
        private string name;

        public string Enroll
        {
            get { return enroll; }
            set { enroll = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
         
    }
    internal class t2_q7
    {
        public static void Main(string[] args)
        {
            Student student = new Student();

            student.Enroll = "24SOECE13010";
            Console.WriteLine(student.Enroll);

            student.Name = "Rahul";
            Console.WriteLine(student.Name);

            string firstname = student.Name;
            string enrollment = student.Enroll;

            Console.WriteLine(firstname);
            Console.WriteLine(enrollment);

            
        }
    }
}
