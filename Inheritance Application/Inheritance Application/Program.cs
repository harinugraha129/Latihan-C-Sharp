using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Application
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;

    }

    public interface PaintCost
    {
        int getCost(int area);
    }

    class Rectangle : Shape,PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;
            Rect.setWidth(5);
            Rect.setHight(7);
            area = Rect.getArea();
            Console.WriteLine("Total Area : " + Rect.getArea());
            Console.WriteLine("Total Paint Cost : " + Rect.getCost(area));
            Console.ReadKey();
        }
    }
}
