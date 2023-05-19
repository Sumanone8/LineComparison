using System;

namespace LineComparison
{
    class Line
    {
        private double x1, y1, x2, y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double CalculateLength()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public bool Equals(Line other)
        {
            return (this.x1 == other.x1 && this.y1 == other.y1 && this.x2 == other.x2 && this.y2 == other.y2);
        }

        public int CompareTo(Line other)
        {
            double thisLength = CalculateLength();
            double otherLength = other.CalculateLength();
            return thisLength.CompareTo(otherLength);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating line 1
            Console.WriteLine("Enter the coordinates of Line 1 (x1 y1 x2 y2):");
            string[] line1Coords = Console.ReadLine().Split(' ');
            double x1 = double.Parse(line1Coords[0]);
            double y1 = double.Parse(line1Coords[1]);
            double x2 = double.Parse(line1Coords[2]);
            double y2 = double.Parse(line1Coords[3]);
            Line line1 = new Line(x1, y1, x2, y2);

            // Creating line 2
            Console.WriteLine("Enter the coordinates of Line 2 (x1 y1 x2 y2):");
            string[] line2Coords = Console.ReadLine().Split(' ');
            x1 = double.Parse(line2Coords[0]);
            y1 = double.Parse(line2Coords[1]);
            x2 = double.Parse(line2Coords[2]);
            y2 = double.Parse(line2Coords[3]);
            Line line2 = new Line(x1, y1, x2, y2);

            // Calculate and display length of line 1
            double length1 = line1.CalculateLength();
            Console.WriteLine("Length of Line 1: " + length1);

            // Calculate and display length of line 2
            double length2 = line2.CalculateLength();
            Console.WriteLine("Length of Line 2: " + length2);

            // Check equality of lines
            bool isEqual = line1.Equals(line2);
            if (isEqual)
            {
                Console.WriteLine("Line 1 is equal to Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is not equal to Line 2");
            }

            // Compare lines
            int comparisonResult = line1.CompareTo(line2);
            if (comparisonResult > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2 in length");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine("Line 1 is less than Line 2 in length");
            }
            else
            {
                Console.WriteLine("Line 1 is equal to Line 2 in length");
            }
        }
    }
}

