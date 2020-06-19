using System;

namespace COMP123_M2020_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate object of type Person
            Person Jiyeon = new Person(name: "Jiyeon", age: 27);

            //Use saysHello method with . accessor
            Jiyeon.SaysHello();

            Console.ReadLine();
        }
    }
}
