using System;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreChange = true;

            while (moreChange)
            {
                Console.Write("Please enter an integer between 1 and 99: ");
                string input = Console.ReadLine();
                int inputValue;
                bool success = int.TryParse(input, out inputValue);
                bool valid = success && 1 <= inputValue && inputValue <= 99;

                while (!valid)
                {
                    Console.WriteLine("Invalid Input. Try again...");
                    Console.Write("Please enter an integer between 1 and 99: ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out inputValue);
                    valid = success && 1 <= inputValue && inputValue <= 99;
                }

                int nCents = inputValue;

                int nHundred = nCents / 10000;
                nCents = nCents % 10000;

                int nFifty = nCents / 5000;
                nCents = nCents % 5000;

                int nTwenty = nCents / 2000;
                nCents = nCents % 2000;

                int nTen = nCents / 1000;
                nCents = nCents % 1000;

                int nFive = nCents / 500;
                nCents = nCents % 500;

                int nDollar = nCents / 100;
                nCents = nCents % 100;

                int nQuarter = nCents / 25;
                nCents = nCents % 25;

                int nDimes = nCents / 10;
                nCents = nCents % 10;

                int nNickle = nCents / 5;
                nCents = nCents % 5;

                Console.WriteLine(nHundred + " Hundred(s):");
                Console.WriteLine(nFifty + " Fifty(s):");
                Console.WriteLine(nTwenty + " Twenty(s):");
                Console.WriteLine(nTen + " Tens(s):");
                Console.WriteLine(nFive + " Five(s):");
                Console.WriteLine(nDollar + " Dollar(s):");
                Console.WriteLine(nQuarter + " Quarter(s):");
                Console.WriteLine(nDimes + " Dime(s):");
                Console.WriteLine(nNickle + " Nickle(s):");
                Console.WriteLine(nCents + " Cents(s):");

                Console.Write("Would you like more change? [y or n] ");

                string strMoreChange = Console.ReadLine().ToUpper();

                if (strMoreChange != "Y" && strMoreChange != "N")
                {
                    Console.WriteLine("Invalid input. Only y or n allowed.");
                    Console.ReadLine();
                    moreChange = true;
                }

                if (strMoreChange == "N")
                {
                    Console.WriteLine("Thank you for using my Change Maker App:");
                    Console.Write("Press any key to exit:");
                    Console.Read();
                    break;
                }

                if (strMoreChange == "Y")
                {
                    moreChange = true;
                }
            }
        }
    }
}

