using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03
{
    internal class Rectangle : IRectangle
    {
        public double Length { get;set; }

        public double Width { get; set; }
      
        public double Area => Length * Width;

        double IShape.Area { get ; set ; }
        public Rectangle (double length , double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayShapeinfo()
        {
            Console.WriteLine($"Rectangle : length = {Length},Width = {Width},Area :{Area}");
        }
    }
}
