namespace w2.ocon;

class Student
{
    double Grade;
    string Name;
    int Id;
    static double MaxGrade;

    public Student(int id, string name)
    {
        Name = name;
        Id = id;
    }

    public double get_grade()
    {
        return Grade;
    }

    public void set_grade(double g)
    {
        Grade = g;
    }

    public double get_std_grade()
    {
        return Grade / MaxGrade;
    }

    public static void SetMaxGrade(double maxgrade)
    {
        MaxGrade = maxgrade;
    }

}

public class Program
{

    static void Main(string[] args)
    {
        Student.SetMaxGrade(20);
        Student s = new Student(402521, "keikavous");
        Console.WriteLine(s.get_std_grade());
    }

    static void Main3(string[] args)
    {
        Console.Write("x? ");
        string s = Console.ReadLine();
        int x = int.Parse(s);

        Console.Write("y? ");
        s = Console.ReadLine();
        int y = int.Parse(s);

        int z = add(x, y);
        Console.WriteLine(z);
        // for (int i = 0; i < args.Length; i++)
        //     Console.WriteLine(args[i]);
    }

    public static int add(int x, int y )
    {
        return x + y;
    }
}
