using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class ComplexNumbers
    {
        public double Real{get;set;}
        public double Imaginary {get;set;}
        public ComplexNumbers(double real,double imaginary)
        {
            Real=real;
            Imaginary=imaginary;
        }
        public override string ToString()
        {
            return ($"{Real}+{Imaginary}");
        }
        public static ComplexNumbers operator + (ComplexNumbers num1,ComplexNumbers num2)
        {
            return new ComplexNumbers(num1.Real+num2.Real,num1.Imaginary+num2.Imaginary);
        }
        public static ComplexNumbers operator - (ComplexNumbers num1,ComplexNumbers num2)
        {
            return new ComplexNumbers(num1.Real+num2.Real,num1.Imaginary+num2.Imaginary);
        }
    }
}