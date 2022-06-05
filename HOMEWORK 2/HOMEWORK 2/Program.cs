using System;

namespace HOMEWORK_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currency = { "USD", "RUB", "TRY", "EUR" };

            string[] commandBox = { "/show-recent-currency-rates", "/find-currency-rate-by-code", "/calculate-amount-by-currecy", "/exit" };

            for (int i = 0; i < commandBox.Length; i++)
            {
                Console.WriteLine(commandBox[i]);
            }

            string requiredCommand = Console.ReadLine();

            int indexCommand = 0;

            int totalrequiredCommand = 0;

            float USD = 1.700f;
            float RUB = 0.0271f;
            float TRY = 0.1031f;
            float EUR = 1.8271f;



            while (indexCommand < commandBox.Length)
            {
                if (commandBox[indexCommand] == requiredCommand)
                {

                    for (int i = 0; i < currency.Length; i++)
                    {
                        Console.WriteLine($"1 {currency[0]} - {USD} AZN ");
                        break;
                    }
                    for (int j = 1; j < commandBox.Length; j++)
                    {
                        Console.WriteLine($"1 {currency[1]} - {RUB} AZN ");
                        break;
                    }

                    for (int k = 2; k < commandBox.Length; k++)
                    {
                        Console.WriteLine($"1 {currency[2]} - {TRY} AZN ");
                        break;
                    }

                    for (int c = 2; c < commandBox.Length; c++)
                    {
                        Console.WriteLine($"1 {currency[3]} - {EUR} AZN ");
                        break;
                    }


                    totalrequiredCommand++;


                }

                break;
                indexCommand++;
            }
            Console.WriteLine("");
            Console.WriteLine("SELECT CURRENCY OR EXIT w/ (/exit)");

            string requiredCurrency = Console.ReadLine();

            int indexCurrency = 0;

            int totalRequiredCurrency = 0;

            while (indexCurrency < currency.Length)
            {
                if (currency[indexCurrency] == requiredCurrency)
                {
                    Console.WriteLine($"1 {currency[indexCurrency]} - {USD} AZN ");
                    totalRequiredCurrency++;



                }
                while (true)
                {
                    Console.WriteLine("MEBLEGI DAXIL EDIN");
                    double requiredAmount = Convert.ToDouble(Console.ReadLine());

                    double totalRequiredAmount = requiredAmount * USD;
                    Console.WriteLine(totalRequiredAmount);
                }
                while (true)
                {
                    Console.WriteLine("MEBLEGI DAXIL EDIN");
                    double requiredAmount = Convert.ToDouble(Console.ReadLine());

                    double totalRequiredAmount = requiredAmount * EUR;
                    Console.WriteLine(totalRequiredAmount);

                    indexCurrency++;
                    break;
                }



            }
        }
    }
}
