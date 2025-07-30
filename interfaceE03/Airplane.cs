using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03.interfaceE03
{
    internal class Airplane : IMoveable , IFlyable
    {
         int IMoveable.Speed { get; set; }

         void IMoveable.Backward()
        {
            Console.WriteLine("Car Imoveble Backword");
        }

         void IMoveable.Forward()
        {
            Console.WriteLine("Car Imoveble Forward");
        }

         void IMoveable.Left()
        {
            Console.WriteLine("Car Imoveble Left");
        }

         void IMoveable.Right()
        {
            Console.WriteLine("Car Imoveble Right");
        }
         int IFlyable.Speed { get; set; }

         void IFlyable.Backward()
        {
            Console.WriteLine("Car IFlyable Backword");
        }

         void IFlyable.Forward()
        {
            Console.WriteLine("Car IFlyable Forward");
        }

         void IFlyable.Left()
        {
            Console.WriteLine("Car IFlyable Left");
        }

         void IFlyable.Right()
        {
            Console.WriteLine("Car IFlyable Right");
        }
    }
}
