using System.Numerics;

public class Student<IdType, GradeType> 
    where GradeType: IComparable<GradeType>, IEquatable<GradeType>
    where IdType: IComparable<IdType>
{
    public IdType id;
    public string name;
    public List<GradeType> grades;

    GradeType GetMaxGrade()
    {
        GradeType max = grades.Count > 0 ? grades[0] : default;
        foreach (var g in grades)
            if (g.CompareTo(max) > 0)
                max = g;
        return max;
    }
}

public class MyDict<TKey, TValue>
{
    
}

public class Program2
{
    public static void Main33(string[] args)
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(912234334, "zahra");

        Student<int, double> student = new Student<int, double>()
        {
            id = 5,
            name = "ali",
            grades = new List<double>() { 18.5, 17.1, 12}
        };


        Student<string, string> s2 = new Student<string, string>()
        {
            id = "98521123",
            name = "ali",
            grades = new List<string>() { "A+", "B"}
        };


    }
}

