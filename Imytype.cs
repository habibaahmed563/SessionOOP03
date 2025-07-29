using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03
{
    internal interface Imytype
    {
        //what can write inside the interface : 
        //1. signature of properties 
        //2. signature of methods [name , parameter ,return type]
        //3. default implmented methods [fully implemented methods]

        //2. signature of methods [name , parameter ,return type]
        void Mytype();

        //1. signature of properties 
        double salary { get; set; }

        //3. default implmented methods [fully implemented methods]
        void print()
        {
            Console.WriteLine("default implmented methods [fully implemented methods]");
        }

    }
}
