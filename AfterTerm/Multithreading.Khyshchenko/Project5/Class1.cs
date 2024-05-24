using System;
using System.Threading;

class Program
{
    static void Main()
    {
      
        Thread[] threads = new Thread[10];

      
        threads[0] = new Thread(Function1);
        threads[1] = new Thread(Function2);
        threads[2] = new Thread(Function3);
        threads[3] = new Thread(Function4);
        threads[4] = new Thread(Function5);
        threads[5] = new Thread(Function6);
        threads[6] = new Thread(Function7);
        threads[7] = new Thread(Function8);
        threads[8] = new Thread(Function9);
        threads[9] = new Thread(Function10);

        for (int i = 0; i < 10; i++)
        {
            threads[i].Start();
        }

        // Очікуємо завершення всіх потоків
        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("Усі потоки завершили свою роботу.");
    }

    static void Function1()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 1: Обчислення суми перших 100 чисел.");
            int sum = 0;
            for (int i = 1; i <= 100; i++) sum += i;
            Console.WriteLine($"Сума: {sum}");
        }
    }

    static void Function2()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 2: обчислення факторiала 10.");
            int factorial = 1;
            for (int i = 1; i <= 10; i++) factorial *= i;
            Console.WriteLine($"Факторiал: {factorial}");
        }
    }

    static void Function3()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 3: Друк чисел вiд 1 до 10.");
            for (int i = 1; i <= 10; i++) Console.WriteLine(i);
        }
    }

    static void Function4()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 4: Друк парних чисел вiд 1 до 20.");
            for (int i = 2; i <= 20; i += 2) Console.WriteLine(i);
        }
    }

    static void Function5()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 5: Перевертання рядка.");
            string str = "Hello, World!";
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
    }

    static void Function6()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 6: обчислення квадратiв перших 10 чисел.");
            for (int i = 1; i <= 10; i++) Console.WriteLine($"Квадрат {i}: {i * i}");
        }
    }

    static void Function7()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 7: Числа вiд 1 до 5 iз затримкою.");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500); // 0.5 
            }
        }
    }

    static void Function8()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 8: генерацiя 5 випадкових чисел.");
            Random random = new Random();
            for (int i = 0; i < 5; i++) Console.WriteLine(random.Next(1, 100));
        }
    }

    static void Function9()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 9: перевiрка чисел вiд 1 до 10 є простими.");
            for (int i = 1; i <= 10; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) isPrime = false;
                }
                Console.WriteLine($"{i} is {(isPrime ? "просте" : "складне")}");
            }
        }
    }

    static void Function10()
    {
        lock (Console.Out)
        {
            Console.WriteLine("Функцiя 10: Перетворення температури за Цельсiєм у Фаренгейт.");
            double celsius = 25.0;
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }
    }
}
