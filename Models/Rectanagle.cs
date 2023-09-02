namespace Shapes.Models
{
    public class Rectanagle : IAreaCalculatable
    {
        public double Base { get; set; }
        public double Height { get; set; }


        public double CalculateArea()
        {
            return Base * Height;
        }

    }
}
