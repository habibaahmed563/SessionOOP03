using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03
{
    internal class Circle : ICircle
    {
        public double Radius { get ; set ; }

        public double Area => Math.PI * Radius * Radius;

        double IShape.Area { get ; set ; }
        public Circle (double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeinfo()
        {
            Console.WriteLine($"Circle : Radius = {Radius},Area : {Area}");
        }
    }
}
