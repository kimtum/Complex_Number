using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex(5, 8);
            Complex y = new Complex(3, 4);

            Console.WriteLine(x + y);
            Console.WriteLine(x.Substraction(y));
            Console.WriteLine(x * y);
            Console.WriteLine(x.Division(y));
            Console.WriteLine(x.Magnitude());
            Console.WriteLine(x.Absolute());
            Console.ReadLine();

        }
    }
}
