#include<stdio.h>

class autofile
{
private:
    FILE *m_handle;

public:
    autofile(char* filename)
    {
        m_handle = fopen(filename, "r");
    }

    ~autofile()
    {
        close(m_handle);
    }
};

void main()
{
    autofile af("test.txt");

    if (..) {
        return;
    }
    else if (...)
    {
        return;
    }
}


// void main()
// {
//     FILE* f = fopen("test.txt", "r");

//     if (..) {
//         clsoe(f);
//         return;
//     }
//     else if (...)
//     {
//         close(f);
//         return;
//     }

//     close(f);
// }