namespace S5;

class Student
{
    public string name;
    public int id;
    public Student friend;
}


class Program
{
    static void Main(string[] args)
    {
        Student ali = new Student { id = 5, name = "ali" };
        Student melika = new Student { id = 6, name = "melika", friend = ali };
        

        Console.WriteLine("Hello, World!");
    }
}
