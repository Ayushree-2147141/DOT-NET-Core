using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Shape
    {
        protected Location c;

        public string ToString()
        {
            return string.Empty;
        }

        public double Area()
        {
            return 0.000;
        }

        public double Perimeter()
        {
            return 0.000;
        }
    }

    public class Location
    {
        private double x, y;
    }

    public class Rectangle : Shape
    {
        protected double side1, side2;
    }

    public class Circle : Shape
    {
        protected double radius;
    }

    internal class Task1
    {
    }
}
