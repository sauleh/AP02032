public class Program
{
    static void swap<T>(ref T a, ref T b)
    {
        T x = a;
        a = b;
        b = x;
    }

    static T max<T>(T a, T b) where T: IComparable<T>
    {
        ValueComparer<T> cmp = new ValueComparer<T>();
        if (cmp.Compare(a, b) > 0)
            return a;
        return b;
    }

    static T max2<T>(T a, T b) where T: IComparable<T>
    {
        if (a.CompareTo(b) > 0)
            return a;
        return b;
    }

    public class ValueComparer<T> : 
        IComparer<T> where T: IComparable<T>
    {

        public int Compare(T x, T y) =>
            x.CompareTo(y);
    }
    public static void Main(string[] args)
    {
        int a = 5, b = 7;
        int x = max(a, b, new ValueComparer<int>());

    }
}


// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.Numerics;

// namespace s19.con;

// static class StringUtils
// {

// }


// interface IAdable<T> where T: IAdable<T>
// {
//     T Add(T a);
// }

// class AddableInt : IAdable<AddableInt>
// {
//     public int Value;
//     public AddableInt Add(AddableInt a)
//     {
//         // va x = new StringUtils();
//         this.Value += a.Value;
//         return this;
//     }
// }

// class citizen { }

// class Person : citizen, IHasID, IComparable<Person>
// {
//     private int id;
//     public int ID => id;

//     public int CompareTo(Person other)
//     {
//         return this.id.CompareTo(other.id);
//     }

//     public static Person Parse(string s) // "firstname, lastname, id"
//     {
//         return null;
//     }
//     public int iid;
//     public string name;
// }

// //  class Student : INumber<Student>
// // // {
// // //     public static Student One => throw new NotImplementedException();

// // //     public static int Radix => throw new NotImplementedException();

// // //     public static Student Zero => throw new NotImplementedException();

// // //     public static Student AdditiveIdentity => throw new NotImplementedException();

// // //     public static Student MultiplicativeIdentity => throw new NotImplementedException();

// // //     public static Student Abs(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsCanonical(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsComplexNumber(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsEvenInteger(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsFinite(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsImaginaryNumber(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsInfinity(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsInteger(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsNaN(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsNegative(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsNegativeInfinity(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsNormal(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsOddInteger(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsPositive(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsPositiveInfinity(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsRealNumber(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsSubnormal(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool IsZero(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student MaxMagnitude(Student x, Student y)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student MaxMagnitudeNumber(Student x, Student y)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student MinMagnitude(Student x, Student y)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student MinMagnitudeNumber(Student x, Student y)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student Parse(string s, NumberStyles style, IFormatProvider? provider)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student Parse(string s, IFormatProvider? provider)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Student result)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Student result)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out Student result)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out Student result)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public int CompareTo(object? obj)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public int CompareTo(Student? other)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public bool Equals(Student? other)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public string ToString(string? format, IFormatProvider? formatProvider)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator +(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator +(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator -(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator -(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator ++(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator --(Student value)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator *(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator /(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static Student operator %(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool operator ==(Student? left, Student? right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool operator !=(Student? left, Student? right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool operator <(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool operator >(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool operator <=(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }

// // //     public static bool operator >=(Student left, Student right)
// // //     {
// // //         throw new NotImplementedException();
// // //     }
// // // }

// interface IHasBinaryOp
// {
//     int Op(int a, int b);
// }

// interface IHasID
// {
//     int ID { get; }
// }
// class Program
// {
//     // Linq

//     static void Test<T>(T a)
//     {
//     }

//     static bool Register<T>(T person) where T: citizen, IHasID, IComparable<Person>, new()
//     {
//         T x = new T();
//         System.Console.WriteLine($"{person.ID} is registered");
//         return true;
//     }

//     delegate int IntBinaryOp(int a, int b);

//     static int[] apply1(int [] a, int [] b, IntBinaryOp op)
//     {
//         int[] result = new int[a.Length];
//         for (int i = 0; i < a.Length; i++)
//             result[i] = op(a[i], b[i]);
//         return result;
//     }

//     static int[] apply2(int [] a, int [] b, IHasBinaryOp op)
//     {
//         int[] result = new int[a.Length];
//         for (int i = 0; i < a.Length; i++)
//             result[i] = op.Op(a[i], b[i]);
//         return result;
//     }

//     static int opAdd(int a, int b) => a + b;

//     class MyAddOp : IHasBinaryOp
//     {
//         public int Op(int a, int b) => a + b;
//     }

//     static void Main33(string[] args)
//     {
//         int[] nums1 = new int[] { 5, 4, 3, 2, 1, 7 };
//         int[] nums2 = new int[] { 5, 4, 3, 2, 1, 3 };
//         int[] result = apply1(nums1, nums2, opAdd);

//         result = apply2(nums1, nums2, new MyAddOp());


//         // int[] nums = new int[] { 5, 4, 3, 2, 1, 7 };
//         // List<int> nums2 = new List<int>() { 5, 3, 2, 3, 3, 3, 3, 1 };
//         // int w = nums.Sum();


//         IComparable<Person> p = new Person();
//     }

//     static T add<T>(T a, T b)  where T: INumber<T>
//     {
//         return a + b;
//     }


//     static void Main334(string[] args)
//     {
//         // Student s1 = new Student();
//         // Student s2 = new Student();
//         // // s1 + s1;
//         // add<Student>(s1, s2);

//         int w = add<int>(5, 4);

//         Console.WriteLine("Hello, World!");
//     }
// }
