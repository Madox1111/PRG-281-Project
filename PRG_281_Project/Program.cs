using System.Diagnostics.CodeAnalysis;

namespace _Corneluis_Smith___Hendry_Ihlenfeldt___Pieter_Nel___Tiaan_Theron__Project
/*
Unique Building Services Loan Company gives out loans of up to R100 000 for construction projects. 
There are two categories of loans:
 * Business loans and
 * Individual loans. 

Write a C# Console application that tracks all new construction loans. 
The application must calculate the total amount owed at the due date (original loan amount + loan fee).

 */
{
    internal class Program
    {

        public static DataHandler dataHandler = new DataHandler();

        //Display message returning currsor to the start of the line and clearing the text
        static void InputError(string message)
        {
            Console.CursorTop -= 2;
            Console.WriteLine(message);
            Console.Write(new string(' ', Console.WindowWidth) + "\r");
        }

        //reatreve loan number with input cehking
        static int loanNumber()
        {
            int Number;
            Console.WriteLine("" +
                "=================================\n" +
                "Enter Loan Number\n" +
                "=================================\n");
            for(; ; )
            {
                try
                {
                    Number = int.Parse(Console.ReadLine());
                    return Number;
                }
                catch { }
                InputError("Invalid loan number");
            }
        }

        //Display menu for loan type
        static int loanType()
        {
            int select;
            Console.WriteLine("" +
                "=================================\n" +
                "Please select a loan type");
            foreach (LoanType type in Enum.GetValues(typeof(LoanType)))
                Console.WriteLine("Enter {1} for {0}",type.ToString(),(int)type);
            Console.WriteLine("=================================\n");
            for (; ; )
            {
                try
                {
                    select = int.Parse(Console.ReadLine());
                    if (select >= 0 && select < Enum.GetValues(typeof(LoanType)).Length)
                        return (select);
                }
                catch { }
                InputError("Invalid loan type selected");
            }
        }

        //Dispaly menu for loane term
        static int loanTerm()
        {
            int selectterm;
            Console.WriteLine("" +
                "================================\n" +
                "Please select a loan term");
            foreach (LoanTerm term in Enum.GetValues(typeof(LoanTerm)))
                Console.WriteLine("The {1}-term loan will span over {0} years",(int)term, term.ToString());
            Console.WriteLine("Enter loan time duraion\n" +
                "================================\n");
            for(; ; )
            {
                try
                {
                    selectterm = int.Parse(Console.ReadLine());
                    switch (selectterm)
                    {
                        case (3)://set mid term
                            Console.WriteLine("Mid term selected");
                                return (3);
                        case (5)://set to long term
                            Console.WriteLine("Long term selected");
                            return (5);
                        default://Set all other values to short term
                            Console.WriteLine("Short term selected");
                            return (1);
                    }    
                }
                catch { }
                InputError("Invalid Input");
            }
        }
    
        //Request user to input loan amount
        static Double loanAmount()
        {
            double Amount;
            Console.WriteLine("" +
                "=================================\n" + 
                "Please enter loan amount\n" +
                "Enter a loan amount between ( {0:C} ) and ( {1:C} )\n"+
                "=================================\n", 0, LoanConstants.MaxLoanAmount);
            for(; ; )
            {
                try
                {
                    Amount = double.Parse(Console.ReadLine());
                    if (Amount < LoanConstants.MaxLoanAmount || Amount >= 0)
                        return Amount;
                }
                catch { }
                InputError("Invalid Amount");
            }
        }

        //Set Prime interest rate
        static double SetPrimeInterest()
        {
            double input;
            Console.WriteLine();
            for (; ; )
            {
                try
                {
                    input = Double.Parse(Console.ReadLine());
                    if (input >= 0 && input <= 100)
                        return input;
                }
                catch { }
                InputError("Invalid Prime Interst set");
            }
        }

        //Retreave data for datahadler
        static void UserAdd()
        {
            LoanData loanData = new LoanData();      // to confirm if a loan should be added or if its data be changed

            loanData.LoanNumber = loanNumber();

            Console.WriteLine("" +
                "=================================\n" +
                "Enter Customer Name\n" +
                "=================================");
            loanData.CustomerName = Console.ReadLine();

            Console.WriteLine("" +
                "=================================\n" +
                "Enter Customer Surname\n" +
                "=================================");
            loanData.CustomerSurname = Console.ReadLine();

            loanData.LoanAmount = loanAmount();
            loanData.TypeOfLoan =(LoanType)loanType();
            loanData.TermOfLoan = (LoanTerm)loanTerm();

            Console.WriteLine("" +
                "=================================\n" +
                "Adding Data\n" +
                "=================================");
            Thread.Sleep(1000);
            if (loanData.TypeOfLoan.ToString()==LoanType.Personal.ToString())
            {
                Loan loan = new PersonalLoan(loanData);
                dataHandler.AddLoan(loan);
            }
            else
            {
                Loan loan = new BusinessLoan(loanData);
                dataHandler.AddLoan(loan);
            }
        }

        static void Main(string[] args)
        {

            //Show welcome and loading screen
            Console.WriteLine("" +
                "####################################\n" +
                "#                                  #\n" +
                "#        . . . WELCOME . . .       #\n" +
                "#                                  #\n" +
                "####################################");

            Console.WriteLine("Loading");
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
                Console.Write("{0} % Complete\r", i);
            }
            Console.Write("Done                \n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            //show second input screen
            Console.WriteLine("" +
                "=================================\n" +
                $"{LoanConstants.CompanyName}\n" +
                $"Enter Prime Interest Rate (%)\n" +
                "=================================");
            LoanConstants.PrimeInterestRate = SetPrimeInterest();

            //set parameters for third input screens
            string Display = "" +
                "=================================\n" +
                $"{LoanConstants.CompanyName}\n" +
                $"Loan Prime Interest Rate set to {LoanConstants.PrimeInterestRate}%\n" +
                "=================================";
            //show third input screens
            for (int i = 1; i <= 5; i++) 
            {
                Console.Clear();
                Console.WriteLine(Display);
                Console.WriteLine("=============- {0}/5 -=============",i);
                UserAdd();
            }
            Console.Clear();
            //show output screen
            Console.WriteLine("" +
                "=================================\n" +
                $"{LoanConstants.CompanyName}\n" +
                $"Displaying Customers\n" +
                "=================================");
            foreach (Loan loan in dataHandler.GetAllLoans())
                Console.WriteLine(loan.ToString());
            Console.WriteLine("=================================");
            Console.ReadKey();
        }
    }
}