using System.Data.SqlTypes;

namespace DZ_CS_1_
{
    internal class Program
    {
        static void Main()
        {
            Ex1();
            Ex2();

            
        }
        static void Ex1()
        {
            int number;
            bool correct = true;
            do
            {
                Console.Write("Enter your number: ");
                number = int.Parse(Console.ReadLine());

                if (number > 0 && number <= 100)
                {
                    correct = false;
                    if ((number % 3) == 0 && (number % 5) != 0) { Console.WriteLine("Fizz"); }

                    else if ((number % 5) == 0 && (number % 3) != 0) { Console.WriteLine("Buzz"); }

                    else if ((number % 3) == 0 && (number % 5) == 0) { Console.WriteLine("Fizz Buzz"); }

                    else { Console.WriteLine(number); }
                }
                else { Console.WriteLine("Error! Wrong input!"); }

            } while (correct);
        }
        static void Ex2()
        {
            Console.Write("Enter the digit: ");
            int digit = int.Parse(Console.ReadLine());
            Console.Write("Enter the procent: ");
            double procent = double.Parse(Console.ReadLine());
            double res = (digit * procent) / 100;
            Console.WriteLine("Result: " + res);
        }
    }
}