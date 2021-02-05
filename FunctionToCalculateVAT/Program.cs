using System;

namespace FunctionToCalculateVAT
{
    class Program
    {
        //The CalculateTax function has two inputs: 
        //A parameter named 'amount' that will be the amount of money spent 
        //Another parameter named 'twoLetterRegionCode' that will be the region the amount is spent in.
        //The CalculateTax function will perform a calculation using a switch statement, 
        //and then return the VAT owed on the amount as a decimal value
        //The RunCalculateTax function prompts the user to enter an amount and a region code, 
        //and then calls CalculateTax and outputs the result.

        static double CalculateTax(double amount, string twoLetterRegionCode)
        {
            double rate;
            switch (twoLetterRegionCode)
            {
                case "CH": // Switzerland
                    rate = 0.08;
                    break;
                case "DK": // Denmark
                case "NO": // Norway
                    rate = 0.25;
                    break;
                case "GB": // United Kingdom
                case "FR": // France
                    rate = 0.2;
                    break;
                case "HU": // Hungary
                    rate = 0.27;
                    break;
                case "OR": // Oregon
                case "AK": // Alaska
                case "MT": // Montana
                    rate = 0.0; break;
                case "ND": // North Dakota
                case "WI": // Wisconsin
                case "ME": // Maryland
                case "VA": // Virginia
                    rate = 0.05;
                    break;
                case "CA": // California
                    rate = 0.0825;
                    break;
                default: // most US states
                    rate = 0.06;
                    break;
            }
            return amount * rate;
        }
        
        static void RunCalculateTax()
        {
            try
            {
                double amountOfMoney;
                Console.WriteLine("Enter the amount of money: ");
                amountOfMoney = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a region code: ");
                string region = Console.ReadLine();
                
                Console.WriteLine($"The VAT you must pay is {CalculateTax(amountOfMoney, region)}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
        }

        static void Main(string[] args)
        {

            RunCalculateTax();

        }
    }
}
