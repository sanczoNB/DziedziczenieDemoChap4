namespace DziedziczenieDemo
{
    class ChekInPerson : Person
    {
        public Address ChekInAddress;

        public new string ToString()
        {
            return $"{base.ToString()}; {ChekInAddress.ToString()}";
        }
    }
}
