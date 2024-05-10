using System.Numerics;

namespace s17.con;

public static class Exts
{
    public static string SortChars(this string s, bool asc)
    {
        // return new string(s.ToArray().OrderByDescending(c => c).ToArray());
        var ca = s.ToCharArray();
        Array.Sort(ca);
        if (!asc)
            ca = ca.Reverse().ToArray();
        return new String(ca);
    }

    public static int NextPrime(this int n)
    {
        return 0;
    }
}

class Person
{
    protected int id;
    public int iid;
    protected virtual void Test() { }

    public static Person operator+(Person p1, Person p2)
    {
        Person pp = new Person() { id = p1.id + p2.id };
        pp.iid = p1.id - p1.id;
        return p1;
    }
}

class MixNum
{
    public MixNum(double re, double im)
    {
        this.Re = re;
        this.Im = im;
    }
    public double Re;
    public double Im;
    public static MixNum operator+(MixNum a, MixNum b)
    {
        return new MixNum(a.Re + b.Re, a.Im + b.Im);
    }

    public static MixNum operator-(MixNum a)
    {
        return new MixNum(-a.Re, -a.Re);
    }

    public static MixNum operator /(MixNum a, MixNum b) => null;

    public static MixNum operator /(MixNum a, double w) => null;
    public static MixNum operator *(MixNum a, double w) => null;
    public static MixNum operator !(MixNum a) => null;
    public static MixNum operator ~(MixNum a) => null;
    public static MixNum operator ^(MixNum a, double d) => null;
    public static implicit operator MixNum(double d)
    {
        return new MixNum(d, 0);
    }
    public static explicit operator double(MixNum m)
    {
        return m.Re;
    }

    public double this[bool b]
    {
        get
        {
            if (b)
                return this.Re;
            return this.Im;
        }
        set
        {
            if (b)
                this.Re = value;
            else
                this.Im = value;
        }
    }


    public double this[int i]
    {
        get
        {
            if (i == 0)
                return this.Re;
            return this.Im;
        }
        set
        {
            if (i == 0)
                this.Re = value;
            else
                this.Im = value;
        }
    }



    public static MixNum operator-(MixNum a, MixNum b) => a + (-b);
}

class Student: Person
{
    int [,] mx = new int[10,4];
    int[][] mxx = new int[10][];
    void init()
    {
        MixNum x =  5.4;
        double d = (double) x;
        double d2 = x[0];
        x[1] = d;

        x[true] = 1.2;

        for (int i = 0; i < mxx.Length; i++)
            mxx[i] = new int[4*i];
    }

    protected override void Test() { }
    public Student()
    {
        this.id = 78;
    }
}

public class MyNum<T> where T :INumber<T>
{
    protected T value;
    public MyNum(T x) {
        this.value = x;
    }

    public static MyNum<T> operator +(MyNum<T> a, MyNum<T> b) =>
        new MyNum<T>(a.value + b.value);

    // public static implicit operator int(MyNum x) => x.value;        
    // public static implicit operator MyNum(int x) => new MyNum(x);        
    // public static explicit operator MyNum(string s) 
    //     => new MyNum(int.Parse(s));
    // public static implicit operator string(MyNum x) => x.value.ToString();
    
    
}

public class StudentT<T>
{
    string name;
    T id;
}


class Program
{
    static void swap<T>(ref T x, ref T y)
    {
        T t = x;
        x = y;
        y = t;
    }
    // abstract, sealed
    // protected (public, private)
    // Extension Method
    // Operator Overloading
    //    + = * / ^ ! ~ 
    //    explicit/implicit
    // indexer (operator[])
    // Two dim array, jagged array
    static void Main(string[] args)
    {
        StudentT<long> s = new StudentT<long>();

        // MyNum<int> n = new MyNum<int>(5);
        // MyNum<string> w = new MyNum<string>();
        // MyNum<int> n2 = 4;
        // MyNum n3 = (MyNum) "3423";
        // string ws = n;

        Person p = new Person();
        p.iid = 5;
        //p.id = 4;
        int w = 5.NextPrime();
        int x = w.NextPrime();
        string x2 = "asldkfjasdlkfjas;d";
        var ww = x2.SortChars(true);
        string wwww = "alksdjflaskdjf".SortChars(false);

        Person p1 = new Person();
        Person p2 = new Person();
        Person p3 = p1 + p2;
    }
}
