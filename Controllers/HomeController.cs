using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Shapes.Models;
using Shapes.Models.ViewModel;
using System.Diagnostics;
using System.Reflection;

namespace Shapes.Controllers
{
    public class HomeController : Controller
    {
        private void Handling2D(ShapeCalculationModel model)
        {
            IAreaCalculatable? shape = null;

            if (model?.ShapeType != null)
            {
                HttpContext.Session.SetString("ShapeType", model.ShapeType);
            }
            else
            {
                if (HttpContext.Session.IsAvailable)
                {
                    model.ShapeType = HttpContext.Session.GetString("ShapeType") ?? String.Empty;
                }
            }

            switch (model.ShapeType)
            {
                case "Rectangle":
                    shape = new Rectanagle { Base = model?.Base ?? 0, Height = model?.Height ?? 0 };
                    break;
                case "Square":
                    shape = new Square { Height = model?.Height ?? 0 };
                    break;
                case "Triangle":
                    shape = new Triangle { Base = model?.Base ?? 0, PerpendicularHeight = model?.PerpendicularHight ?? 0 };
                    break;
                case "Trapezium":
                    shape = new Rectanagle { Base = model?.Base ?? 0, Height = model?.Height ?? 0 };
                    break;
                case "Parallelogram":
                    shape = new Parallelolgarm { Base = model?.Base ?? 0, PerpendicularHeight = model?.PerpendicularHight ?? 0 };
                    break;
                case "Rhombus":
                    shape = new Rhombus { Length = model?.Length ?? 0, Height = model?.Height ?? 0 };
                    break;
                case "Kite":
                    shape = new Kite { Length = model?.Length ?? 0, Height = model?.Height ?? 0 };
                    break;
                default:
                    break;
            }

            if (shape != null)
            {
                double result = shape.CalculateArea();
                ViewBag.Result = result;
            }
        }
        private void Handling3D(ShapeCalculationModel model)
        {

            IVolumeCalculatable? shape3D = null;

            switch (model.ShapeType)
            {
                // Define cases for 3D shapes and their parameters here
            }

            if (shape3D != null)
            {
                double result = shape3D.CalculateVolume();
                ViewBag.Result = result;
            }
        }

        [HttpGet]
        public ActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(ShapeCalculationModel model)
        {
            if (model.Is2D)
            {
                Handling2D(model);
            }
            else
            {
                Handling3D(model);
            }
            return View(model);
        }

        public ActionResult RenderPartialView(string partialViewName)
        {
            return PartialView(partialViewName);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}