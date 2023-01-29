using System.Collections.Generic;
using System.Text;

namespace Project_Shapes
{
    public class ShapeData
    {
        //It could easily hold list of ShapeBase and that list could hold all the different shapes.
        //but if we know that there won't be new shapes, it's easier to have them separately.
        public IList<Circle> Circles { get; set; }

        public string GetAreaAndPerimiterString()
        {
            StringBuilder outputString = new StringBuilder();

            outputString.Append("Id,Area,Perimeter\n");

            foreach (var shape in Circles)
            {
                outputString.Append(shape.Id.ToString() + ", ");
                outputString.Append(shape.GetArea().ToString() + ", ");
                outputString.Append(shape.GetPerimeter().ToString() + "\n");
            }
            return outputString.ToString();
        }
    }
}
