using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_0811
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            Console.WriteLine(t.print());
           // Console.WriteLine("circ= " + t.Circumference());
            //Console.WriteLine("area=" + t.Area());
            Console.ReadKey();
        }
    }
}
