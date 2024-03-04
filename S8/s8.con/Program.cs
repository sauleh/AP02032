namespace s8.con;

class Program
{
    static void Main(string[] args)
    {
        // Person p = null;
        // if (p.Equals(null))
        //     Console.WriteLine("null");

        Person p1 = new Person() { Name = "parvaneh", Id=1 };
        Person p3 = new Person() { Name = "parvaneh", Id=1 };
        Person p2 = new Person() { Name = "arsalan", Id=2 };
        List<Person> people = new List<Person>() {p1, p2, p3} ;
        // if (people.Contains(new Person() { Name = "parvaneh", Id=1 }))
        // {
        //     System.Console.WriteLine("Yes");
        // }
        for(int i=0; i<people.Count; i++)
            System.Console.WriteLine(people[i]);

        string sss = "1,2,3,4,5,6";
        string[] tokens = sss.Split(',');
        int sum = 0;
        for(int i=0; i<tokens.Length; i++)
        {
            sum += int.Parse(tokens[i]);
        }
        System.Console.WriteLine(sum);
        Dictionary<int, string> pb = new Dictionary<int, string>();
        pb.Add(910233334, "ali");
        string a = pb[910233334];
    }
}
