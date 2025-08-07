using System;

namespace _24SOECE13010_Rahul_PT

{

    class Line

    {

        private double length;   // Length of a line

        public Line()

        {

            this.length = 10;

            Console.WriteLine("Lenth :"+length);

        }



        public void setLength(double len)

        {

            this.length = len;   



        }

        public double getLength()

        {

            return length;     

        }

    }



    class t3_q6

    {

        static void Main(string[] args)

        {

            Line line = new Line();

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();

        }

    }

}