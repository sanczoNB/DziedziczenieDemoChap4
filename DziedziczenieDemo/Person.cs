
namespace DziedziczenieDemo
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public override string ToString()
        {
            return $"{Name} {Surname} ({Age})";
        }

        private string Personalia => $"{Name} {Surname}";
    }
}
