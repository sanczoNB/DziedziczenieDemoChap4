namespace DziedziczenieDemo
{
    class ChekInPerson : Person
    {
        public Address ChekInAddress;

        public override string ToString()
        {
            return $"{base.ToString()}; {ChekInAddress.ToString()}";
        }
    }
}
