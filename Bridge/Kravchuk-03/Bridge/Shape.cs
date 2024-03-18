using System;
namespace Bridge
{

    abstract class Shape
    {
        protected MyColor color;

        public Shape(MyColor color)
        {
            this.color = color;
        }

        public abstract void Create();
        public abstract double Area();
        public abstract double Per();
    }
    class Rectangle : Shape
    {
        private double len;
        private double wigh;

        public Rectangle(double len, double wigh, MyColor color) : base(color)
        {
            if (len < 0 || wigh < 0)
                throw new ArgumentException("Dimensions cannot be negative");

            this.len = len;
            this.wigh = wigh;
        }

        public override void Create()
        {
            Console.WriteLine($"Create Rectangle in {color.Filling()} color ");
        }

        public override double Area()
        {
            return len * wigh;
        }

        public override double Per()
        {
            return 2 * (len + wigh);
        }
    }

    class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC, MyColor color) : base(color)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
                throw new ArgumentException("Dimensions cannot be negative");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override void Create()
        {
            Console.WriteLine($"Create Triangle in {color.Filling()} color");
        }

        public override double Area()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public override double Per()
        {
            return sideA + sideB + sideC;
        }
    }

    class Square : Shape
    {
        private double sideD;

        public Square(double sideD, MyColor color) : base(color)
        {
            if (sideD < 0)
                throw new ArgumentException("Side length cannot be negative");

            this.sideD = sideD;
        }

        public override void Create()
        {
            Console.WriteLine($"Create Square in {color.Filling()} color");
        }

        public override double Area()
        {
            return sideD * sideD;
        }

        public override double Per()
        {
            return sideD * 4;
        }
    }

    class Round : Shape
    {
        private double r;

        public Round(double r, MyColor color) : base(color)
        {
            if (r < 0)
                throw new ArgumentException("Radius cannot be negative");

            this.r = r;
        }

        public override void Create()
        {
            Console.WriteLine($"Create Round in {color.Filling()} color");
        }

        public override double Area()
        {
            return Math.PI * r * r;
        }

        public override double Per()
        {
            return 2 * Math.PI * r;
        }
    }

}

