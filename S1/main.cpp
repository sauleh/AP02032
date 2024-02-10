#include <iostream>
#include <math.h>

using namespace std;

class Point
{
public:
    int m_x; // Member variable
    int m_y;

    Point(int x, int y)
    {
        m_x = x;
        m_y = y;
    }

    Point(const Point& p) // const correctness
    {
        m_x = p.m_x;
        m_y = p.m_y;
    }

    void print()
    {
        cout << "the point has x = " << m_x << " and y = " << m_y << endl;
    }

    double diff(Point p)
    {
        double xdiff = m_x - p.m_x;
        double ydiff = m_y - p.m_y;
        return sqrt(xdiff * xdiff + ydiff * ydiff);
    }

    bool are_equal(Point p)
    {
        return (m_x == p.m_x) && (m_y == p.m_y);
    }
};


int main()
{
    Point p1(2, 3);
    p1.print();
    Point p2(4, 7);
    p2.print();
    double d1 = p1.diff(p2);
    double d2 = p2.diff(p1);
    cout << d1 << endl;
    cout << d2 << endl;

    Point p3(p1);
    return 0;
}


// int main()
// {
//     Point p1;
//     p1.print();
//     p1.m_x = 2;
//     p1.m_y = 3;
//     Point p2;
//     p2.print();
//     p2.m_x = 4;
//     p2.m_y = 7;

//     p1.print();
//     p2.print();
//     double d1 = p1.diff(p2);
//     double d2 = p2.diff(p1);
//     cout << d1 << endl;
//     cout << d2 << endl;
//     return 0;
// }

// int main55()
// {
//     Point p;
//     p.m_x = 2;
//     p.m_y = 3;
//     // cout << "enter x? " ;
//     // cin >> p.m_x;
//     // cout << "enter y? ";
//     // cin >> p.m_y;

//     Point p2;
//     p2.m_x = 4;
//     p2.m_y = 7;

//     // print_point(p);
//     p.print();

//     // double d = point_diff(p, p2);
//     double d = p.diff(p2);
//     cout << d << endl;
//     return 0;
// }

// // void print_point(Point p)
// // {
// //     cout << "the point has x = " << p.m_x << " and y = " << p.m_y << endl;
// // }

// // double point_diff(Point p1, Point p2)
// // {
// //     double xdiff = p1.m_x - p2.m_x;
// //     double ydiff = p1.m_y = p2.m_y;
// //     return sqrt(xdiff * xdiff + ydiff * ydiff);
// // }

// // bool are_equal(Point p1, Point p2)
// // {
// //     return (p1.m_x == p2.m_x) && (p1.m_y == p2.m_y);
// // }