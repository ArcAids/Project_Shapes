using System;

namespace Project_Shapes
{
    public class EquilateralTriangle : GenericShape
    {
        public float SideLength { get; set; }
        public float Orientation { get; set; }

        public EquilateralTriangle()
        {
            SideLength = 0;
            Orientation = 0;
        }

        public EquilateralTriangle(int ID, float centerX, float centerY, float side) : base(ID, centerX, centerY)
        {
            this.SideLength = side;
        }

        public override float GetArea()
        {
            return 0.43301270189f * SideLength * SideLength;
        }

        public override float GetPerimeter()
        {
            return 3 * SideLength;
        }

        public override void Print()
        {
            Console.WriteLine("EquilateralTriangle:");
            base.Print();
            Console.Write(" | SideLength: " + SideLength.ToString());
            Console.WriteLine(" | Orientation: " + Orientation.ToString());
        }
    }
}
