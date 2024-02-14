#include<iostream>
#include<stdlib.h>

using namespace std;

class Date
{    
    int month;
    int day;
    int year;
};
class Person
{
    int m_natId;
    char m_fname[20];
    char m_lname[20];
    Date m_birthDate;
public:
    Person(const char* fname, const char* lname, int id, const Date& bDate)
    {}
};

void swap(int& a, int &b)
{
    int x = a;
    a = b;
    b = x;
}

class liist
{
    int m_size;
    int *m_pNums;

public:
    liist(): m_pNums(NULL), m_size(0)
    {

    }
    liist(const int* nums, int size)
    {
        m_size = size;
        m_pNums = (int *)malloc(size * sizeof(int));
        for (int i = 0; i < size; i++)
            m_pNums[i] = nums[i];
    }
    ~liist()
    {
        if (m_pNums != NULL)
            free(m_pNums);
    }
    int len() const {
        return m_size;
    }
    int get(int i) const
    {
        if (i < m_size)
            return m_pNums[i];
        return -1;
    }
    void add(int x)
    {
        resize(m_size + 1);
        m_pNums[m_size - 1] = x;
    }
    int count(int x)
    {
        int c = 0;
        for (int i = 0; i < m_size; i++)
            if (m_pNums[i] == x)
                c++;
        return c;
    }
    void print()
    {
        for (int i = 0; i < m_size; i++)
            cout << m_pNums[i] << endl;
    }
private:
    void resize(int newsize)
    {
        int *newMem = (int *)malloc(newsize * sizeof(int));
        for (int i = 0; i < m_size; i++)
            newMem[i] = m_pNums[i];
        free(m_pNums);
        m_pNums = newMem;
        newMem = NULL;
        m_size = newsize;
    }
};

int main()
{
    // x = []
    int nums[5] = {1, 2, 3, 4, 7};
    liist mynums(nums, 5);
    mynums.print();
    mynums.add(5);
    mynums.add(10);
    mynums.add(15);
    cout << endl;
    mynums.print();
    return 0;
}

        // Person p("ali", "hosseini", 234324324, Date());
