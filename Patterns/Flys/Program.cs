using Patterns.Mediator;

namespace Patterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Builder pattern
            Console.WriteLine("\n=============================\n");
            Console.WriteLine("Builder pattern");
            Console.WriteLine("\n=============================\n");
            var director = new Builder.ComputerBuilderDirector();    
            var gamingComputer = director.BuildGamingComputer();
            Console.WriteLine("Gaming computer: " + gamingComputer);
            var officeComputer = director.BuildOfficeComputer();
            Console.WriteLine("Office computer: " + officeComputer);
            var builder = new Builder.ComputerBuilder()
            .WithCPU("Intel i9 11900K")
            .WithGPU("Nvidia RTX 4090")
            .WithRAM("64GB")
            .WithSSD("2TB")
            .WithOS("Windows 11")
            .BuildComputer();
            Console.WriteLine("Custom computer: " + builder);
            Console.WriteLine("\n=============================\n");
            // Decorator pattern
            Console.WriteLine("Decorator pattern");
            Console.WriteLine("\n=============================\n");
            var coffee = new Decorator.Coffee();
            Console.WriteLine(coffee);
            var coffeeWithMilk = new Decorator.MilkDecorator(coffee);
            Console.WriteLine(coffeeWithMilk);
            var coffeeWithMilkAndSugar = new Decorator.SugarDecorator(coffeeWithMilk);
            Console.WriteLine(coffeeWithMilkAndSugar);
            Console.WriteLine("\n=============================\n");
            // Mediator pattern
            Console.WriteLine("Mediator pattern");
            Console.WriteLine("\n=============================\n");
            var chat = new Mediator.ChatMediator();
            Student sasha = new Student(chat, "Sasha");
            Student maksym = new Student(chat, "Maksym");
            Student yura = new Student(chat, "Yura");
            Student rostyslav = new Student(chat, "Rostyslav");
            Student lev = new Student(chat, "Lev");
            chat.AddUser(sasha);
            chat.AddUser(maksym);
            chat.AddUser(yura);
            chat.AddUser(rostyslav);
            chat.AddUser(lev);
            sasha.Send("Hello, everyone!");

        }
    }
}
