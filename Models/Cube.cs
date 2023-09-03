namespace Shapes.Models
{
    public class Cube : IVolumeCalculatable
    {
        public double Height;
        public double CalculateVolume()
        {
            return Height * Height * Height;
        }
    }
}
