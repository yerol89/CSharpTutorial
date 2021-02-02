using System;

namespace SpeakingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //We assigned 1.88 value to VARIABLE 'heightInMetres'
            double heightInMetres = 1.95;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value { heightInMetres}.");
            Console.WriteLine("************************************************************************");
            //A literal value represents a fixed value
            char myLetter = 'Y'; // assigning literal characters
            string lastName = "Erol"; // assigning literal string


            // WORKING WITH NUMBERS: Mostly used number variables are int, float and double
            // Let's have a look at their size and min. to max. value
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range { int.MinValue:N0} to { int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in the range { float.MinValue:N0} to { float.MaxValue:N0}.");
            Console.WriteLine("************************************************************************");
            // Here are some variable types 
            int population = 85000000; // 66 million in UK
            double weight = 1.76; // in kilograms
            string fruit = "Bananas"; // strings use double-quotes
            char letter = 'Y'; // chars use single-quotes
            bool areYouHappy = true; // Booleans have value of true or false

            // We can also use 'var' keyword to define a variable. The compiler will understand if it is an integer, boolean or etc. accordingly to assigned value
            var population2 = 66_000_000; // 66 million in UK
            var weight2 = 1.88; // in kilograms
            var fruit2 = "Apples"; // strings use double-quotes
            var letter2 = 'Z'; // chars use single-quotes
            var areYouHappy2 = true; // Booleans have value of true or false

            //These primitive types(int, double, boolean etc.) are 'value types' except 'string'. Because 'string' is a 'Reference Type'
            //Reference type means, variable contains the memory adress of a value, not the value itself. 
            //Reference type may have a 'null' value which means the variable does not reference anything for now. 'null' is the default value of all reference types.
            //Now let's have a look at the default values of some primitive types  
            Console.WriteLine($"Default value of int = {default(int)}");
            Console.WriteLine($"Default value of boolean = {default(bool)}");
            Console.WriteLine($"Default value of DateTime = {default(DateTime)}");
            Console.WriteLine($"Default value of string = {default(string)}");
            Console.WriteLine("************************************************************************");
            //What if we want to store multiple values of same variable type? We have 'array' for this.
            //Let's assume we need store name of family members 
            string[] familyMembers; // This statement is an array reference
            familyMembers = new string[3]; //Now we allocated memory for this reference, what we should notice here is the '4' inside brackets. 
            //This is the size of the array. So array is a 'fixed-sized' structure.
            familyMembers[0] = "Yunus";
            familyMembers[1] = "Seda";
            familyMembers[2] = "Almila";
            Console.WriteLine($"Name of first family member: {familyMembers[0]} ");
            Console.WriteLine($"Name of second family member: {familyMembers[1]} ");
            Console.WriteLine($"Name of third family member: {familyMembers[2]} ");
            Console.WriteLine("************************************************************************");
            //GETTING INPUT FROM USER
            //We use 'Readline' method for getting input from user
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age: ");
            string age = Console.ReadLine();
            Console.WriteLine($"You are {name} and {age} years old");
        }
    }
}
