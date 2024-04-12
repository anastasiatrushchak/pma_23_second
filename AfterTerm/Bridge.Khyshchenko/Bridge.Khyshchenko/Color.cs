// Абстрактний клас для колірних реалізацій
interface IColor
{
    string Fill();
}

// Клас для червоного кольору
class RedColor : IColor
{
    public string Fill()
    {
        return "Червоний";
    }
}

// Клас для синього кольору
class BlueColor : IColor
{
    public string Fill()
    {
        return "Синiй";
    }
}