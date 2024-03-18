using System;
namespace Bridge
{
    abstract class MyColor
    {
        public abstract string Filling();
    }
    class Pink : MyColor
    {
        public override string Filling()
        {
            return "Pink";
        }
    }

    class Purple : MyColor
    {
        public override string Filling()
        {
            return "Purple";
        }
    }

    class Black : MyColor
    {
        public override string Filling()
        {
            return "Black";
        }
    }
}
