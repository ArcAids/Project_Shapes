using System;

namespace Project_Shapes
{
    public abstract class GenericShape : ShapeBase
    {

        public float CenterX { get; set; }
        public float CenterY { get; set; }
        public GenericShape()
        {

        }

        public GenericShape(int ID=0, float centerX=0, float centerY=0) : base(ID)
        {
            this.CenterX = centerX;
            this.CenterY = centerY;
        }

        public override void Print()
        {
            base.Print();
            Console.Write(" | Center - X: " + CenterX.ToString() + " Y: " + CenterY.ToString());
        }
    }
}
