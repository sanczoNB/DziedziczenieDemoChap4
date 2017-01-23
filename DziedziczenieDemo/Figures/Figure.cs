using System;

namespace DziedziczenieDemo.Figures
{
    public abstract class Figure
    {
        public abstract int HowManyVertexs();

        protected Figure()
        {
            Console.WriteLine("Konstruktor klasy Figura");
        }

        protected Figure(string argument)
        {
            Console.WriteLine("Konstruktor klasy Figura, komunikat: " + argument);
        }

        public virtual int VertexsNumber { get { return HowManyVertexs(); } }
    }
}
