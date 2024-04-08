using System.Collections;

namespace s14.con;

class Program
{

    static void Main(string[] args)
    {
        IShape mys = new Rectangle(2, 4);
        IShape[] shapes = new IShape [4]{
            new Rectangle(3, 5),
            new Circle(4),
            new Square(5),
            new Circle(2)
        };
        double shape_area_sum = 0;
        double shape_perim_sum = 0;
        foreach(var s in shapes)
        {
            shape_area_sum += s.Area;
            shape_perim_sum += s.Permiter;
        }

        System.Console.WriteLine(shape_area_sum);
        System.Console.WriteLine(shape_perim_sum);
    }

    static void Main3(string[] args)
    {
        string[] names = { "John", "Emma", "Michael", "Sophia", "William", "Olivia", "James", "Isabel", "Jacob", "Charl" };
        for(int i=0; i<names.Length; i++)        
        {
            System.Console.WriteLine(names[i]);
        }

        foreach(string name in names)
        {
            System.Console.WriteLine(name);
        }
    
        string str = "123456780aedkfjasld";
        foreach(char c in str)
        {
            System.Console.WriteLine(c);
        }

        TokenizedString tokstr = new TokenizedString("ali hassan zari mojagan test mest");
        // foreach(string s in tokstr)
        //     System.Console.WriteLine(s);

        IEnumerator<string> tokenum = tokstr.GetEnumerator();
        while (tokenum.MoveNext())
        {
            System.Console.WriteLine(tokenum.Current);
        }

        // StringSizeEnumerable sse = new StringSizeEnumerable("askjfl12938479128alsdkjf", 3);
        // foreach (string s in sse)
        //     Console.WriteLine(s);
        // // ask
        // // jfl
        // // 129
        // // ...

        // NumberBitEnumerator nbe = new NumberBitEnumerator(33);
        // foreach (byte b in nbe)
        //     Console.WriteLine(b);
        //ali
        //hassan
        //zari
    }
}
