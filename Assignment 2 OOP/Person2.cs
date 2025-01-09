namespace Assignment_2_OOP
{
    struct Person2
    {
        public string Name;
        public int Age;
    }

    static class FindOldestPersonProgram
    {
        static void Main()
        {
            Person2[] persons = new Person2[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name of person {i + 1}: ");
                persons[i].Name = Console.ReadLine();
                Console.Write($"Enter age of person {i + 1}: ");
                persons[i].Age = Convert.ToInt32(Console.ReadLine());
            }

            Person2 oldestPerson = persons[0];

            foreach (var person2 in persons)
            {
                if (person2.Age > oldestPerson.Age)
                {
                    oldestPerson = person2;
                }
            }

            Console.WriteLine($"The oldest person is {oldestPerson.Name} with age {oldestPerson.Age}");
        }
    }
}
