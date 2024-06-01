using System.Diagnostics;
using System.Transactions;

namespace S29;

class Program
{
    static int count = 0;
    static object mylock = new object();

    static IEnumerable<int> GetNums()
    {
        int c = 0;
        while (true)
            yield return c++;
    }
    static void Main(string[] args)
    {
        var nums = GetNums().Take(10).ToList();
    }


    static async Task<string> DoAsync()
    {
        string myresult = "";
        await Task.Delay(100);
        myresult += "sdf";
        await Task.Delay(200);
        myresult += "2343";
        await Task.Delay(200);
        return myresult;
    } 

    static void Main77(string[] args)
    {
        var v = DoAsync();
        v.Wait();
        Console.WriteLine(v.Result);

        Task t = new Task(() =>
        {
            int c = 20;
            while (c-- > 0)
            {
                var t1 = Task.Delay(100);
                Console.Write('.');
                t1.Wait();
            }
        });
        t.Start();
        t.Wait();

    }

    static void Main2(string[] args)
    {
        Thread t1 = new Thread(() =>
        {
            for (int i = 0; i < 100_000_000; i++)
                Interlocked.Increment(ref count);
                // lock(mylock)
                // {
                //     count++;
                // }
        });

        Thread t2 = new Thread(() =>
        {
            for (int i = 0; i < 100_000_000; i++)
                Interlocked.Decrement(ref count);
                // lock(mylock)
                // {
                //     count--;
                // }
        });
        Stopwatch sw = Stopwatch.StartNew();
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        System.Console.WriteLine(sw.ElapsedMilliseconds);
        System.Console.WriteLine(count);    
    }

    static void Main1(string[] args)
    {
        object mylock = new object();
        ParameterizedThreadStart d = (o) => {
            int n;
            ConsoleColor c;
            (n, c) = ((int, ConsoleColor)) o;
            while (n-- > 0)
            {
                lock (mylock)
                {
                    ConsoleColor oldColor = Console.ForegroundColor;
                    Console.ForegroundColor = c;
                    Console.WriteLine($"Thread {c} {Thread.CurrentThread.ManagedThreadId}");
                    Console.ForegroundColor = oldColor;
                }
                Thread.Sleep(500);
            }
        };
        Thread t1 = new Thread(d);
        Thread t2 = new Thread(d);
        t1.Start((10, ConsoleColor.Blue));
        t2.Start((5, ConsoleColor.Green));

        while (true)
        {
            Console.WriteLine("Main Thread");
            Thread.Sleep(500);
        }
    }
}
