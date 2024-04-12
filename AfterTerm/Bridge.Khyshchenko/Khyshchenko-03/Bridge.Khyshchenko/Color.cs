// Абстрактний клас для колірних реалізацій
interface IColor
{
    string Fill();
}

// Конкретний клас для червоного кольору
class RedColor : IColor
{
    public string Fill()
    {
        return "Red color";
    }
}

// Конкретний клас для синього кольору
class BlueColor : IColor
{
    public string Fill()
    {
        return "Blue color";
    }
}
