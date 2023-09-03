namespace Shapes.Models
{
    public class Cylinder : IVolumeCalculatable
    {
        public double Height { get; set; }
        public double CalculateVolume()
        {
            return Math.Pow(Math.PI, 2) * Height;
        }
    }
}
