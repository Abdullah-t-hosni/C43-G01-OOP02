namespace Assignment_2_OOP
{
    struct Person
    {
        public string Name;
        public int Age;
    }

    static class DisplayPersonsProgram
    {
        static void Main()
        {
            Person[] persons = new Person[3];

            persons[0] = new Person { Name = "John", Age = 25 };
            persons[1] = new Person { Name = "Alice", Age = 30 };
            persons[2] = new Person { Name = "Bob", Age = 22 };

            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
