using System.Runtime.InteropServices;

namespace s10.con;

enum ErrorSource: int
{
    UI = 0x100000,
    FE = 0x200000,
    BE = 0x400000
}

enum ErrorType: int
{
    IO = 0x000100,
    FS = 0x000200,
    Net = 0x400400
}

enum ErrorLevel: int
{
    Debug = 0x000001,
    Info = 0x000002,
    Warning = 0x000004,
    Error = 0x000008,
    Abort = 0x000010

}


class Program
{

    static long F(long x)
    {
        if (x <= 1)
            return 1;
        long sum = F(x - 1) + F(x - 2);
        return sum;
    }

    static void Increment(out int x)
    {
        x = 0;
        x++;

    }

    static void Test(ref int[] nums)
    {
        nums[0] = 1;
        nums = new int[5];
    }

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


    static int Main2(string[] args)
    {
        bool success;
        int xx;
        success = int.TryParse("5", out xx);
        if (success)
        {
            System.Console.WriteLine(xx);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        int x = 5;
        object o = x;
        int y = (int) o;
        Console.WriteLine(F(5));

        return (int)ErrorSource.BE | (int)ErrorType.IO | (int)ErrorLevel.Warning;
    }
}
