#include <iostream>
#include <math.h>

using namespace std;

class PositivePoint
{
private:
    int m_x; // Member variable
    int m_y;
    bool m_values_arevalid;


public:
    PositivePoint(int x, int y)
    {
        m_values_arevalid = true;
        m_x = 0;
        m_y = 0;
        if (x > 0)        
            m_x = x;
        if (y > 0)
            m_y = y;
        m_values_arevalid = (m_x > 0) && (m_y > 0);
    }

    PositivePoint(const PositivePoint& p) // const correctness
    {
        m_x = p.m_x;
        m_y = p.m_y;
    }

    ~PositivePoint()
    {
        print();
        cout << "Destructor Called" << endl;
    }

    int get_X() { return m_x; }
    int get_Y() { return m_y; }

    void set_X(int x)
    {
        if (x > 0)
            m_x = x;        
    }
    void set_Y(int y)
    {
        if (y > 0)
            m_y = y;
    }

    void print()
    {
        if (! m_values_arevalid) 
        {
            cout << "invalid coordinate" << endl;
            return;
        }

        cout << "the point has x = " << m_x << " and y = " << m_y << endl;
    }

    double diff(PositivePoint p)
    {
        if (m_values_arevalid && p.m_values_arevalid)
        {
            double xdiff = m_x - p.m_x;
            double ydiff = m_y - p.m_y;
            return sqrt(xdiff * xdiff + ydiff * ydiff);
        }
        return 0;
    }

    bool are_equal(PositivePoint p)
    {
        return (m_x == p.m_x) && (m_y == p.m_y);
    }
};

class Circle
{
// مرکز Point
// شعاع double
public:
    Circle(Point p, double r);
    double Circumference();
    double Area();
    double DistanceTo(const Circle &c);
    double DistanceTo(const Point &p);
};

class Triangle
{
    PositivePoint m_p1;
    PositivePoint m_p2;
    PositivePoint m_p3;

public:
    Triangle(PositivePoint p1, PositivePoint p2, PositivePoint p3) 
        : m_p1(p1)
        , m_p2(p2)
        , m_p3(p3)
    {
    }
};

int main()
{
    int x;
    cin >> x;
    PositivePoint p1(4, 4);
    if (x % 2 == 0)
    {
        p1.print();
        PositivePoint p7(9, 9);
        p7.print();
    } else {
        PositivePoint p1(91, 91);
        p1.print();
    }
    p1.print();
    cin >> x;
    cout << x << endl;
    return 0;
}

int main883()
{
    PositivePoint p1(2, 3);
    // p1.m_x = -5;
    // p1.m_y = -6;
    p1.set_X(-5);
    p1.set_Y(-6);
    p1.print();
    p1.set_X(12);
    p1.print();
    cout << p1.get_X() << endl;
    cout << p1.get_Y() << endl;
    PositivePoint p2(4, 7);
    p2.print();
    double d1 = p1.diff(p2);
    double d2 = p2.diff(p1);
    cout << d1 << endl;
    cout << d2 << endl;

    PositivePoint p3(p1);
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