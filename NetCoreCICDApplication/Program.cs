using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NetCoreCICDApplication.Tests")]

namespace NetCoreCICDApplication
{
    class Program
    {
        static void Main (string[] args)
        {
            Person p = new Person{name = "Tom", Age = 34};
            Console.WriteLine($"Hello World, I'm {p.name}, and I'm {p.Age} years old. ");
            Console.ReadLine();
        }
    }
}
