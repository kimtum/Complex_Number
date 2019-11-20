using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Numbers
{
    class Complex
    {
        private double Re;
        private double Im;
        public Complex() { }
        public Complex(double re, double im)
            {
            this.Re = re;
            this.Im = im;
            }

        public double Real() => this.Re;
        public double Imagenary() => this.Im;

        
        public static Complex operator+(Complex x, Complex y)
        {
            Complex sum = new Complex(x.Re + y.Re, x.Im + y.Im);
            return sum;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            Complex sub = new Complex(x.Re - y.Re, x.Im - y.Im);
            return sub;
        }

        public static Complex operator *(Complex x, Complex y)
        {
            Complex mul = new Complex(x.Re * y.Re - x.Im * y.Im, x.Re * y.Im + x.Im * y.Re);
            return mul;
        }

        public static Complex operator /(Complex x, Complex y)
        {
            if (y.Re == 0 && y.Im == 0)
            {
                Console.WriteLine("ERROR: Divizion by zero.");
                return y;
            }
            else
            {
                Complex prec_y = new Complex(x.Re / x.Re  * x.Re + x.Im * x.Im, - x.Im / x.Re * x.Re + x.Im * x.Im);
                return x * prec_y;
            }
        }

        public Complex Addition(Complex y)
        {
            return this + y;
        }

        public Complex Substraction(Complex y)
        {
            return this - y;
        }

        public Complex Multiplication(Complex y)
        {
            return this * y;
        }

        public Complex Division(Complex y)
        {
            return this / y;
        }
        
        public double Magnitude()
        {
            return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
        }

        public double Absolute()
        {
            return Math.Atan2(this.Re, this.Im);
        }

        public override string ToString()
        {   
            string sign = "+";
            if (this.Im < 0)
                sign = "-";

            if (this.Re == 0 && this.Im == 0)
                return $"{0}";
            else if (this.Im == 0)
                return $"{this.Re}";
            else if (this.Re == 0)
                return $"{sign}{Math.Abs(this.Im)}i";
           
            return $"{this.Re} {sign} {Math.Abs(this.Im)}i";
        }

    }


        
}
