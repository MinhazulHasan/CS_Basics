using System;

namespace CS_Basics
{
    public class Person
    {
        public string firsrName;
        public string lastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Hello!!! My name is {firsrName} {lastName}.");
        }
    }
}
