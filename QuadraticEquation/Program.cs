using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);
            double numberator1 = (0 - b) + Math.Sqrt(discriminant);
            double numberator2 = (0 - b) - Math.Sqrt(discriminant);
            double denominator = 2 * a;

            double posx = numberator1 / denominator;
            double negx = numberator2 / denominator;

            Console.WriteLine("x = " + posx + " and " + negx);
        }
    }
}
