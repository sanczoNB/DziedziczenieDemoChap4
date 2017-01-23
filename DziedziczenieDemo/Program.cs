using System;
using System.Collections.Generic;
using DziedziczenieDemo.Figures;

namespace DziedziczenieDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Figure>()
            {
                new Circle(),
                new Triangle("Co się z tobą stanie, gdy Ci ufać przestane!!!"),
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
