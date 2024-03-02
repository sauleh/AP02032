using System.Runtime.Serialization;

namespace s7.con;

class Person {
    public string Name;
    public int Id;
    public void Graduate() { }

    public override bool Equals(object obj)
    {
        if (obj is not Person)
            return false;

        Person other = obj as Person;
        return (other.Id == Id) && (other.Name == Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string s = "sdf";
        object o1 = s;
        int x = 6;
        object o = x;

        int y = (int) o;
        x++;
        y++;
    }

    static void Main5(string[] args)
    {
        Person p1 = new Person() { Name = "parvaneh", Id=1 };
        Person p3 = new Person() { Name = "parvaneh", Id=1 };
        Person p2 = new Person() { Name = "arsalan", Id=2 };
        List<Person> people = new List<Person>() {p1, p2, p3} ;
        System.Console.WriteLine(people.Count);
        // people.Remove(new Person() { Name = "parvaneh", Id = 1 });
        people.Remove(p1);
        System.Console.WriteLine(people.Count);
        people.Remove(p1);
        System.Console.WriteLine(people.Count);
        bool deleted = people.Remove(p1);
        System.Console.WriteLine(people.Count);

\
        // object o = new Program(); 
        // Person p =  o as Person;
        // System.Console.WriteLine(p.Id);
    }

    static void Main2(string[] args)
    {
        Object o = new Object();
        Person p = new Person();
        System.Console.WriteLine(o.ToString());
        System.Console.WriteLine(p.ToString());

        System.Console.WriteLine(o.GetType());
        System.Console.WriteLine(p.GetType());


    }
}
