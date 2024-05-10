namespace s20.con;
public static class MyExt
{
    public static void MyPrint<T>(this IEnumerable<T> values)
    {
        foreach (var v in values)
            Console.WriteLine(v);
    }
}

interface IMyComparer<T>
{
    int Compare(T a, T b);
}
class MyComparer<T> : IMyComparer<T> where T : IComparable<T>
{
    public int Compare(T a, T b) => a.CompareTo(b);
}
class Program
{
    delegate int MyStrCmp<T>(T a, T b);

    public static int MyStringComparerFn2(string a, string b) 
    {
        return 1;
    } 

    public static int MyStringComparerFn(string a, string b) 
    {
        return a.CompareTo(b);
    } 
    static void MySortFn<T>(T[] nums, MyStrCmp<T> cmp)
    {
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (cmp(nums[i], nums[j]) > 0)
                    swap(nums, i, j);
    }    
    static void MySort<T>(T[] nums, IMyComparer<T> cmp)
    {
        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (cmp.Compare(nums[i], nums[j]) > 0)
                    swap(nums, i, j);
    }

    private static void swap<T>(T[] nums, int i, int j)
    {
        T tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
    public delegate T AddFn<T>(T a, T b);
    public static T Sum<T, MyTypes>(MyTypes a, AddFn<T> f) where MyTypes: IEnumerable<T>
    {
        T sum = default;
        foreach (var v in a)
            sum = f(sum, v);
        return sum;
    }
    static string StringAdd(string a, string b)
    {
        if (a == null)
            a = "";
        if (b == null)
            b = "";
        return $"{a}{b}";
    }

    static string StringAdd2(string a, string b)
    {
        if (a == null)
            a = "";
        if (b == null)
            b = "";
        return $"{a}-{b}";
    }    


    static int IntAdd(int a, int b) => a + b;

    static void Main444(string[] args)
    {
        string[] names = new string[] { "ali", "zari", "mozhi"};
        Console.WriteLine(Sum<string, string[]>(names, StringAdd2));
        int[] mynums = new int[] { 2,3, 4, 5};
        Console.WriteLine(Sum<int, int[]>(mynums, IntAdd));







        MyStrCmp<string> abcFn = MyStringComparerFn;
        int x = 5;
        MySortFn(names, abcFn);
        names.MyPrint();
        // foreach(var v in names)
        //     System.Console.WriteLine(v);
        
    }

    static void Main3(string[] args)
    {
        string[] names = new string[] { "ali", "zari", "mozhi"};
        MySort(names, new MyComparer<string>());
        Array.Sort(names, StringComparer.Ordinal);
    }
    
    static void Main2(string[] args)
    {
        File.ReadAllLines("children-per-woman-UN.csv")
            .Skip(1)
            .Select(l => {
                var toks = l.Split(',');
                return (country: toks[0], 
                        year: int.Parse(toks[2]), 
                        rate: double.Parse(toks[3]));
            })
            .Where(t => t.year == 2015)
            .OrderByDescending(t => t.rate)
            .ToList()
            .ForEach(l => Console.WriteLine(l));
        // int sum = Enumerable.Range(1, 100)
        //                     .Sum();
        // System.Console.WriteLine(sum);
    }
}
