namespace s24.con;

public static class MyExt
{
    public static IEnumerable<string> GetName()
    {
        string[] names = new string[] { "asd", "dfd", "dfkjkd"};
        foreach (var n in names)
            yield return n;
    }

    public static IEnumerable<string> GetName2()
    {
        yield return "ali";
        yield return "zahra";
        yield return "mohsen";
    }    

    public static IEnumerable<T> MyTake2<T>(this IEnumerable<T> values, int count)
    {
        foreach (var v in values)
            if (count-- >= 0)
                yield return v;                
    }

    public static IEnumerable<T> MyTake<T>(this IEnumerable<T> values, int count)
    {
        List<T> result = new List<T>();
        foreach (var v in values)
            if (result.Count < count)
                result.Add(v);
            else
                break;
        return result;
    }
}

class Program
{    
    static bool DoReturn(string line)
    {
        return line.ToLower().Contains("iran");
    }
    static void Main(string[] args)
    {
        // var names = MyExt.GetName2();        
        // foreach(var n in names)
        // {
        //     System.Console.WriteLine(n);
        // }
        // IEnumerable<string> lines = 
        // File.ReadAllLines("children-per-woman-UN.csv")
        //     .Where(l =>l.ToLower().Contains("iran")) //DoReturn
        //     .Where(l => l.Contains("2010"))
        //     .Take(5)
        //     .ToList()
        //     .ForEach(l => Console.WriteLine(l));
        var data =
        File.ReadAllLines("children-per-woman-UN.csv")
            .Skip(1)
            .Select(l => {
                string[] toks = l.Split(',');
                int year = int.Parse(toks[2]);
                double rate = double.Parse(toks[3]);
                return (country: toks[0].ToLower(), year: year, rate: rate);
            });
        // .Where(t => t.country == "iran" && t.year > 2000)
        // .Where(t => t.country == "iran")
        // .Where(t => t.rate > 3)
        // .Take(20)
        // .Where(t => t.year == 2015)
        // .OrderByDescending(t => t.rate)
        // .Select(t => t.country)
        // .GroupBy(t => t.country)
        // .Select(g => (country:g.Key, avg:g.Average(t => t.rate)))
        // .Select(g => (country:g.Key, year:g.MinBy(t => t.rate).year))
        // .Where(d => d.year != 2015)
        //.OrderBy(d => d.avg)
        // .Take(10)
        data.Join(data,
            d => (d.country, d.year),
            d => (d.country, d.year-1),
            (d1, d2) => (country: d1.country, y1: d1.year, y2: d2.year, r1:d1.rate, r2:d2.rate)
        )
        // .Where(d => d.country == "iran")
        .GroupBy(d => d.country)
        .Select(g => {
            var md = g.MaxBy(d => d.r1 - d.r2);
            return (country: g.Key, year: md.y1, diff: (md.r1 - md.r2));
        })
        .OrderByDescending(d => d.diff)
        .Take(30)
        .ToList()
        .ForEach(l => Console.WriteLine(l));

        // Func<int,int,int> fn = (int a, int b) => a + b;
        // int x = fn(5, 4);
    }
}
