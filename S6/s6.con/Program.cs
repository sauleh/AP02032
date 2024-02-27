using System;
using System.Collections.Generic;
using System.IO;
namespace s6.con;

class Program
{
    static void change(ref int x)
    {
        x = 5;
    }
    static void change(ref int[] nums)
    {
        nums = new int[3];
        nums[0] = 2;
    }

    static void change(string s)
    {
        s += 5;
    }

    static string MakeStr()
    {
        string s = "";
        for (int i = 0; i < 10; i++)
            s += i;
        return s;
    }

    static void Main(string[] args)
    {
        // int[] nums = new int[100];
        // for (int i = 0; i < nums.Length; i++)
        //     nums[i] = i;
        // string[] lines = new string[100];
        // for (int i = 0; i < lines.Length; i++)
        //     lines[i] = nums[i].ToString();
        // File.WriteAllLines("test.csv", lines);
        // string[] lines = File.ReadAllLines("test.csv");
        // for(int i=0; i<lines.Length;i++)
        //     System.Console.WriteLine(lines[i]);
        int x = int.MaxValue;
        System.Console.WriteLine(x);

        


    }

    static void Main4444(string[] args)
    {
        int x = int.Parse("1234");
        double y = double.Parse("1.25");
        string s = x.ToString();
        List<int> nums = new List<int>();
        nums.Add(1);
        for(int i=0; i<nums.Count; i++)
            System.Console.WriteLine(nums[i]);

        nums[0] = 5;
        nums.RemoveAt(5);
        nums.Remove(5);
        

        string sx = "ddlkfjsldkf";
        change(s);
        System.Console.WriteLine(s);

    }

    static void Main6(string[] args)
    {
        MakeStr();
        string s = "132456789012345";
        for(int i=0; i<s.Length; i++)
        {
            System.Console.WriteLine(s[i]);
        }
        string w = s.Replace('1', 'X');
        System.Console.WriteLine(w);
    }
    static void Main2(string[] args)
    {        
        // int y = 7;        
        // change(ref y);
        int[] nums = new int[5];
        change(ref nums);

        for(int i=0; i<nums.Length; i++)
            System.Console.WriteLine(nums[i]);
        
    }
}
