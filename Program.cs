using System.Globalization;
using System.Text;

namespace DZ_CS_1_
{
    internal class Program
    {
        static void Main()
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
        }   
        static void Ex1()
        {
            Console.WriteLine("--------------------Excercise 1--------------------");
            int number;
            bool correct = true;
            do
            {
                // ввод числа 
                Console.Write("Enter your number: ");
                number = int.Parse(Console.ReadLine());
                // валидация ввода и выполнение условия задачи
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
            Console.WriteLine("--------------------Excercise 2--------------------");

            // ввод первого числа 
            Console.Write("Enter the digit: ");
            int digit = int.Parse(Console.ReadLine());

            // ввод процента от числа
            Console.Write("Enter the procent: ");
            double procent = double.Parse(Console.ReadLine());

            // вычисление результата и вывод его в консоль
            double res = (digit * procent) / 100;
            Console.WriteLine("Result: " + res);
        }
        static void Ex3()
        {
            Console.WriteLine("--------------------Excercise 3--------------------");

            // ввод первого числа и преобразование его в строку
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            string str1 = num1.ToString();

            // ввод второго числа и преобразование его в строку
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            string str2 = num2.ToString();

            // ввод третьего числа и преобразование его в строку
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());
            string str3 = num3.ToString();

            // ввод четвертого числа и преобразование его в строку
            Console.Write("Enter fourth number: ");
            int num4 = int.Parse(Console.ReadLine());
            string str4 = num4.ToString();

            // сложение в одну строку всех получившихся из чисел строк 
            string strFinal = str1 + str2 + str3 + str4;

            // преобразование финальной строки в число и вывод его в консоль
            int res = int.Parse(strFinal);
            Console.WriteLine("Result digit is: " + res);
        }
        static void Ex4()
        {
            Console.WriteLine("--------------------Excercise 4--------------------");

            int dig1 = 0;
                int dig2 = 0;
                int number;
                bool correct = true;

                do
                {
                    // ввод самого числа
                    Console.Write("Enter number: ");
                    number = int.Parse(Console.ReadLine());

                    if (number > 999999) { Console.WriteLine("Enter wrong number!"); }
                    else if (correct)
                    {
                        correct = false;
                        // ввод первого перемещаемого разряда
                        Console.Write("Enter the first digit number of which you want to move : ");
                        dig1 = int.Parse(Console.ReadLine()) - 1;

                        // ввод второго перемещаемого разряда
                        Console.Write("Enter the second digit number of which you want to move : ");
                        dig2 = int.Parse(Console.ReadLine()) - 1;

                        // валидация для разрядов
                        if (dig1 > 6 || dig2 > 6 || dig1 == dig2) { Console.WriteLine("Enter wrong digits number!"); correct = true; }

                    }
                } while (correct);

                //преобразование числа в массив литералов для того чтобы пройтись по нему с помощью цикла 
                string str = number.ToString();
                char[] s = str.ToCharArray();
                for (int i = 0; i < str.Length; i++)
                {
                    char tmp;
                    // перестановка чисел в соответствии с выбранными разрядами
                    if (i == dig1)
                    {
                        tmp = s[dig1];
                        s[dig1] = s[dig2];
                        s[dig2] = tmp;
                    }
                }
                s.ToString();

                // и обратно в число для того чтобы им можно было оперировать 
                number = int.Parse(s);
                Console.WriteLine("Result number: " + number);
        }
        static void Ex5()
        {
            Console.WriteLine("--------------------Excercise 5--------------------");

            int day;
            int month;
            int year;
            bool correct = true;
            //-----------------------------------------------------------------------------
            do
            {
                Console.Write("Enter year: ");    // ввод года
                year = int.Parse(Console.ReadLine());
                //валидация ввода года
                if (year > 9999 || year < 1) { Console.WriteLine("Wrong input year!"); }

                //-----------------------------------------------------------------------------
                Console.Write("Enter month: ");   // ввод месяца
                month = int.Parse(Console.ReadLine());
                //валидация ввода месяца
                if (month < 1 || month > 12) { Console.WriteLine("Wrong input month!"); }
                else { correct = false; }

                //-----------------------------------------------------------------------------
                Console.Write("Enter day: ");     // ввод дня
                day = int.Parse(Console.ReadLine());

                //-----------------------------------------------------------------------------
                bool leapYear = false;            // провекра года на высокосный
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) { leapYear = true; }

                //-----------------------------------------------------------------------------
                //валидация ввода дня
                if (day < 1 || day > 31) { Console.WriteLine("Wrong input day!"); correct = true; }
                else if (!leapYear && month == 2 && day > 28) { Console.WriteLine("Wrong input day!"); correct = true; }
                else if (leapYear && month == 2 && day > 29) { Console.WriteLine("Wrong input day!"); correct = true; }
            } while (correct);

            Console.WriteLine("Entered date: " + day + "." + month + "." + year);

            //-----------------------------------------------------------------------------

            //использование cnhernehs DateOnly из пространства имен System
            //(до конца так и не изучил методы но как работает в принципе понятно)

            DateOnly someD = new(year, month, day);

            //-----------------------------------------------------------------------------
            // ветвление для вывода значения месяца в консоль
            switch (someD.Month)
            {
                case 1:
                    Console.Write("Winter\t");
                    break;
                case 2:
                    Console.Write("Winter\t");
                    break;
                case 3:
                    Console.Write("Spring\t");
                    break;
                case 4:
                    Console.Write("Spring\t");
                    break;
                case 5:
                    Console.Write("Spring\t");
                    break;
                case 6:
                    Console.Write("Summer\t");
                    break;
                case 7:
                    Console.Write("Summer\t");
                    break;
                case 8:
                    Console.Write("Summer\t");
                    break;
                case 9:
                    Console.Write("Autumn\t");
                    break;
                case 10:
                    Console.Write("Autumn\t");
                    break;
                case 11:
                    Console.Write("Autumn\t");
                    break;
                case 12:
                    Console.Write("Winter\t");
                    break;
                default:
                    break;
            }

            //-----------------------------------------------------------------------------
            // ветвление для вывода значения дня недели в консоль
            switch (someD.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sunday");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Monday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Friday");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    break;
            }
        }
    }

}