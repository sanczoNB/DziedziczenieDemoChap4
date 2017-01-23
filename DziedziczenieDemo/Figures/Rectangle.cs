namespace DziedziczenieDemo.Figures
{
    public class Rectangle : Figure
    {
        public override int HowManyVertexs()
        {
            return 4;
        }

        public override int VertexNumber { get { return HowManyVertexs(); } }
    }
}
