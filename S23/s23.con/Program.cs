using System.Security.Cryptography;

namespace s23.con;

class mTuple<T1, T2>
{
    private readonly T1 m_Item1;
    public T1 Item1 => m_Item1;
    public T2 Item2 { get; }
    public mTuple(T1 t1 , T2 t2)
    {
        m_Item1 = t1;
        Item2 = t2;
    }

    public override string ToString()
    {
        return Item1.ToString() + "," + Item2.ToString();
    }

    public static mTuple<T1, T2> Create(T1 t1, T2 t2) => 
        new mTuple<T1, T2>(t1, t2);
}

public class Program
{
    static (int,int) CreatePoint()
    {
        return (Random.Shared.Next(0, 10), Random.Shared.Next(0, 10));
    }

    static void Main(string[] args)
    {
        (string name, int id, double grade) s1 = ("ali", 4015212, 18.5);
        (string name, int id, double grade) s2 = ("ali", default, 18.5);
        string name;
        double grade;
        int x;
        (x, _) = CreatePoint();
        (name, _, grade) = s1;
        int w = 5, y = 7;
        // (int, int) copy = (w, y);
        (y, w) = (w, y);
        // Func<>
        // Action<>
        // LINQ ...
        //tuple, delegate, ExtensionFunction
        int[] nums = new int[5] { 1, 2, 5, 4, 3 };
        // var numss = nums.Square();
        // var nums2 = nums.AddTo(5);
        var nums3 = nums.ApplyFn(Add2);
        Func<int, int> sq = (int x) =>
        {
            int p = x * x;
            return p;
        };
        var nums4 = nums.ApplyFn(x => x*x);
        int sssw = 5;
        IEnumerable<int> nums5 = nums.ApplyFn((int x) =>
        {
            int s = x * x + sssw;
            return s;
        }); // closure
        // x^3 + 2x^2 + 5x + 4;
        (int s, int e) www = (4, 7);
        var zzz = (s: 4, e: 7);
        var r1 = nums.ApplyFn(x => x * x * x).ApplyFn(x => 2 * x * x).ApplyFn(y => 5 * y).ApplyFn(x => x + 4);
        r1 = nums.ApplyFn(x => x * x * x + 2 * x * x + 5 * x + 4);
        nums.Select(x => (s: x + 2, e: x - 2))
                     //  .Select(t => t.e - t.s)
                     .OrderByDescending(x => x.s)
                     .Take(5)
                     .Skip(1)
                     .ToList()
                     .ForEach( x => Console.WriteLine(x));
        // GroupBy
        // Join
        (string country, double rateBirth, int year)[] values = new (string country, double rateBirth, int year)[1];
        values.GroupBy(t => t.country)
              .Select(g => (g.Key, g.Max(t => t.rateBirth)));

    }

    public static int Square(int x) => x * x;

    public static int Add2(int x) => x + 2;

    // public delegate T T2T<T>(T x);
    public delegate void DoSomething<T>(T x);
    public delegate void DoSomething<T1, T2>(T1 x, T2 y);
    public delegate TResult ReturnSomething<T, TResult>(T x);
    public delegate TResult ReturnSomething<T1, T2, TResult>(T1 x, T2 y);    

    static void Main2(string[] args)
    {
        // Tuple<int, int> t = new Tuple<int,int>(5, 4);
        // var t2 = Tuple.Create(5, 4);

        // var t1 = mTuple<int,int>.Create(5, 4);
        var t1 = mTuple<int,int>.Create(5, 4);
        var t2 = t1;
        System.Console.WriteLine(t1);
        System.Console.WriteLine(t2);
        // t1.Item1 = 3;
        System.Console.WriteLine(t1);
        System.Console.WriteLine(t2);

        mTuple<int, int>[] points = new mTuple<int, int>[10];
        points[0] = new mTuple<int, int>(1, 1);
        int x = points[0].Item1;
        points[0] = t1;
        // CalculateSize(points[0]);
    }
}
