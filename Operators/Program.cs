using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERATING ON VARIABLES
            //Operators apply simple operations such as addition and multiplication to operands such as variables and literal values.
            int x = 5; //Declared an integer
            int incrementedByOne = x++; //Incremented value of x by 1
            Type theTypeOfAnInteger = typeof(int); // Determine the type of a variable
            int howManyBytesInAnInteger = sizeof(int); // Determine the size of a variable
            // Increment by POSTFIX
            // The output will be a=4 and b=3
            //Why not b is equal to 4?
            //Because the '++' operator which is used AFTER the variable makes the increment after the assignment.
            int a = 3;
            int b = a++;
            Console.WriteLine($"a is {a}, b is {b}");
            Console.WriteLine("************************************************************************");
            // Increment by PREFIX
            // The output will be c=7 and d=7
            //In this example'++' operator which is used BEFORE the variable makes the increment BEFORE the assignment.
            int c = 6;
            int d = ++c;
            Console.WriteLine($"c is {c}, d is {d}");
            Console.WriteLine("************************************************************************");
            //Arithmetic Operators
            int e = 11;
            int f = 3;
            Console.WriteLine($"e is {e}, f is {f}");
            Console.WriteLine($"e + f = {e + f}");
            Console.WriteLine($"e - f = {e - f}");
            Console.WriteLine($"e * f = {e * f}");
            Console.WriteLine($"e / f = {e / f}"); // Gives the integer value of division,if define e or f as double or float it gives the exact result
            Console.WriteLine($"e % f = {e % f}"); // Gives the remainder from the division of these integers
            Console.WriteLine("************************************************************************");
            //Assignment Operators
            int p = 6;
            p += 3; // equivalent to p = p + 3;
            p -= 3; // equivalent to p = p - 3;
            p *= 3; // equivalent to p = p * 3;
            p /= 3; // equivalent to p = p / 3;
            Console.WriteLine("************************************************************************");
            //Logical Operators
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine($"AND | b1 | b2 ");
            Console.WriteLine($"b1 | {b1 && b1,-5} | {b1 && b2,-5} ");
            Console.WriteLine($"b2 | {b2 && b1,-5} | {b2 && b2,-5} ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine($"OR | b1 | b2 ");
            Console.WriteLine($"b1 | {b1 || b1,-5} | {b1 || b2,-5} ");
            Console.WriteLine($"b2 | {b2 || b1,-5} | {b2 || b2,-5} ");
            Console.WriteLine("************************************************************************");
            //This example very useful for be aware of another type of operands
            // How many operators in the following statement?
            int age = 47;
            // How many operators in the following statement?
            string convertString = age.ToString();
            char firstDigit = convertString[0];
            Console.WriteLine($"The first character of age is {firstDigit}");
            // There are four operators:
            // = is the assignment operator
            // . is the member access operator
            // () is the invocation operator
            // [] is the indexer access operator
        }
    }
}
