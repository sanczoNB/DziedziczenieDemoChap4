namespace DziedziczenieDemo.Figures
{
    public abstract class Figure
    {
        public abstract int HowManyVertexs();

        public virtual int VertexsNumber { get { return HowManyVertexs(); } }
    }
}
