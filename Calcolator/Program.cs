using System;

class Калкулатор
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Прост калкулатор");
            Console.WriteLine("Изберете операция:");
            Console.WriteLine("1. Събиране");
            Console.WriteLine("2. Изваждане");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Изход");

            Console.Write("Въведете номер на операцията (1-5): ");
            int избор = int.Parse(Console.ReadLine());

            if (избор == 5)
            {
                Console.WriteLine("Довиждане!");
                break;
            }

            Console.Write("Въведете първо число: ");
            double число1 = double.Parse(Console.ReadLine());

            Console.Write("Въведете второ число: ");
            double число2 = double.Parse(Console.ReadLine());

            double резултат = 0;

            switch (избор)
            {
                case 1:
                    резултат = число1 + число2;
                    break;
                case 2:
                    резултат = число1 - число2;
                    break;
                case 3:
                    резултат = число1 * число2;
                    break;
                case 4:
                    if (число2 != 0)
                    {
                        резултат = число1 / число2;
                    }
                    else
                    {
                        Console.WriteLine("Грешка: деление на нула");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Грешка: невалиден избор на операция");
                    continue;
            }

            Console.WriteLine($"Резултат: {резултат}");
        }
    }
}

