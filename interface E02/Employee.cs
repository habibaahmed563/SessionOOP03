using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03.interface_E02
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public object Clone()
        {
            return new Employee() { Id = this.Id, Name = this.Name, Age = this.Age, Salary = this.Salary };
        }

        public override string ToString()
        {
            return $"is : {Id} , name: {Name} , age : {Age} , salary : {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee)obj;

            //if (this.Age > e.Age) return 312;
            //else if (this.Age < e.Age) return -312;
            //else return 0;

            return this.Age.CompareTo(e.Age);
        }
    }
}
