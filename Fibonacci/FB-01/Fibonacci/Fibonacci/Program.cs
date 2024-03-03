namespace fibonachi;
class Program
{
    static void  Main(string[] args)
    {
        string filePath = @"D:\ЛНУ\2 курс 2 семестр\C#\Fibonacci\Fibonacci\input.txt";
        List<double> numbers1 = new List<double>();
        List<double> numbers2 = new List<double>();

        string line = File.ReadAllText(filePath); 
        string[] parts = line.Split(' '); 
        foreach (string part in parts)
        {
            if (double.TryParse(part, out double number))
            {
                numbers1.Add(number);
                numbers2.Add(number);
            }
        }


        int border = 200;
        Fibonacci rez_border = Service.RunBorder(numbers1, border);
        Console.WriteLine(rez_border);


        
        int step = 5;
        List<double> rez_step = Service.RunStep(numbers2, step);
        Console.WriteLine(string.Join(", ", rez_step));


    }


}