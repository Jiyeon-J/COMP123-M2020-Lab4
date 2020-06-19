using System;
using System.Collections.Generic;
using System.Text;

namespace COMP123_M2020_Lab4
{
    class Person
    {
        //Private Instance Variables

        //Public Properties
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor(s)
        public Person(string name, int age)
        {
            //Property Initialization
            Name = name;
            Age = age;
        }

        //Private method

        //public method
        public void SaysHello()
        {
            Console.WriteLine($"{Name} says Hello!");
        }
    }
}
