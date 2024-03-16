using System.Diagnostics;

namespace S11.con;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("ali");
        Student s2 = new Student("zali");
        Student s3 = new Student("mori", 4015210);
        Student s4 = new Student("fori", 4015210, 2001);
        // s.Name = "ali";
        // s.Id = 25;
        // s.Age = 18;
        System.Console.WriteLine(s1);
        System.Console.WriteLine(s2);
        System.Console.WriteLine(s3);
        System.Console.WriteLine(s4);
        StdGrade s = new StdGrade("math", 3.5);
        System.Console.WriteLine(s.Grade);
        // double x = s.Grade + 0.1;
        // s.Grade = x;


    }




    static void Main343(string[] args)
    {
        var grades = new Dictionary<Student, StdGrade>();
        // grades.Add(new Student() { Id = 1, Name = "ali" }, new StdGrade() { Course="math", Grade=20 });
        // grades.Add(new Student() { Id = 2, Name = "zari" }, new StdGrade() { Course="math", Grade=19 });
        // grades.Add(new Student() { Id = 3, Name = "pari" }, new StdGrade() { Course="math", Grade=18 });
        // grades.Add(new Student() { Id = 4, Name = "hani" }, new StdGrade() { Course="math", Grade=17 });
        // grades.Add(new Student() { Id = 5, Name = "dali" }, new StdGrade() { Course="math", Grade=16 });
        // Student s = new Student() { Id = 2, Name = "zari" };

        const int count = 10_000;

        // Stopwatch sw = Stopwatch.StartNew();
        // for(int i=0; i<count; i++)
        // {
        //     Student s_add = new Student() { Id=10+i,  Name=(10+i).ToString()};
        //     var grade = new StdGrade() { 
        //         Course = "math", 
        //         Grade = Random.Shared.NextDouble()*20 
        //     };
        //     // grades.Add(s_add, grade);
        //     grades[s_add] = grade;
        // }
        // sw.Stop();
        // System.Console.WriteLine($"adding took {sw.Elapsed.TotalMilliseconds}");

        // sw.Restart();
        // double sum = 0;
        // for(int i=0; i<count; i++)
        // {
        //     Student s_add = new Student() { Id=10+i,  Name=(10+i).ToString()};
        //     // grades.Add(s_add, grade);
        //     sum += grades[s_add].Grade;
        // }          
        // System.Console.WriteLine($"accessing took {sw.Elapsed.TotalMilliseconds}");
        // Console.WriteLine(sum / count);
    }
}
