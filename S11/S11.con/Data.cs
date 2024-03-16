class Student
{
    public int Id;
    public string Name;

    public override bool Equals(object obj)
    {
        if (obj is not Student)
            return false;

        Student s = obj as Student;
        return s.Id == this.Id && s.Name == this.Name;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() + Name.GetHashCode();
    }
}


class StdGrade
{
    public string Course;
    public double Grade;
    public override string ToString()
    {
        return $"{Course} : {Grade}";
    }
}