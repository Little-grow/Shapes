namespace Shapes.Models.ViewModel
{
    public class ShapeCalculationModel
    {
        public bool Is2D { get; set; }
        public string ShapeType { get; set; }
        public double? Base { get; set; }
        public double? Height { get; set; }
        public double? PerpendicularHight { get; set; }
        public double? Length { get; set; }
    }

}
