using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03.interfaceE03
{
    internal class Car : IMoveable
    {
        public int Speed { get; set ; }

        public void Backward()
        {
            Console.WriteLine("Car Imoveble Backword");
        }

        public void Forward()
        {
            Console.WriteLine("Car Imoveble Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car Imoveble Left");
        }

        public void Right()
        {
            Console.WriteLine("Car Imoveble Right");
        }
    }
}
