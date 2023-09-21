using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Shape
    {
        public void Area(int s)
        {
            int a = s * s;
            Console.WriteLine("Area : "+a);
        }

        public void Area(int x, int y) 
        {
            int a = x * y;
            Console.WriteLine("Area : "+a);
        }

        public void Perimeter(int s)
        {
            int p = 3 * s;
            Console.WriteLine("Perimeter : " + p);
        }

        public void Perimeter(int x, int y)
        {
            int p = 2 * (x + y);
            Console.WriteLine("Perimter : "+p);
        }
    }

    class Rectangle : Shape
    {
        public void Calculate()
        {
            Console.WriteLine("enter length and breadth of Rectangle : ");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());    

            Perimeter(l, b);
            Area(l,b);
        }
    }

    class Triangle : Shape
    {
        public void Calculate()
        {
            Console.WriteLine("enter side of Triangle : ");
            int s = Convert.ToInt32(Console.ReadLine());

            Perimeter(s);
            Area(s);

        }
        
    }
    internal class ShapeProgramTask
    {
        public static void Main1(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.Calculate();

            Triangle t = new Triangle();
            t.Calculate();
        }
    }
}
