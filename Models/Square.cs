using Shapes.Models;

namespace Shapes.Models
{
    public class Square : IAreaCalculatable
    {
        public double Height { get; set; }

        
        public double CalculateArea()
        {
            return Math.Pow(Height, 2);
        }
    }
}

