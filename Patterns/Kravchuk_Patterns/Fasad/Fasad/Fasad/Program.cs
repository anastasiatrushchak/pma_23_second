using System;

class MathClass
{
    public void TeachMath()
    {
        Console.WriteLine("Teaching Math");
    }
}

class LanguageClass
{
    public void TeachLanguage()
    {
        Console.WriteLine("Teaching Language");
    }
}

class HistoryClass
{
    public void TeachHistory()
    {
        Console.WriteLine("Teaching History");
    }
}

class SchoolFacade
{
    private MathClass mathClass;
    private LanguageClass languageClass;
    private HistoryClass historyClass;

    public SchoolFacade()
    {
        mathClass = new MathClass();
        languageClass = new LanguageClass();
        historyClass = new HistoryClass();
    }

    public void TeachAllSubjects()
    {
        Console.WriteLine("Teaching all subjects...");
        mathClass.TeachMath();
        languageClass.TeachLanguage();
        historyClass.TeachHistory();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SchoolFacade schoolFacade = new SchoolFacade();

        schoolFacade.TeachAllSubjects();

        Console.ReadLine();
    }
}
