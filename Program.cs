namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
            new Person { Name = "max1", Age = 30, Addresses = new List<string> { "Address 1", "Address 2" } },
            new Person { Name = "ivan", Age = 25, Addresses = new List<string> { "Address 3", "Address 4" } }
            };

            string filePath = "persons.json";

            
            Serialization.SerializeToJson(persons, filePath);

           
            Person[] deserializedPersons = Serialization.DeserializeFromJson<Person[]>(filePath);

            

            foreach (var person in deserializedPersons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

                Console.WriteLine("Addresses:");
                foreach (var address in person.Addresses)
                {
                    Console.WriteLine(address);
                }

                Console.WriteLine();
            }
        }
    }
}