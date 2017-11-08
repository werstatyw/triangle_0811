using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_0811
{
    class Triangle
    {
        public double a; //later they won’t be public …
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        public double Circumference()
        {
            return a + b + c;
        }

        public double Area() //Heron’s Formula
        {
            double s = Circumference() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
       
        public Triangle()
        {
            Random rand = new Random();
            do
            {
                a = rand.Next(0, 101);
                b = rand.Next(0, 101);
                c = rand.Next(0, 101);
            }
            while (!IsConstructable());
        }
        private bool IsConstructable()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        public string print()
        {
            return "triange a= " + a + " b = "+ b + " c =" + c ;
        }

    }

}
