namespace SessionOOP03
{

    //1. class
    //2. struct 
    //3. enum 
    //4. interface

    internal class Program
    {
        static void Main(string[] args)
        {

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
        }
    }
}
