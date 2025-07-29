using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03
{
    internal class Mytype : Imytype  //implemente
    {
        public double salary { get; set; }


        public void Myfun()
        {
            Console.WriteLine("hello world");
        }

        void Imytype.Mytype()
        {
            throw new NotImplementedException();
        }
    }
}
