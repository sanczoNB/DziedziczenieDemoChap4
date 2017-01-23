using System;

namespace DziedziczenieDemo.Figures
{
    public class Triangle : Figure
    {
        public Triangle()
        {
            Console.WriteLine("Konstruktor klasy Trójkąt");
        }

        public Triangle(string argument) : base(argument)
        {
            Console.WriteLine("Konstruktor klasy Trójkąt, komunkat: " + argument);
        }

        public override int HowManyVertexs()
        {
            return 3;
        }

        public override int VertexsNumber { get { return HowManyVertexs(); } }
    }
}
