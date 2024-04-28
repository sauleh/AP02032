

template<typename T> 
T add(T a, T b)
{
    return a + b;
}

class Person{};

int main()
{
    // Person p1;
    // Person p2;
    int x = add<int>(5, 4);
    // Person p3 = add<Person>(p1, p2);
}