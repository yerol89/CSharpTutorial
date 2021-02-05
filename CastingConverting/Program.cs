using System;
using static System.Convert;
namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting, and it has two varieties: IMPLICIT and EXPLICIT.
            //Implicit casting happens automatically, and it is safe, meaning that you will not lose any information.
            //Explicit casting must be performed manually because it may lose information
            int a = 10;
            double b = a; //We can IMPLICITLY cast an int into a double without any problem
            Console.WriteLine(b);
            //But when we try to do this vice versa-casting a double into an int- we will get an error
            //Because while converting a double into int we will lose some of ingormation
            //So we need to cast it EXPLICITLY
            double c = 9.8;
            int d = (int)c;
            Console.WriteLine(d); // d will be printed as 9 losing the .8 part
            //Converting with the System.Convert type
            double g = 9.8;
            int h = ToInt32(g);
            Console.WriteLine($"g is {g} and h is {h}");//When we run this code, output will be 10 for 'h'
            //Main difference between 'CASTING' and 'CONVERTING' is, converting 'ROUNDS' the number

        }
    }
}
