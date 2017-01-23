namespace DziedziczenieDemo
{
    public class Address
    {
            public string City;
            public string Street;
            public int HouseNumber;
            public int? ApartmentNumber;

            public override string ToString()
            {
                return $"{City}, ul. {Street} {HouseNumber}{(ApartmentNumber.HasValue ? "/" + ApartmentNumber.ToString() :"" )}";
            }
    }
}
