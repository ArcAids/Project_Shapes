using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Shapes
{
    public class ShapeData
    {
        //It could easily hold list of ShapeBase and that list could hold all the different shapes.
        //but if we know that there won't be new shapes, it's easier to have them separately.
        public IList<Square> Squares { get; set; }
        public IList<Ellipse> Ellipses { get; set; }
        public IList<Circle> Circles { get; set; }

        public string GetAreaAndPerimiterString()
        {
            StringBuilder outputString = new StringBuilder();

            outputString.Append("Id,Area,Perimeter\n");

            AppendShapesFromList(ref outputString, Squares);
            AppendShapesFromList(ref outputString, Ellipses);
            AppendShapesFromList(ref outputString, Circles);
        
            return outputString.ToString();
        }

        
        private void AppendShapesFromList<T>(ref StringBuilder outputString, in IList<T> shapes) where T : ShapeBase
        {
            Debug.Assert(shapes != null);
            foreach (var shape in shapes)
            {
                outputString.Append(shape.Id.ToString() + ", ");
                outputString.Append(shape.GetArea().ToString() + ", ");
                outputString.Append(shape.GetPerimeter().ToString() + "\n");
            }
        }
    }
}
