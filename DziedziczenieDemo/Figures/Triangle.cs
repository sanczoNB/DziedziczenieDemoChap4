namespace DziedziczenieDemo.Figures
{
    public class Triangle : Figure
    {
        public override int HowManyVertexs()
        {
            return 3;
        }

        public override int VertexsNumber { get { return HowManyVertexs(); } }
    }
}
