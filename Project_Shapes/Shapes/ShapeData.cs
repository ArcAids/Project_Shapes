using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_Shapes
{
    public class ShapeData
    {
        //It could easily hold list of ShapeBase and that list could hold all the different shapes.
        //but if we know that there won't be new shapes, it's easier to have them separately.

        //There's also security issue here with everything being so public. but JsonSerializer needs this to be public to work.
        //I do know a solution, might end up implementing that eventually.
        public IList<Square> Squares { get; set; }
        public IList<Ellipse> Ellipses { get; set; }
        public IList<Circle> Circles { get; set; }
        public IList<EquilateralTriangle> EquilateralTriangles { get; set; }
        public IList<Polygon> Polygons { get; set; }

        public string GetAreaAndPerimiterString()
        {
            StringBuilder outputString = new StringBuilder();

            outputString.Append("Id,Area,Perimeter\n");

            AppendShapesFromList(ref outputString, Squares);
            AppendShapesFromList(ref outputString, Ellipses);
            AppendShapesFromList(ref outputString, Circles);
            AppendShapesFromList(ref outputString, EquilateralTriangles);
            AppendShapesFromList(ref outputString, Polygons);
        
            return outputString.ToString();
        }

        
        private void AppendShapesFromList<T>(ref StringBuilder outputString, in IList<T> shapes) where T : ShapeBase
        {
            Debug.Assert(shapes != null);
            foreach (var shape in shapes)
            {
                outputString.Append(shape.Id.ToString() + ", ");
                outputString.Append(shape.GetArea().ToString() + ", ");
                outputString.Append(shape.GetPerimeter().ToString()+ ", ");

                var (centeroidX, centeroidY) = shape.GetCenteroid();
                outputString.Append(centeroidX.ToString()+ ", ");
                outputString.Append(centeroidY.ToString() + "\n");
            }
        }
    }
}
