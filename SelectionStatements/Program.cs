using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF STATEMENTS
            //if (expression1)
            //{
            //    // runs if expression1 is true
            //}
            //else if (expression2)
            //{
            //    // runs if expression1 is false and expression2 if true
            //}
            //else if (expression3)
            //{
            //    // runs if expression1 and expression2 are false
            //    // and expression3 is true
            //}
            //else
            //{
            //    // runs if all expressions are false
            //}
            int x = 20;
            int y = 40;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("y is greater than x");
            }

            //SWITCH STATEMENT
            //switch (expression)
            //{
            //    case x:
            //        // code block
            //        break;
            //    case y:
            //        // code block
            //        break;
            //    default:
            //        // code block
            //        break;
            //}

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Wrong Choice!!!");
                    break;
            }
        }
    }
}
