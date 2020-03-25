using System;

namespace IDEuse
{
    public class Square
    {
        private Point A { get; }
        private Point B { get; }
        private Point C { get; }
        private Point D { get; }

        private double side => Point.getDistance(A, B);
        
        public Square(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        
        public double getPerimeter() => 4.0 * side;
        
        public double getSquare() => side * side;
        
        public double getDiagonal() => Point.getDistance(A, C);
        
        public double circleRadius() => Math.Sqrt(2 * side*side)/2;
    }
}