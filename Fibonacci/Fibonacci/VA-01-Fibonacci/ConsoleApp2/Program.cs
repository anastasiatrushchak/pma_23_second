namespace Fibonacci_algorithm
{
    class Class1
    {
        public static void Main()
        {
            using (StreamReader sr = File.OpenText("/Users/nasta/RiderProjects/ConsoleApp2/ConsoleApp2/limit.txt"))
            {
                double first = double.Parse(sr.ReadLine());
                double second = double.Parse(sr.ReadLine());
                double limit = double.Parse(sr.ReadLine());
                Sequence sequence1 = Service.CalculateSequenceByLimit(new Sequence(first, second), limit);
                Console.WriteLine($"Межа: {limit}");
                Console.WriteLine($"Послідовність: {string.Join(", ", sequence1.numbers)}");
                Console.WriteLine($"Кількість кроків: {sequence1.Steps}");
            }
            using (StreamReader sr = File.OpenText("/Users/nasta/RiderProjects/ConsoleApp2/ConsoleApp2/steps.txt"))
            {
                double first = double.Parse(sr.ReadLine());
                double second = double.Parse(sr.ReadLine());
                int steps = int.Parse(sr.ReadLine());
                Sequence sequence1 = Service.CalculateSequenceBySteps(new Sequence(first, second), steps);
                Console.WriteLine($"Послідовність2: {string.Join(", ", sequence1.numbers)}");
                Console.WriteLine($"Кількість кроків: {steps}");
            }
        }
        
    }
}