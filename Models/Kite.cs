namespace Shapes.Models
{
    public class Kite : IAreaCalculatable
    {
        public double Length { get; set; }
        public double Height { get; set; }


        public double CalculateArea()
        {
            return Length * Height * .5;
        }

    }

}

