public static class PersonComparer
{
    public static PersonHeightComparer PersonHeightComparer = new PersonHeightComparer();
    public static PersonAgeComparer PersonAgeComparer = new PersonAgeComparer();
    public static PersonNameComparer PersonNameComparer = new PersonNameComparer();
}


public class PersonAgeComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
        // if (x.Age < y.Age)
        //     return -1;
        // else if (x.Age > y.Age)
        //     return 1;
        // else
        //     return 0;
    }
}


public class PersonHeightComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Height.CompareTo(y.Height);
    }
}

public class PersonNameComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Name.CompareTo(y.Name);
    }
}