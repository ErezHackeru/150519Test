using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505_Part4_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(12, 5);
            Rational r2 = new Rational(11, 6);
            Console.WriteLine($"r1 {r1}");
            Console.WriteLine($"r2 {r2}");

            Console.WriteLine($"Greater then is: {r1.greaterThan(r2)}");
            Console.WriteLine($"Equals is: {r1.equals(r2)}");            
            Console.WriteLine($"rSum is: {r1.plus(r2)}");
            Console.WriteLine($"Minus is: {r1.minus(r2)}");
            Console.WriteLine($"Multiply then is: {r1.multiply(r2)}");
            Console.WriteLine($"r1.GetNumerator then is: {r1.GetNumerator()}");
            Console.WriteLine($"r2.getDenominator then is: {r2.getDenominator()}");

            Console.ReadKey();
        }
    }
}
