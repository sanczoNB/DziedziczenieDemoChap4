using System;
using System.Collections.Generic;
using DziedziczenieDemo.Figures;

namespace DziedziczenieDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>()
            {
                new Circle(),
                new Triangle(),
                new Rectangle(),
                new Square()
            };
            foreach (var figure in figures)
            {
                Console.WriteLine("Figura {0} ma {1} wierzchołków.", figure.GetType().Name, figure.HowManyVertexs());
            }

            Console.ReadKey();
        }
    }
}
