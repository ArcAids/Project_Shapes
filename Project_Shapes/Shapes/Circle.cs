using System;

namespace Project_Shapes
{
    public class Circle : GenericShape
    {
        public float Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(int ID, float centerX, float centerY, float radius) : base(ID, centerX, centerY)
        {
            this.Radius = radius;
        }

        public override float GetArea()
        {
            return MathF.PI * Radius * Radius;
        }

        public override float GetPerimeter()
        {
            return MathF.PI * 2 * Radius;
        }

        public override void Print()
        {
            Console.WriteLine("Circle:");
            base.Print();
            Console.WriteLine(" | Radius: " + Radius.ToString());
        }
    }
}
