namespace DziedziczenieDemo.Figures
{
    public class Circle : Figure
    {
        public override int HowManyVertexs()
        {
            return 0;
        }

        public override int VertexNumber { get { return HowManyVertexs(); } }

        /*Nadpisane własności VertexsNumber nie mogą mieć sekcji set, ponieważ sekcja ta nie została uzwględnionia
         we własności abstralcyjnej z klasy Figure*/
         
    }
}
