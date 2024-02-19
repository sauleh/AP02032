#include<vector>
#include<memory>
#include<string>
#include<iostream>
#include<string.h>
using namespace std;

class str
{
    char *m_pch;
    int m_len;
    shared_ptr<char> m_spch;

public:
    str(const str& other)
    {
        m_len = other.m_len;
        m_pch = new char[m_len+1];
        memcpy(m_pch, other.m_pch, m_len);
        m_pch[m_len] = 0;
    }

    ~str()
    {
        delete[] m_pch;
    }

    str(char* pch)
    {
        m_len = strlen(pch);
        m_pch = (char *)malloc(m_len + 1);
        memcpy(m_pch, pch, m_len);
        m_pch[m_len] = 0;
    }
    void print()
    {
        cout << m_pch << endl;
    }
    void setchar(int x, char c)
    {
        m_pch[x] = c;
    }
};

int main()
{
    string s("test");
    s += " ddfd";
    string x = s.substr(1, 3);
    char c = s[1];
    cout << s;
    cin >> s;
    int l = s.size();
    string w = s + "sfdf";
    string x = s + "sdfd" + "dkfjdlk";

    vector<int> vNums = {1, 5, 4};
    vNums.push_back(5);
    vNums.push_back(4);
    int x = vNums[1];
    

    return 0;
}

int main8()
{
    char name[10] = "arzhang";
    str sname(name);
    sname.print();
    str lname(sname);
    lname.print();
    sname.setchar(0, 'z');
    sname.print();
    lname.print();

    str *pname = new str(name);
    str *pname2 = pname;

    shared_ptr<str> spname1 = make_shared<str>(name);
    shared_ptr<str> spname2 = spname1;
    spname1.reset();
    return 0;
}



class Student {
};
int main7()
{
    Student s1;
    shared_ptr<Student> s = make_shared<Student>();
    int *n = new int;
    shared_ptr<shared_ptr<int>> pi = 
        make_shared<shared_ptr<int>>();

    auto ppi = pi;

    int *p1 = new int[5];
    int *p2 = p1;
    int x;
    int y;
    if (5 == 10)
    {
       auto s = make_shared<Student>();     
    }

    return 0;
}