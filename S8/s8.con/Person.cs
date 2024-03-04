namespace s8.con;

class Person {
    // public static bool IsEqual(Person p, object o)
    // { }
    public string Name;
    public int Id;
    public void Graduate() { }

    public override string ToString()
    {
        return $"{this.Id} : {this.Name}";
    }

    public override bool Equals(object obj)
    {
        if (obj is not Person)
            return false;

        Person other = obj as Person;
        return (other.Id == Id) && (other.Name == Name);
    }
}