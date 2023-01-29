﻿using System;

namespace Project_Shapes
{
    public class Square : GenericShape
    {
        public float SideLength { get; set; }
        public float Orientation { get; set; }

        public Square()
        {
            SideLength = 0;
            Orientation = 0;
        }

        public Square(int ID, float centerX, float centerY, float side) : base(ID, centerX, centerY)
        {
            this.SideLength = side;
        }

        public override float GetArea()
        {
            return SideLength * SideLength;
        }

        public override float GetPerimeter()
        {
            return 4 * SideLength;
        }

        public override void Print()
        {
            Console.WriteLine("Square:");
            base.Print();
            Console.Write(" | SideLength: " + SideLength.ToString());
            Console.WriteLine(" | Orientation: " + Orientation.ToString());
        }
    }
}
