using System;

public class Fibonacci
{
    private int[] fibSequence;
    private int steps = 0;
    private int lastFibonacci = 0; // Змінна для зберігання останнього значення

    public int[] GenerateFibonacciWithLimit(int limit, int firstNum, int secondNum)
    {
        steps = 0; // Скидаємо кількість кроків перед новим викликом
        fibSequence = new int[CalculateSequenceLength(limit, firstNum, secondNum)];
        GenerateFibonacciRecursive(limit, firstNum, secondNum);
        return fibSequence;
    }

    public int[] GenerateFibonacciWithSteps(int numSteps, int firstNum, int secondNum)
    {
        steps = 0; // Скидаємо кількість кроків перед новим викликом
        fibSequence = new int[numSteps];
        GenerateFibonacciRecursiveWithSteps(numSteps, firstNum, secondNum);
        return fibSequence;
    }

    private void GenerateFibonacciRecursive(int limit, int firstNum, int secondNum)
    {
        if (firstNum <= limit)
        {
            fibSequence[steps] = firstNum;
            steps++;
            lastFibonacci = firstNum; // Оновлюємо lastFibonacci тільки, якщо поточне число не перевищує ліміт
        }

        if (firstNum + secondNum <= limit)
            GenerateFibonacciRecursive(limit, secondNum, firstNum + secondNum);
    }


    private void GenerateFibonacciRecursiveWithSteps(int numSteps, int firstNum, int secondNum)
    {
        if (steps >= numSteps)
            return;

        fibSequence[steps] = firstNum;
        lastFibonacci = firstNum; // Зберігаємо останнє значення
        steps++;

        GenerateFibonacciRecursiveWithSteps(numSteps, secondNum, firstNum + secondNum);
    }

    private int CalculateSequenceLength(int limit, int firstNum, int secondNum)
    {
        int length = 0;
        int a = firstNum;
        int b = secondNum;

        while (a <= limit)
        {
            length++;
            int temp = b;
            b = a + b;
            a = temp;
        }

        return length;
    }

    public int GetSteps()
    {
        return steps;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int limit = 108;
        int firstNum = 0;
        int secondNum = 1;

        Fibonacci fib = new Fibonacci();

        int[] fibSequenceWithLimit = fib.GenerateFibonacciWithLimit(limit, firstNum, secondNum);
        Console.WriteLine("Fibonacci string with limited: " + string.Join(" ", fibSequenceWithLimit));

        int stepsWithLimit = fib.GetSteps();
        Console.WriteLine("Steps with limited: " + (stepsWithLimit - 1));

        int numSteps = 12;
        int[] fibSequenceWithSteps = fib.GenerateFibonacciWithSteps(numSteps, firstNum, secondNum);
        Console.WriteLine("Fibonacci string with limited number steps: " + string.Join(" ", fibSequenceWithSteps));

        int stepsWithSteps = fib.GetSteps(); // Отримуємо кількість кроків для другого варіанту
        Console.WriteLine("Steps with number steps: " + (stepsWithSteps - 2));
    }
}
