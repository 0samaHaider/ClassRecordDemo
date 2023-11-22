using System;

public class Program
{
    public class Person
    {
        // Fields
        private readonly string name;
        private readonly int age;

        // Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Properties
        public string Name => name;
        public int Age => age;

        // Method
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    public record PersonRecord(string Name, int Age);

    static void Main()
    {
        // Using the class
        Console.WriteLine("Using the class:");
        Person person1 = new("John Doe", 30);
        Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
        person1.PrintDetails();
        Console.WriteLine();

        // Using the record
        Console.WriteLine("Using the record:");
        PersonRecord person2 = new("Jane Doe", 25);
        Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}");
    }
}
