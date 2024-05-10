
interface IStudent
{
    string Name { get; set; }
    int StdId { get; set; }

    abstract static int GetTest();

    static int GetBaseStdId() 
    {
        return 402521234; 
    }
}


class MyPair<T1, T2>
{
    public T1 item1;
    public T2 item2;
    public MyPair(T1 i1, T2 i2)
    {
        item1 = i1;
        item2 = i2;
    }
}

class Program2
{


    public static void Main(string[] args)
    {
        Tuple<int, string> tis = new Tuple<int, string>(12, "ali");
        var tis2  = new Tuple<int, string>(12, "ali");
        var tis3 = Tuple.Create(12, "asdf");

        int x = 5;
        int y = x;
        x = 6;

        MyPair<int, double> mp = new MyPair<int, double>(1, 5);
        var mp2 = mp;
        mp.item1 = -1;
        Console.WriteLine(mp2.item1);

        ValueTuple<int, double> vt = new ValueTuple<int, double>(1, 5);
        var vt2 = vt;
        vt.Item1 = -1;
        (int, double) d2 = (1, 5);

    }

    // void test()
    // {
    //     Program.IntComparer c = new Program.IntComparer();
    // }
}