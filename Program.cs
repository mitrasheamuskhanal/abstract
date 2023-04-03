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
            return 2 * (l + b);
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
            return 2 * (l + b);
        }
    }

}
