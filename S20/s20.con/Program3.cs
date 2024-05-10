
using System.ComponentModel;
using cw = System.Console;
using MyVt = System.ValueTuple<string, int, bool>;

public class Program3
{
    public static void Main(string [] args)
    {
        // anonymous function
        string classname = "AP";
        bool isCapital = true;
        var f = (int x, int y, string w) => $"{x}-{y}.....{w}";
        var f2 = (int x, int y, string w) =>   // Closure
        {
            cw.WriteLine($"{x} .. {y} .. {w} {classname} {isCapital}");
            isCapital = false;  
        };
        cw.WriteLine(isCapital);
        Run(f2);
        cw.WriteLine(isCapital);
        // f2(1, 1, "asli");
        // cw.WriteLine(f(1, 5, "ali"));    
        Func<int, int, (double,int)> f3 = addnums;
        var ff3 = addnums;
        Func<int, int, (double, int)> f4 = (a, b) => (a + b, a + b);
    }

    static (double, int) addnums(int a, int b) => (a+b, a + b);

    static void Run(Action<int,int,string> f)
    {
        f(1, 1, "ali");
    }

    public static void Main44444(string[] args)
    {
        var std = new // anonymous class
        {
            name = "ali",
            id = 1234,
            isFemale = false
        };
        // PrintObj(std);
        System.Console.WriteLine($"{std.name}, {std.id}, {std.isFemale}");

        (string name, int id, bool isFemale) stdtuple = ("ali", 1234, false);

        (string, int, bool) ddd = stdtuple;

        string name;
        bool isFemale;
        (name, _, isFemale) = stdtuple; // Tuple Deconstruction

        PrintMyT(stdtuple);
        PrintMyT2(stdtuple);
        PrintMyT(("zari", 2343, true));
        int[] nums;
        (int, bool)[] pairs = new (int, bool)[10];
        (int, bool) w = (10, false); // Value Type
        w.Item1 = 12;
        pairs[0] = w;
        pairs[0].Item2 = true;
        pairs[1] = PrintMyT2(stdtuple);



    }

    static (int a, bool b) PrintMyT2(MyVt v)
    {
        return (v.Item2, v.Item3);
    }

    static void PrintMyT((string, int, bool) std)
    {
        ValueTuple<string, int, bool> vt = std;
        MyVt twk = std;
    }
}