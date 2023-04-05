using System;

namespace Demoabstraction
{

    // abstract class
    abstract class Shape
    {

        // abstract method
        public abstract int area(int l, int b);
        public abstract int perimeter(int l, int b);
    }

    // square class inheriting
    // the Shape class
    class Square : Shape
    {
        // Defining 
        public override int area(int l, int b)
        {
            return l * b;
        }
        public override int perimeter(int l, int b)
        {
            return 4*l;
        }

    }
    class  rectangle :Shape
    {
        public override int area(int l, int b)
        {
            return l*b;
        }
        public override int perimeter(int l, int b)
        {
            return 2 *( l+b );
        }
    }
    public class programnew
    {
        public static void Main()
        {
            Shape shape = new Square();
            //calling methods
            int SquareArea = shape.area(10, 10);
            Console.WriteLine(SquareArea +"Square");
            int squareperimeter =shape.perimeter(10, 10);
            Console.WriteLine(squareperimeter + "m");


            Shape shape2 = new rectangle();
            int ReactangleArea = shape2.area(10, 10);
            Console.WriteLine(ReactangleArea + "square");
            int RectanglePerimeter = shape2.perimeter(10,10);
            Console.WriteLine(RectanglePerimeter);
            Console.ReadLine();

        }
    }

}
