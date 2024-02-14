#include<math.h>
#include<iostream>

using namespace std;

class Point
{
public:
    int m_X;
    int m_Y;
    Point(int x, int y)
    {
        m_X = x;
        m_Y = y;
    }
    double DistanceTo(const Point& p) const
    {
        double xdiff = m_X - p.m_X;
        double ydiff = m_Y - p.m_Y;
        return sqrt(xdiff * xdiff + ydiff * ydiff);
    }
};

class Circle
{
    Point m_center;
    double m_radius;

public:
    Circle(const Point &p, double r)
        : m_center(p)
        , m_radius(r)
    {}

    double Circumference()
    {
        return m_radius * 2 * M_PI;        
    }
    double Area()
    {
        return m_radius * m_radius * M_PI;
    }

    double DistanceTo(const Circle &c) const
    {
        return DistanceTo(c.m_center);
    }
    double DistanceTo(const Point &p) const
    {
        return p.DistanceTo(m_center);
    }
};

int main()
{
    Point p(1, 1);
    Circle c(Point(5, 2), 4);
    Circle c2(Point(1, 2), 3);

    cout << c.DistanceTo(p) << endl;
    cout << c.DistanceTo(c2) << endl;

    return 0;
}