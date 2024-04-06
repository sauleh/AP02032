using System;
class Student
{
    public Student(string name)
        : this(name, LastAssignedId++)
    {
    }
    public Student(string name, int id)
        : this(name, id, DateTime.Now.Year-18)
    {}

    public Student(string name, int id, int yob)
    {
        this.Name = name;
        this.Id = id;
        this._YoB = yob;
        if (yob < 0)
            throw new InvalidDataException("yof can't be less than zero");
    }

    public override string ToString()
    {
        return $"{this.Name} : {this.Id} : {this.Age}";
    }

    private int _YoB;

    public int Age {
        get
        {
            return DateTime.Now.Year-_YoB;
        }

        set
        {
            if (value >= 0)
                _YoB = DateTime.Now.Year - value;
            else
                throw InvalidOperationException("age can't be negative");
        }
    }

    public int YoB
    {
        get
        {
            return _YoB;
        }
    }




    // public int GetAge() { return _YoB; }
    // public void SetAge(int age)
    // {
    //     if (age > 0)
    //         _YoB = age;
    // }

    // private int _Id;

    // public int Id
    // {
    //     get 
    //     {
            
    //         return _Id;
    //     }

    //     set
    //     {
    //         _Id = value;
    //     }
    // }
    public int Id { get; }
    public readonly string Name;
    // public string Name { get; }
    public const int StartingStudentId = 40252100;
    public static int LastAssignedId = StartingStudentId;
    public override bool Equals(object obj)
    {
        if (obj is not Student)
            return false;

        Student s = obj as Student;
        return s.Id == this.Id && s.Name == this.Name;
    }

    public override int GetHashCode()
    {
        return 2343;  //Id.GetHashCode(); // + Name.GetHashCode();
    }
}


class StdGrade
{
    public StdGrade(string course, double grade)
    {
        this.Course = course;
        this.Grade = grade;
    }
    public void SetCompleteAttendance()
    {
        this.Grade += 0.1;
    }
    public string Course { get; set; }
    public double Grade { get; private set; }
    public string GradeStr 
    {
        get
        {
            if (Grade > 3.8)
                return "A+";
            else if (Grade > 3.5)
                return "A";
            else if (Grade > 3)
                return "B+";
            return "F";
        }
    }
    public override string ToString()
    {
        return $"{Course} : {Grade}";
    }
}