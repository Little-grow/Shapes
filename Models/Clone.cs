namespace Shapes.Models
{
    public class Clone : IVolumeCalculatable
    {
        public double Height { get; set; }
        public double Radius { get; set; }
        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height / 3;
        }
    }
}
