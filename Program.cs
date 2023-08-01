using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("100 UAH in EUR is " + ToEUR(100));
            Console.WriteLine("100 UAH in USD is " + ToUSD(100));
            Console.WriteLine("100 EUR in UAH is " + FromEUR(100));
            Console.WriteLine("100 USD in UAH is " + FromUSD(100) + "\n");

            // Task 2
            int a = 1;
            int b = 2;
            Console.WriteLine($"a = {a}, b = {b}");
            SwapValues(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");

            // Task 3
            FormatTime(999999);

            // Task 4
            int num;
            Console.Write("\nEnter your number: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{num} backwards is ");
                for (int i = num.ToString().Length - 1; i >= 0; i--)
                {
                    Console.Write(num.ToString()[i]);
                    if (i == 0)
                        Console.WriteLine(".");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Task 5
            double radius, diameter;
            try
            {
                Console.Write("\nEnter your radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your diameter is {radius * 2}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 

            // Task 6
            double candiesPrice, cookiesPrice, applesPrice;
            candiesPrice = 115.45; cookiesPrice = 78.90; applesPrice = 53.80;
            double x, y, z;
            x = 0.95; y = 1.3; z = 2.1;
            double cheque = candiesPrice*x + cookiesPrice *y + applesPrice*z;
            Console.WriteLine($"\nTo be paid: {cheque:F2}.\n");

            // Task 7
            double temperature_celsius = 36.6;
            double temperature_fahrenheit = temperature_celsius * 1.8 + 32;
            double temperature_kelvin = temperature_celsius + 273.15;
            Console.WriteLine($"Temperature is\n{temperature_celsius} in Celsius degrees,\n{temperature_fahrenheit:F2} in Fahrenheit degress,\n{temperature_kelvin} in Kelvins.");

            // Task 8
            try
            {
                Console.Write("\nEnter your sum, please: ");
                double sum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Now enter your discount: ");
                int discount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"To be paid: {sum * (1 - Convert.ToDouble(discount) / 100)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Task 9
            a = new Random().Next(1, 100); b = new Random().Next(1, 100);
            Console.WriteLine($"\nAmong {a} and {b} {LessValue(a, b)} is less.\n");

            // Task 10
            a = new Random().Next(1, 100); b = new Random().Next(1, 100);
            Console.WriteLine(a); Console.WriteLine(b);
            if (a>b)
            {
                Console.WriteLine($"{a}, {b}");
            }
            else
            {
                Console.WriteLine($"{b}, {a}");
            }

            // Task 11
            Random rnd = new Random();
            a = rnd.Next(1, 100);
            b = rnd.Next(1, 100);
            int c = rnd.Next(1, 100);
            Console.WriteLine($"\na = {a}, b = {b}, c = {c}.");
            int largest = Math.Max(a, Math.Max(b, c));
            int secondLargest;

            if (a != largest)
            {
                secondLargest = Math.Max(a, b);
            }
            else
            {
                secondLargest = Math.Max(b, c);
            }
            Console.WriteLine($"Sum = {largest+secondLargest}.\n");

            // Task 12
            double[] array = { 1, 2, 3, 4, 5 };

            // a) double up
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
            PrintArray(array);

            // b) reduce by A
            int A = 5;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= A;
            }
            PrintArray(array);

            // c) divide by first element
            double firstElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] /= firstElement;
            }
            PrintArray(array);


        }

        static string ToEUR(double uah)
        {
            double res = uah / 41;

            return res.ToString("N2");
        }

        static double FromEUR(double eur)
        {
            double res = eur * 41;

            return res;
        }

        static string ToUSD(double uah)
        {
            double res = uah / 37;

            return res.ToString("N2"); ;
        }

        static double FromUSD(double usd)
        {
            double res = usd * 37;

            return res;
        }

        static void SwapValues(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;   
        }

        static void FormatTime(double seconds)
        {
            double minutes, hours;
            int days;
            minutes = seconds / 60;
            hours = minutes / 60;
            days = Convert.ToInt32(hours) / 24;

            Console.WriteLine($"\nSeconds(by user): {seconds}.\nMinutes: {minutes:F2}.\nHours: {hours:F2}.\nDays:{days}");
        }

        static string LessValue(double value1, double value2)
        {
            return value1 < value2 ? "first" : "second";
        }

        static void PrintArray(double[] arr)
        {
            foreach (double i in arr)
            {
                if (i % 1 != 0) // з десятковим дробом
                    Console.Write(i.ToString("N2") + " ");
                else
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}