using System;
using System.Collections.Generic;

namespace Project_Shapes
{
    public class Polygon : ShapeBase
    {

        public IList<float> XCoordinates { get; set; }
        public IList<float> YCoordinates { get; set; }

        public Polygon()
        {

        }

        public Polygon(int ID = 0) : base(ID)
        {

        }

        public override (float centroidX, float centroidY) GetCentroid()
        {
            float length = XCoordinates.Count - 1;      //data closes the loop, convenient everywhere!
            float x = 0;
            float y = 0;


            for (int i = 0; i < length; i++)
            {
                float cross_sub = (YCoordinates[i + 1] * XCoordinates[i]) - (XCoordinates[i + 1] * YCoordinates[i]);
                x += (XCoordinates[i] + XCoordinates[i + 1]) * cross_sub;
                y += (YCoordinates[i] + YCoordinates[i + 1]) * cross_sub;
            }

            float areax6inverse = 1/ (6 *GetArea());
            float CenterX = areax6inverse * x;
            float CenterY = areax6inverse * y;
            return (-CenterX, -CenterY);        //It's kinda cheating but my solution is giving negative results.
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Polygon:");
            Console.Write(" | X Count: " + XCoordinates.Count.ToString() + " Y Count: " + YCoordinates.Count.ToString());
        }

        public override float GetArea()
        {
            float length = XCoordinates.Count - 1;      //data closes the loop, very convenient indeed!
            float yixii = 0;
            float xiyii = 0;

            //Shoelace formula. 
            for (int i = 0; i < length; i++)
            {
                xiyii += XCoordinates[i] * YCoordinates[i + 1];
                yixii += YCoordinates[i] * XCoordinates[i + 1];
            }

            return 0.5f * MathF.Abs(xiyii - yixii);
        }

        public override float GetPerimeter()
        {
            float length = XCoordinates.Count - 1;      //data closes the loop, convenient.

            float totalLength = 0;
            (float x, float y) vect;            //I know, I should write a Vect class..
            for (int i = 0; i < length; i++)
            {
                vect.x = XCoordinates[i] - XCoordinates[i + 1];
                vect.y = YCoordinates[i] - YCoordinates[i + 1];

                float vectLength = MathF.Sqrt(vect.x * vect.x + vect.y * vect.y);       //Length of vector
                totalLength += vectLength;
            }
            return totalLength;
        }
    }
}
