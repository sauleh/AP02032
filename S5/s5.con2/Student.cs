using System;
namespace s5.con2;

struct StudentV
{
    public int Id;
    public string Name;
    public StudentV(string name, int id)
    {
        Id = id;
        Name = name;
    }
}

class Student
{
    public static int s_id = 0;
    public Student(string name, Student friend)
    {
        Name = name;
        Id = s_id;
        s_id++;
        this.friend = friend;
        grades = new double[100000];
        System.Console.WriteLine($"Constructor called for {Id}");
    }

    ~Student()
    {
        System.Console.WriteLine($"Destructor called {Id}");
    }

    public string get_name()
    {
        return Name;
    }

    public int get_id()
    {
        return Id;
    }

    private string Name;
    public int Id;

    public Student friend;

    private double[] grades;
}