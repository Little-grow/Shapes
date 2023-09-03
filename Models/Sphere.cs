namespace Shapes.Models
{
    public class Sphere: IVolumeCalculatable
    {
        public double radius { get; set; }

        public double CalculateVolume()
        {
            return .75 * Math.PI * Math.Pow(radius, 3);
        }
    }
}
