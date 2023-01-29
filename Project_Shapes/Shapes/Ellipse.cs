using System;

namespace Project_Shapes
{
    public class Ellipse : GenericShape
    {
        public float R1 { get; set; }
        public float R2 { get; set; }
        public float Orientation { get; set; }

        public Ellipse()
        {
            R1 = 0;
            R2 = 0;
            Orientation = 0;
        }

        public Ellipse(int ID, float centerX, float centerY, float r1, float r2) : base(ID, centerX, centerY)
        {
            this.R1 = r1;
            this.R2 = r2;
        }

        public override float GetArea()
        {
            return MathF.PI * R1 * R2;
        }

        //Can't believe I got this on first try. :D
        public override float GetPerimeter()
        {
            float a_m_b = R1 - R2;              //a-b
            float a_m_b_s = a_m_b * a_m_b;      //(a-b)^2
            float a_p_b = R1 + R2;              // a+b
            float a_p_b_s = a_p_b * a_p_b;      //(a+b)^2
            float ambs_d_apbs = a_m_b_s / a_p_b_s;      // (a-b)^2 / (a+b)^2

            float baseUnderRootEquation = -3 * ambs_d_apbs + 4;
            float baseRootEquation = MathF.Sqrt(baseUnderRootEquation);
            float denominator = a_p_b_s * (baseRootEquation + 10);

            return (R1 + R2) * MathF.PI * ( (3 * a_m_b_s / denominator) +1);
        }

        public override void Print()
        {
            Console.WriteLine("Elipse:");
            base.Print();
            Console.Write(" | R1: " + R1.ToString());
            Console.Write(" | R2: " + R2.ToString());
            Console.WriteLine(" | Orientation: " + Orientation.ToString());
        }
    }
}
