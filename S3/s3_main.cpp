#include<memory>
#include<iostream>

using namespace std;

int main()
{
    unique_ptr<int> pint = make_unique<int>();
    unique_ptr<int> pint2(pint.release());
    return 0;
}