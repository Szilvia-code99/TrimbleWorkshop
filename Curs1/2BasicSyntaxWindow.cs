using System;

namespace Curs1
{
    // class keyword used for declaration
    class BasicSyntaxWindow
    {
        // member variables used for storing data
        int height;
        int width;

        // member function
        public void SetDimensions()
        {
            height = 3;
            width = 2;
        }

        // member function
        public int GetWindowArea()
        {
            return height * width;
        }

        // member function
        public void Display()
        {
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {GetWindowArea()}");
        }
    }
}
