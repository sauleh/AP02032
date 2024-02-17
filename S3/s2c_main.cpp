#include<iostream>

class str {
    char *m_pch;
    int size;

public:
    str();
    str(const char* pch);
    str(const char* pch, int start, int count)
    {
        m_pch = (char *)malloc((sizeof(char)) * (count+1));
        for (int i = 0; i < count; i++)
            m_pch[i] = pch[start + i];
        m_pch[count] = 0;
    }
    str(const str& s);
    int len() const;
    void append(const char* pch);
    void append(const str& s);
    void print() const;
    const char* chars() const;
    void replace(char c1, char c2);
    str substr(int start, int count) const
    {
        return str(m_pch, start, count);
    }
    str* substr2(int start, int count) const
    {
        str* px = new str(m_pch, start, count);
        return px;
    }   
    str& substr3(int start, int count) const
    {
        str x(m_pch, start, count);
        return x;
    }      
    void remove(int start, int count)
    {
        for (int i = 0; i < size-(start+count); i++)
        {
            m_pch[start + i] = m_pch[start + count + i];
        }

        for (int i = start+count; i < size; i++)
        {
            m_pch[i - count] = m_pch[i];
        }

        for (int i = start; i < size-count; i++)
        {
            m_pch[i] = m_pch[i+count];
        }
        m_pch[size - count + 1] = 0;
        size -= count;
    }
    str reverse() const;
    char get_char(int loc) const;
};