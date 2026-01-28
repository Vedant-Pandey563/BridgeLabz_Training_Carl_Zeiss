using System.ComponentModel.DataAnnotations;

namespace Line
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Line
    {
        public Point Start;
        public Point End;

        public Line(Point start,Point end)
        {
            this.Start = start;
            this.End = end;
        }

        public double CalcLength()
        {
            double xLength = End.X- Start.X;
            double yLength = End.Y - Start.Y;
            double length = Math.Sqrt(Math.Pow(xLength,2) + Math.Pow(yLength,2));
            return length;
        }

        public void LengthCompare(Line Line2)
        {
            double length1 = this.CalcLength();
            double length2 = Line2.CalcLength();

            if(length1 > length2)
            {
                Console.WriteLine("Line 1 is longer than Line 2");
            }
            else if(length1 < length2)
            {
                Console.WriteLine("Line 2 is longer than Line 1");
            }
            else
            {
                Console.WriteLine("Both lines are of equal length");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Line Line1 = new Line(
                new Point(1, 2),
                new Point(3, 6));

            Line Line2 = new Line(
                new Point(5, 6),
                new Point(7, 9));

            Console.WriteLine(Line1.CalcLength());
            Console.WriteLine(Line2.CalcLength());

            Line1.LengthCompare(Line2);
        }
    }
}
