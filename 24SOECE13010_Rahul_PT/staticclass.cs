using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_PT
{
    internal class staticclass
    {
        /*
         a static class is functionally the same creating a class with a private constructor.
        an instance of the class can never be created.
         by using the statoc keyword the compiler can help by checking that instance members are never accidentally added to thr class 
         If they are , a copile error happens This can help gurantee that an instance is never created 
         */
        static class MethMethods
        {
            //only static data members and static methods
            public void disply()
            {
            }
            public static void show()
            {
            }
        }

        class StudentDetails
        {

            //not required to be created any objects
            private StudentDetails() // nno benefit of adding non static methods
            {// beacuse of private constructor
            }
            public void disply()
            { }

            public static void show()
            {
            }
        }

        class StaticClassDemo
        {
            static void Main(string[] args)
            {
                //Trick - 1
                //1) You can not create an object of a static class
                MathMethods obj2 = new MathMethods();
                //2) you can call static methods with class name 
                MathMethods.show();

                // to create object of a class
                // to call methods , constrctors etc.
                // to assign values ot calculate values for data members

                //Trick - 2
                //1) you can not create an object with private constructor
                StudentDetails obj1 = new StudentDetails();
                //2) you can call static methods with class name
                StudentDetails.show();
                //3) you can not call non static methods with class name
                obj1.disply();

            }
        }


    }
}