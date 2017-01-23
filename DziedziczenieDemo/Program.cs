using System;

namespace DziedziczenieDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var jk = new ChekInPerson
            {
                Name = "Jan",
                Surname = "Kowalski",
                Age = 42,
                ChekInAddress = new Address
                {
                    City = "Toruń",
                    Street = "Grudziądzka",
                    HouseNumber = 5,
                    ApartmentNumber = 7
                }
            };

            Console.WriteLine(jk.ToString());

            Person jkp = jk;
            Console.WriteLine(jkp.ToString());
            Console.ReadKey();
        }
    }
}
