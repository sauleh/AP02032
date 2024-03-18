
namespace s12.con;

class Program
{
    static void C1()
    {
        Console.Write("Number?");
        var s = Console.ReadLine();
        int n = int.Parse(s);
        n++;
        Console.WriteLine($"incremented number {n}");
    }


    static void C3()
    {
        Console.Write("Number?");
        var s = Console.ReadLine();
        int n = int.Parse(s);
        n = 10 / n;
        Console.WriteLine($"10 divided by number is {n}");
    }    

    static void C5()
    {
        Console.Write("Number?");
        var s = Console.ReadLine();
        int n = int.Parse(s);
        string w = null;
        Console.WriteLine($"w + s is {w.Length}");
    }  

    static void C7()
    {
        Console.Write("Number?");
        var s = Console.ReadLine();
        int n = int.Parse(s);
        int x = int.MaxValue;
        checked
        {
            x += n;
        }
        Console.WriteLine($"MxValue + n  {x}");
    }     

    static void C9()
    {
        string s = File.ReadAllText("a.txt");
        System.Console.WriteLine(s);
    }    

    static void C()
    {
        int[] nums = new int[5] { 1, 5, 4, 2, 0 };
        System.Console.WriteLine("Number? ");
        var s = Console.ReadLine();
        int idx = int.Parse(s);
        System.Console.WriteLine(nums[idx]);
    }

    static void B()
    {
        Console.WriteLine("B:Pre");
        C();
        Console.WriteLine("B:Post");
    }    
    static void A()
    {
        Console.WriteLine("A:Pre");
        B();
        Console.WriteLine("A:Post");
    }
    static void Main22(string[] args)
    {
        try
        {
            int x = GetIntegerFromUser();
            System.Console.WriteLine("After GetIntegerFromUser");
        }
        catch(DivideByZeroException)
        {
            System.Console.WriteLine("Dont' worry");
        }
        System.Console.WriteLine("End");
        // A();
    }

    private static int GetIntegerFromUser()
    {
        bool success = false;
        int n = 0;
        while (!success)
        {
            System.Console.WriteLine("Number? ");
            string s = Console.ReadLine();
            try
            {
                n = int.Parse(s);
                // int w = 10 / n;
                success = true;
                // s = null;
                // w += s.Length;
            }
            catch (FormatException fe)
            {
                System.Console.WriteLine($"{fe.Message}\n{s} is not a valid integer.\nPlease enter a valid integer!");
            }
            catch(NullReferenceException)
            {
                System.Console.WriteLine("This is not good.");
            }
            catch(IndexOutOfRangeException rE)
            {
                System.Console.WriteLine(rE.Message);
                throw;
            }
            catch(Exception)
            {
                // catch all exception
            }            
            //...
        }
        return n;
    }





    static void Main66(string[] args)
    {
        try
        {
            AB();

        }
        catch
        {
            throw;
        }
    }
    static void AB()
    {
        int x=0;
        System.Console.Write("Number? ");
        string s = Console.ReadLine();
        try
        {
            x = int.Parse(s);
            System.Console.WriteLine("Post Parse");
        }
        // catch
        // {
        //     x = - 1;
        // }
        finally
        {
            System.Console.WriteLine($"-----test {x+1}");            
        }
        System.Console.WriteLine("End of Function");
    }



    static int GetStdNumber()
    {
        System.Console.WriteLine("Your Student Number? ");
        string s = Console.ReadLine();
        int number = int.Parse(s);
        if (s.Length != 9) {
            InvalidDataException e =  new InvalidDataException($"Student Id ldength is not correct: {number}, 9 != {s.Length}");
            throw e;
        }

        if (! s.StartsWith("401") && !s.StartsWith("402"))
        {
            InvalidDataException e = new InvalidDataException("StudentId should start with 401 or 402");
            throw e;
        }

        return number;
    }



    static void Main(string[] args)
    {
        int stdid = GetStdNumber();
    }

}
