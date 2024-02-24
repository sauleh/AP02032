using System;
using System.Threading;
namespace s5.con2;


class Aliagha
{
    static int sum(int x, int y)
    {
        x = 6;
        return x + y;
    }

    static void swap(ref int x, ref int y)
    {
        int t = x;
        x = y;
        y = t;
    }

    static void Main2(string[] args)
    {
        int a = 5;
        int b = 6;
        swap(ref a, ref b);

        Student ali = new Student("ali mirzakhani", null);
        Student aliprim = ali;
        System.Console.WriteLine(ali.Id);
        System.Console.WriteLine(aliprim.Id);
        aliprim.Id = 15;
        System.Console.WriteLine(ali.Id);
        System.Console.WriteLine(aliprim.Id);
        
        StudentV aliv = new StudentV("ali mirzakhani", 5);
        StudentV alivprim = aliv;
        System.Console.WriteLine(aliv.Id);
        System.Console.WriteLine(alivprim.Id);
        alivprim.Id = 15;
        System.Console.WriteLine(aliv.Id);
        System.Console.WriteLine(alivprim.Id);
    }


    static void Main(string[] args)
    {
        Student.s_id = 5;
        Student ali = new Student("ali mirzakhani", null);

        for (int i = 0; i < 200_000; i++)
        {
            ali = new Student("ali mirzakhani", ali);
            // GC.Collect();
            // GC.WaitForPendingFinalizers();
            Thread.Sleep(10);
            System.Console.WriteLine(ali.Id);
        }
        System.Console.WriteLine("Done");
    }
}


        // Console.WriteLine($"int: {sizeof(int)}, double: {sizeof(double)}, long: {sizeof(long)}");
