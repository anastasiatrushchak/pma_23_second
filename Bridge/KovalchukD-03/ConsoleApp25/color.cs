namespace Shapes
{
    public interface Color
    {
        string Fill();
    }

    public class CustomColor : Color 
    {
        private string colorName;

        public CustomColor(string name)
        {
            colorName = name;
        }

        public string Fill()
        {
            return colorName;
        }
    }
}
