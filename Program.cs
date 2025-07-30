using SessionOOP03.interface_E02;
using SessionOOP03.interfaceE03;
using System.Text;

namespace SessionOOP03
{

    //1. class
    //2. struct 
    //3. enum 
    //4. interface

    internal class Program
    {
        //static void print10number (SeriesByTwo series )
        //{
        //    for(int i = 0; i<10;i++)
        //    {
        //        Console.WriteLine($"{series.current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void print10number(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void print10number(SeriesbyFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        static void print10number(Iseries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.current}");
                series.Next();
            }
            Console.WriteLine();
            series.Reset();
        }
        static void Main(string[] args)
        {
            #region interface E01 

            //interfaces : reference type 
            //code contract between two developer who write it and the developer who use it [implementation]


            //Imytype mytype = new Imytype();

            // Note : can't create object from any interfaces

            //Mytype mytype = new Mytype();
            //mytype.myfun();

            Imytype mytype;
            //Ref --> can refer to object from any class which implemented the interface 'Imytype'

            mytype = new Mytype();

            mytype.salary = 12000;
            Console.WriteLine(mytype.salary);
            mytype.Mytype();
            mytype.print();
            #endregion

            #region interface E02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();

            //SeriesByThree seriesByThree = new SeriesByThree();

            //SeriesbyFour seriesByFour = new SeriesbyFour();


            //print10number(seriesByTwo);
            //print10number(seriesByThree);
            //print10number(seriesByFour);

            //int[] numbers = { 7, 6, 5, 4, 3, 2, 1, 8, 9 };

            //Array.Sort(numbers);

            //foreach(int item in numbers )
            //{
            //    Console.WriteLine($"{item}");
            //}

            Employee[] employee = new Employee[3]
            {
                new Employee(){Id = 1,Name = "Ahmed" , Age = 30 , Salary = 12000},
                new Employee(){Id = 2,Name = "Omar" , Age = 27 , Salary = 11000},
                new Employee(){Id = 3,Name = "Ali" , Age = 28, Salary = 13000}
            };
            Array.Sort(employee);
            foreach (Employee item in employee)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region interface E03
            //Car car = new Car();

            //car.Speed = 120;
            //car.Forward();

            Airplane airplane = new Airplane();

            IMoveable moveable = airplane;
            moveable.Forward();

            IFlyable flyable = airplane;
            flyable.Forward();
            #endregion

            #region shallow copy Vs Deep copy 
            //shallow copy Vs Deep copy 

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };


            //string[] Arr01 = { "AHmed", "Ali", "omar" };
            //string[] Arr02 = { "Ziad", "adel", "amr" };

            //  StringBuilder[] Arr01 = new StringBuilder[]
            //  {
            //      new StringBuilder("Ahmed"),
            //      new StringBuilder("Ali"),
            //      new StringBuilder("Omar")
            //  };

            //  StringBuilder[] Arr02 = new StringBuilder[]
            //{
            //      new StringBuilder("Amr"),
            //      new StringBuilder("Adel"),
            //      new StringBuilder("Ziad")
            //};

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");

            //Arr02 = Arr01; //shallow copy
            ////Copy Identity
            ////{1,2,3} --> Has Two reference Arr01,Arr02
            ////{4,5,6} --> UnReachable object 

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");

            ////Identity (address) + object state [Date]

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");

            //Arr02 = (int[]) Arr01.Clone(); //Deep copy
            ////Clone Methodwill copy the object state of the caller
            ////assign the new object to Arr02 , will genetrate new identity

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");

            //Identity (address) + object state [Date]

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]); 
            #endregion


        }
    }
}
