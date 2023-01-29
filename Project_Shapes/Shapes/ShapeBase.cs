using System;

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
}
