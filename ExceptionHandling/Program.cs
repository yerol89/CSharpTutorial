using System;
using static System.Convert;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //If the user tries to input 'string' type instead of 'double' s/he will get an error
            try
            {
                double number1, number2;
                double result;
                Console.WriteLine("Input a number: ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input a number: ");
                number2 = Convert.ToDouble(Console.ReadLine());
                result = ToDouble(number1 / number2);
                Console.WriteLine($"Division of {number1} and {number2} is {result} ");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
           
        }
    }
}
