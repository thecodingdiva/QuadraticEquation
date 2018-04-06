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
            Console.WriteLine("Quadratic Equation Calculator");

            try
            {
                Console.WriteLine("Enter coefficient a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                                
                Console.WriteLine("Enter coefficient b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                    
                Console.WriteLine("Enter coefficient c: ");
                double c = Convert.ToDouble(Console.ReadLine());
                       
                double discriminant = (b * b) - (4 * a * c);
                if (discriminant < 0)
                {
                    throw new FormatException("Imaginary number.");
                }
                else
                {
                    double numberator1 = checked((0 - b) + Math.Sqrt(discriminant));
                    double numberator2 = checked((0 - b) - Math.Sqrt(discriminant));
                    double denominator = checked(2 * a);

                    if (denominator == 0)
                    {
                        new DivideByZeroException("Dividing by 0");
                    }
                    else
                    {
                        double posx = numberator1 / denominator;
                        double negx = numberator2 / denominator;

                        Console.WriteLine("x = " + posx + " and " + negx);
                    } 
                }                              
            }
            catch(FormatException e)
            {
                Console.WriteLine("Your input produces an imaginary number.");
            }
            catch(DivideByZeroException e1)
            {
                Console.WriteLine("Your input produces an imaginary number.");
            }
            finally
            {
                Console.WriteLine("Your program has terminated");
            }
        }
    }
}
