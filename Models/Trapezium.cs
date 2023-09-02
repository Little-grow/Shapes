namespace Shapes.Models
{
    public class Trapezium : IAreaCalculatable
    {
        public double a { get; set; }
        public double b { get; set; }
        public double Height { get; set; }


        public double CalculateArea()
        {
            return ((a + b) * Height) * .5;
        }

    }

}

