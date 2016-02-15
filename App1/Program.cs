using System;

public class TaxCalculator
{
    public static void Main()
    {
        Console.WriteLine("Please enter salary: ");
        int userMoney = Convert.ToInt32(Console.ReadLine());

        if (userMoney <= 18200)
        {
            int userTax = 0;
            Console.Clear();
            Convert.ToString(userTax);
            Console.WriteLine("Salary: {0}", userMoney);
            Console.WriteLine();
            Console.WriteLine("Tax payable: {0}", userTax);
            Console.WriteLine();
            Console.WriteLine("To start again press Y or to quit press Q");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }

            else if (info.Key == ConsoleKey.Q)
            {
                return;
            }

        }
        else if (userMoney >= 18201 && userMoney <= 37000)
        {
            double userTax = (userMoney * 19) / 100;
            Convert.ToString(userTax);
            Console.Clear();
            Convert.ToString(userTax);
            Console.WriteLine("Salary: {0}", userMoney);
            Console.WriteLine();
            Console.WriteLine("Tax payable: {0}", userTax);
            Console.WriteLine();
            Console.WriteLine("To start again press Y or to quit press Q");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }

            else if (info.Key == ConsoleKey.Q)
            {
                return;
            }
        }
        else if (userMoney >= 37001 && userMoney <= 80000)
        {
            int defaultAmount = 3572;
            double a = userMoney - 37001;
            double b = .325;
            double c = a * b;
            double userTax = defaultAmount + c;
            Convert.ToString(userTax);
            Console.Clear();
            Convert.ToString(userTax);
            Console.WriteLine("Salary: {0}", userMoney);
            Console.WriteLine();
            Console.WriteLine("Tax payable: {0}", userTax);
            Console.WriteLine();
            Console.WriteLine("To start again press Y or to quit press Q");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }

            else if (info.Key == ConsoleKey.Q)
            {
                return;
            }
        }
        else if (userMoney >= 80001 && userMoney <= 180000)
        {
            int defaultAmount = 17547;
            double a = userMoney - 80001;
            double b = .37;
            double c = a * b;
            double userTax = defaultAmount + c;
            Convert.ToString(userTax);
            Convert.ToString(userTax);
            Console.Clear();
            Convert.ToString(userTax);
            Console.WriteLine("Salary: {0}", userMoney);
            Console.WriteLine();
            Console.WriteLine("Tax payable: {0}", userTax);
            Console.WriteLine();
            Console.WriteLine("To start again press Y or to quit press Q");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }

            else if (info.Key == ConsoleKey.Q)
            {
                return;
            }

        }
        else
        {
            int defaultAmount = 54547;
            double a = userMoney - 180001;
            double b = .45;
            double c = a * b;
            double userTax = defaultAmount + c;
            Convert.ToString(userTax);
            Convert.ToString(userTax);
            Console.Clear();
            Convert.ToString(userTax);
            Console.WriteLine("Salary: {0}", userMoney);
            Console.WriteLine();
            Console.WriteLine("Tax payable: {0}", userTax);
            Console.WriteLine();
            Console.WriteLine("To start again press Y or to quit press Q");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }

            else if (info.Key == ConsoleKey.Q)
            {
                return;
            }
        }
    }
}