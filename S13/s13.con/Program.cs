using System.Diagnostics;

namespace s13.con;

class autofile: IDisposable
{
    public autofile(string filename)
    {
        m_Filename = filename;
        System.Console.WriteLine("constructor called : " + filename);
    }
    private string m_Filename;
    ~autofile()
    {
        System.Console.WriteLine("~autofile called");
    }

    public void Dispose()
    {
        System.Console.WriteLine("Dispose called " + m_Filename);
    }
}

class Program
{
    // static void test()
    // {
    //     autofile f = null;
    //     try
    //     {
    //         f = new autofile("test.txt");
    //         //..
    //     }
    //     catch
    //     {
    //         //...
    //     }
    //     finally
    //     {
    //         f.Close();
    //     }

    // }


    static void Main32(string[] args)
    {
        System.Console.WriteLine("Program Start");
        if (args.Length > 1)
        {
            using autofile af = new autofile("all.json");
        }
        System.Console.WriteLine("Program End");
    }


   static void MainPost(string[] args)
    {
        using StreamReader reader = new StreamReader("all.json");
        string line = null;
        int count = 100_000;
        long sum = 0;
        string task = $"reading {count} lines ";
        // using (AutoStopwatch asw = new AutoStopwatch(task))
        // {
        //     while ((null != (line = reader.ReadLine())) && count-- > 0)
        //     {
        //         sum += line.Length;
        //     }
        //     System.Console.WriteLine("Total number of chars: " + sum);
        // }
    }

   static void MainPre(string[] args)
    {
        using StreamReader reader = new StreamReader("all.json");
        string line = null;
        int count = 100_000;
        long sum = 0;
        string task = $"reading {count} lines ";
        Stopwatch sw = Stopwatch.StartNew();
        while ((null != (line = reader.ReadLine())) && count-- > 0)
        {
            sum += line.Length;
        }
        System.Console.WriteLine("Total number of chars: " + sum);
        sw.Stop();
        System.Console.WriteLine($"Total Time for {task}: {sw.ElapsedMilliseconds}");
    }

    static void Main3(string[] args)
    {
        using (StreamReader reader = new StreamReader("all.json"))
        {
            string line = null;
            int count = 100;
            while ((null != (line = reader.ReadLine())) && count-- > 0)
            {
                Console.WriteLine(line);
            }
        }
    }

    static void Main2(string[] args)
    {
        string [] lines = File.ReadAllLines("all.json");
        System.Console.WriteLine(lines.Length);
    }
}
