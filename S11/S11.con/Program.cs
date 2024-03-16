namespace S11.con;

class Program
{
    static void Main(string[] args)
    {
        var grades = new Dictionary<Student, StdGrade>();
        grades.Add(new Student() { Id = 1, Name = "ali" }, new StdGrade() { Course="math", Grade=20 });
        grades.Add(new Student() { Id = 2, Name = "zari" }, new StdGrade() { Course="math", Grade=19 });
        grades.Add(new Student() { Id = 3, Name = "pari" }, new StdGrade() { Course="math", Grade=18 });
        grades.Add(new Student() { Id = 4, Name = "hani" }, new StdGrade() { Course="math", Grade=17 });
        grades.Add(new Student() { Id = 5, Name = "dali" }, new StdGrade() { Course="math", Grade=16 });

        Student s = new Student() { Id = 2, Name = "zari" };
        Console.WriteLine(grades[s]);
    }
}
