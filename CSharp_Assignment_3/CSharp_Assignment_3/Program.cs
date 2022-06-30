using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_3
{
    interface shape1
    {
        double getAr();
        double getPer();
    }
    abstract class shape
    {
        public abstract float getArea();
        public abstract float getPerimeter();

    }

    //Implements shape1 interface
    class circle : shape1
    {
        static readonly double PI = 3.14;
        double radius { get; set; }

        public double getAr()
        {
            return PI * (radius * radius);
        }

        public double getPer()
        {
            return 2 * (PI * radius);
        }
    }

    //Extends the abstract class shape
    class square : shape
    {
        float side { get; set; }

        public override float getArea()
        {
            return side * side;
        }

        public override float getPerimeter()
        {
            return 4 * side;
        }
    }

    //Implemts shape1 interface
    class Triangle : shape1
    {
        float height { get; set; }
        float Base { get; set; }
        float side { get; set; }

        public double getAr()
        {
            return 0.5 * (height * Base);
        }
        public double getPer()
        {
            return height + Base + side;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            Triangle t= new Triangle();
            square s= new square();
        }
    }

}
