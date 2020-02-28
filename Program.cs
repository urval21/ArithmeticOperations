using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArithmeticOperations
{
    class Program
    {
        static double basicArithmetic(double Num1, double Num2, int flag)

        {
            switch (flag)
            {
                case 1:
                     return ( Num1 + Num2);
                    
                case 2:
                     return (Num1 - Num2);

                case 3:
                     return ( Num1 * Num2);

                case 4:
                    {
                        if (Num2 == 0)

                            Console.WriteLine("It is not possible to divide by zero");
                        else
                            return (Num1 / Num2);

                       break;
                    }
                default: break;
            }

            return double.NaN;        
        }

        static void Main(string[] args)
        {
            double Num1, Num2;
            int flag;

            Console.WriteLine("Hello, This is Urval Patel\n");

            try
            {

                    Console.WriteLine("Enter the First Number: ");
                    Num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the Second Number: ");
                    Num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Main Menu:\n");

                    Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n");

                    Console.WriteLine("Enter the number of Arithmetic Operation that you wish to perform:");

                    flag = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The output of the Basic Arithmetic Operation is: " + basicArithmetic(Num1, Num2, flag));

            }

            catch (FormatException ex)
            {
    
                Console.WriteLine("Please enter only integers\n" + ex.Message);

            }

        }
    }
}
