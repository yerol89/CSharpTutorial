using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops repeats a block of statement while the given condition is true
            //WHILE statement evaluates a Boolean expression and continues to loop while it is true
            Console.WriteLine("WHILE STATEMENT IS EXECUTING");
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine("************************************************************************");
            // DO WHILE statement is like while, except the Boolean expression is checked at the bottom of the 
            //block instead of the top, which means that the block always executes at least once.
            Console.WriteLine("DO WHILE STATEMENT IS EXECUTING");
            string password = string.Empty;
            do
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
            }
            while (password != "yte41.");
            Console.WriteLine("Correct!");
            Console.WriteLine("************************************************************************");
            //FOR statement includes 'initializer,conditional and iterator' expressions
            Console.WriteLine("FOR STATEMENT IS EXECUTING");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("************************************************************************");
            //FOREACH statement helps us to iterate all the members of a collection
            Console.WriteLine("FOREACH STATEMENT IS EXECUTING");
            string[] animals = { "Monkey", "Horse", "Dog", "Cat", "Rabbit" };
            foreach (var item in animals)
            {
                Console.WriteLine($"{item} has {item.Length} characters");
            }
            Console.WriteLine("************************************************************************");

        }
    }
}
