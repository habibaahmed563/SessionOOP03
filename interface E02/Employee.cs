using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03.interface_E02
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"is : {Id} , name: {Name} , age : {Age} , salary : {Salary}";
        }
    }
}
