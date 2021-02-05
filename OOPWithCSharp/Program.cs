using System;

namespace OOPWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PERSON class operations
            var p1 = new Person();
            p1.Name = "Yunus Erol";
            p1.DateOfBirth = new DateTime(1989, 01, 22);
            p1.Children.Add(new Person {Name ="Almila Erol" });
            Console.WriteLine("{0} was born on {1: d MMMM yyyy}",p1.Name,p1.DateOfBirth);
            Console.WriteLine("{0} has {1} children",p1.Name,p1.Children.Count);
            foreach (var item in p1.Children)
            {
                Console.WriteLine("{0}'s children name is {1}",p1.Name,item.Name);
            }
            Console.WriteLine("Name of {0}'s children is {1}",p1.Name,p1.Children[0].Name );
            var p2 = new Person
            {
                Name = "Erdem Yılmaz",
                DateOfBirth = new DateTime(1990, 12, 12),
              
            };
            p2.Children.Add(new Person {Name="Serkan Yılmaz" });
            Console.WriteLine("{0} was born on {1: d MMMM yyyy}", p2.Name, p2.DateOfBirth);

            //BANKACCOUNT class operations
            BankAccount.InterestRate = 0.012; // We can call 'InterestRate' field without an instance because it is static
            BankAccount account1 = new BankAccount();
            account1.AccountName = "Mr. Yunus";
            account1.Balance = 2400.0;

            BankAccount account2 = new BankAccount();
            account2.AccountName = "Mr. Emre";
            account2.Balance = 5000.0;
             
            Console.WriteLine("{0} earned {1} TL interest", account1.AccountName, account1.Balance * BankAccount.InterestRate );
            Console.WriteLine("{0} earned {1} TL interest", account2.AccountName, account2.Balance * BankAccount.InterestRate);


        }
    }
}
