using System;

public class PersonAgeComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return 0;
        // throw new NotImplementedException();
    }
}

public class PersonNameComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Name.CompareTo(y.Name);
    }
}

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Id { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Age { get { return CalculateAge(); } }
    public double Height { get; set; }
    public double Weight { get; set; }

    public int CompareTo(Person other)
    {
        return this.Weight.CompareTo(other.Weight);
    }

    private int CalculateAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - DateOfBirth.Year;
        if (DateOfBirth.Date > today.AddYears(-age)) age--;
        return age;
    }
}

class Program2
{
    static void Main(string[] args)
    {
        string[] names = { "John", "Emma", "Michael", "Sophia", "William", "Olivia", "James", "Isabel", "Jacob", "Charl" };

        Person[] people = new Person[10];

        Random random = new Random();

        // Initialize array with 10 Person objects with different values
        for (int i = 0; i < 10; i++)
        {
            people[i] = new Person
            {
                Name = names[random.Next(names.Length)], // Random name
                Id = random.Next(names.Length) + 1,
                DateOfBirth = DateTime.Now.AddYears(-20 - random.Next(names.Length)), // Varying dates of birth
                Height = 160 + random.Next(names.Length), // Varying heights
                Weight = 60 + random.Next(names.Length) // Varying weights
            };
        }

        // Display information for each person
        foreach (var person in people)
            Console.WriteLine($"{person.Name}\t{person.Id}\t{person.DateOfBirth.ToShortDateString()}\t{person.Age}\t{person.Height}\t{person.Weight}");

        Array.Sort(people);
        System.Console.WriteLine("----------------------");
        Array.Sort(people, new PersonAgeComparer());
        Array.Sort(people, new PersonNameComparer());

        foreach (var person in people)
            Console.WriteLine($"{person.Name}\t{person.Id}\t{person.DateOfBirth.ToShortDateString()}\t{person.Age}\t{person.Height}\t{person.Weight}");

    }
}
