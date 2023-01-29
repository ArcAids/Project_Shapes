using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Shapes;

namespace ShapesTests
{
    [TestClass]
    public class ShapesTest
    {
        [TestMethod]
        public void SquareTest()
        {
            float sideLength = 5;
            float area = 25;
            float peri = 20;

            Square square = new Square(0, 0, 0, sideLength);

            Assert.AreEqual(area, square.GetArea(), 0, "No way! Area of square is wrong.");
            Assert.AreEqual(peri, square.GetPerimeter(), 0, "No way! Perimeter of square is wrong.");
        }


        [TestMethod]
        public void EllipseTest()
        {
            float R1 = 1;
            float R2 = 2;
            float Orientation = 0;
            float area = 6.28319f;
            float peri = 9.68845f;

            Ellipse elli = new Ellipse(0, 0, 0, R1,R2);

            Assert.AreEqual(area, elli.GetArea(), 0.01f, "Ellipse area is wrong.");
            Assert.AreEqual(peri, elli.GetPerimeter(), 0.01f, "Ellipse perimeter is wrong.");
        }



    }
}
