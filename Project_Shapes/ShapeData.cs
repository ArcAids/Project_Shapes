using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Shapes
{
    public abstract class ShapeBase
    {
        //variables could be private set but JSon.Serializer needs them to be public.
        //To make it private, I could make another public temporary class to read json to then copy the data to more secured class.
        

        public int Id { get; set; }

        public ShapeBase(int ID=0)
        {
            this.Id = ID;
        }

        public abstract float GetArea();
        public abstract float GetPerimeter();

        public virtual void Print()
        {
            Console.Write("ID: " + Id.ToString());
        }
    }

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


    public class ShapeData
    {
        public List<Circle> Circles { get; set; }
    }
}
