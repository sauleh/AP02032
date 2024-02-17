#include<memory>
#include<iostream>

using namespace std;

// template<typename Tx, typename Ty>
// class MyPair
// {
//     Tx m_x;
//     Ty m_y;
// public:
//     MyPair()
//     {
//     }

//     MyPair(Tx x, Ty y)
//         :m_x(x)
//         ,m_y(y)
//     {}
//     Tx &getX() { return m_x; }
//     Ty &getY() { return m_y; }
// };

int max(int x, int y)
{
    return x > y ? x : y;
}

template<typename T>
T maxt(T x, T y)
{
    return x > y ? x : y;
}

// template<typename Tx, typename Ty>
// MyPair<Tx, Ty>* MakePair(Tx x, Ty y)
// {
//     MyPair<Tx,Ty>* x = new MyPair<Tx, Ty>(x, y);
//     return x;
// }

class student
{
public:
    char* m_name;
    int m_id;    
    student(char* pch, int id)
    {
        cout << "construtor called " << endl;
        m_id = id;
        // char *pp = pch;
        // int c = 0;
        // while (*pp)
        // {
        //     c++;
        //     pp++;
        // }
        // m_name = new char[c + 1];
        // pp = pch;
        // while (pch)
        // {
        //     *pp = *pch;
        //     pp++;
        //     pch++;
        // }
        // *pp = 0;
    }
    ~student()
    {
        cout << "destructor called" << endl;
        delete[] m_name;
    }
};

int main()
{
    char name[100] = "ali";
    shared_ptr<student> s = make_shared<student>(name, 402521);
    cout << s.get()->m_id << endl;
    student *ps = new student(name, 5);
    student *ps2 = (student *)malloc(sizeof(student));
    ps2->m_id = 5;
    free(ps2);
    shared_ptr<student> s2 = s;
    cout << s2.get()->m_id << endl;
    cout << s.get()->m_id << endl;
    cout << s2.use_count() << endl;
    shared_ptr<student> s3 = s;
    cout << s.use_count() << endl;
    s2.reset();
    cout << s.use_count() << endl;
    return 0;
}

int main4555()
{
    char name[100] = "ali";
    unique_ptr<student> s = make_unique<student>(name, 402521);
    cout << s.get()->m_id << endl;
    unique_ptr<student> s2(s.release());
    cout << s2.get()->m_id << endl;
    // cout << s.get()->m_id << endl;
    
    return 0;
}

int mai4n4()
{
    // int *pi = new int[25];
    // delete[] pi;
    // MyPair<int, double>  grade(402521321, 19.5);
    // cout << grade.getX() << "---" << grade.getY() << endl;

    // MyPair<int, double>* pg =  MakePair(402521321, 19.5);
    
    // delete pg;


    // MyPair<int, double> p;


    int x = 5;
    int y = 6;
    double xx = 5.5;
    double yy = 6.6;
    x = maxt(x, y);
    xx = maxt(xx, yy);
    return 0;
}