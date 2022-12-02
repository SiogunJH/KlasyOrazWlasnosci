using System;

namespace KlasyProperties
{
    public class Triangle
    {
        //PROPETRIES
        public double A { get; }
        public double B { get; }
        public double C { get; }

        //CONSTRUCTOR #1
        public Triangle()
        {
            this.A = 1;
            this.B = 1;
            this.C = 1;
        }

        //CONSTRUCTOR #2
        public Triangle(double a, double b, double c)
        {
            //Check for negative values
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Length cannot be zero or negative");
            }

            //Check for bad arguments
            if (a + b <= c || a + c <= b || c + b <= a)
            {
                throw new ArgumentException("Cannot create a triangle with inserted data");
            }

            this.A = Math.Round(a, 1);
            this.B = Math.Round(b, 1);
            this.C = Math.Round(c, 1);
        }

        //FUNCTIONS

        //Display all sides of a triangle
        public override string ToString()
        {
            return String.Format("[{0};{1};{2}]", this.A, this.B, this.C);
        }

        //Return the circuit length of a triangle
        public double Circuit => (A + B + C);

        //Return the area of a triangle
        public double Area
        {
            get
            {
                double p = Circuit / 2;
                return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 1);
            }
        }

        //Define new variable type
        public enum TriangleType { One, Two, Three };
        public TriangleType DetrmineTriangleType()
        {
            throw new NotImplementedException();
        }
    }
}