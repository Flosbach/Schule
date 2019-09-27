using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 5;
            Console.WriteLine("Hello World " + person.Age);
            Console.ReadKey();
        }
    }

    class Person
    {
        //Eigenschaft
        public int age;

        //Methoden für Eigenschaften (Properties) in Kurzschreibweise
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }


}
 