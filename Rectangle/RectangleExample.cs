using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class RectangleExample
    {
        static void Main(string[] args)
        {
            Rectangle recInstance = new Rectangle() { Top = 1, Left = 5, Width = 5,
                Height = 3 };

            Console.WriteLine(recInstance.CalcArea);
        }
    }

    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom { get; set; }
        public int Right { get; set; }



        public int CalcArea()
        {
            return Width * Height;
        }

    }
}
