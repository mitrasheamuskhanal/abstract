// C# program to calculate the area
// of a square using the concept of
// data abstraction
using System;

namespace Demoabstraction
{

    // abstract class
    abstract class Shape
    {

        // abstract method
        public abstract int area(int l , int b);
        public abstract int perimeter(int l , int b);
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
            return 2*(l+b);
        }

        // private data member
        private int side;

        // method of square class
        public Square(int x = 0)
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }

    // Driver Class
    class GFG
    {

        // Main Method
        static void Main(string[] args)
        {

            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(4);

            // calling the method
            double result = sh.area();

            Console.Write("{0}", result);

        }
    }
}