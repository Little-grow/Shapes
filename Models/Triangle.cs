namespace Shapes.Models
{
    public class Triangle : IAreaCalculatable
    {
        public double Base { get; set; }
        public double PerpendicularHeight { get; set; }


        public double CalculateArea()
        {
            return Base * PerpendicularHeight * .5;
        }

    }

}

