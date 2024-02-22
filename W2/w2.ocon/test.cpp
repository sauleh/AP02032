#include<string>

using namespace std;

int x;
int myfun(int n)
{
    return n + 1;
}

class Student
{
    double m_grade;
    string m_name;
    int m_id;
    static double s_maxgrade;

public:
    Student(int id, const string& name)
        : m_name(name)
        , m_id(id)
    {}

    void set_grade(double g)
    {
        m_grade = g;
    }

    double get_standardgrade()
    {
        return m_grade / s_maxgrade;
    }

    double get_grade()
    {
        return m_grade;
    }


    static void set_maxgrade(double d)
    {
        s_maxgrade = d;
    }
};

double Student::s_maxgrade = 0;

int main(int argc, char** argv)
{
    Student s(402521, "ali");
    s.set_grade(19.5);

    Student::set_maxgrade(20);

    return 0;
}

