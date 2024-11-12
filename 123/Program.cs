using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Number System Conversion Calculator.");
            Console.WriteLine("Choose the conversion direction:");
            Console.WriteLine("1. From Decimal to Binary");
            Console.WriteLine("2. From Binary to Decimal");

            string choice = Console.ReadLine();
            if (choice != "1" && choice != "2")
            {
                throw new InvalidOperationException("Invalid choice. Please choose 1 or 2.");
            }
            if (choice == "1")
            {
                Console.WriteLine("Enter a decimal number:");
                string input = Console.ReadLine();

                int decimalNumber;
                bool isValid = int.TryParse(input, out decimalNumber);

                if (isValid)
                {
                    string binary = Convert.ToString(decimalNumber, 2);
                    Console.WriteLine("Result in binary: " + binary);
                }
                else
                {
                    Console.WriteLine("err");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter a binary number:");
                string input = Console.ReadLine();

                try
                {
                    int decimalNumber = Convert.ToInt32(input, 2);
                    Console.WriteLine("Result in decimal: " + decimalNumber);
                }
                catch (FormatException a)
                {
                    Console.WriteLine(a.Message);
                }
                catch (OverflowException a)
                {
                    Console.WriteLine(a.Message);
                }
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
