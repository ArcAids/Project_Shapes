using System;

namespace Project_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeDataFileIOBase dataFileIO = new ShapeDataFileIOBase();
            var data = dataFileIO.ReadFile("../../../../Shapes-49464.json");

            foreach (ShapeBase circle in data.Circles)
            {
                circle.Print();
                Console.WriteLine("Area is:" + circle.GetArea().ToString());
                Console.WriteLine("Perimeter is:" + circle.GetPerimeter().ToString());
            }


        }
    }
}
