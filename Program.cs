//Write a function that takes 4 numbers as input to calculate the total and average.

namespace CCAD16_Assignment3_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome! Please enter 4 numbers below---");
            FourNumbers();
        }

        static void FourNumbers()
        {
            Console.WriteLine("\nPlease enter the 1st number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the 2nd number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the 3rd number:");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the 4th number:");
            double fourthNumber = Convert.ToDouble(Console.ReadLine());

            double sumNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;
            double avgNumber = sumNumber / 4;

            Console.WriteLine($"\nThe sum of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is: {sumNumber}");
            Console.WriteLine($"\nThe average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is: {avgNumber}");
        }
    }
}
