- مرور جلسه گذشته
    - OOP
    - Object/Class
    - Constructor/Destructor
        - Empty Constructor
        - Copy Constructor
    - const correctness
    - pass-by-reference
    - Member Function/Variable
    - Getter/Setter pattern
    - public/private

- حل کار کلاسی جلسه گذشته
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

- مثال جدید با
    - Person
    - Car
    - BankAccount
- https://cppinsights.io/
- RAII pattern
    - https://en.cppreference.com/w/cpp/language/raii
    - https://en.wikipedia.org/wiki/Resource_acquisition_is_initialization
- مثال لیست
    - class liist {
        liist();
        liist(int* nums, int count);
        liist(const liist& other);
        void add(int i);
        void remove(int loc);
        int get(int loc);
    }
    - template
- کار کلاسی
    class str {
    public:
        str();
        str(const char* pch);
        str(const str& s);
        int len() const;
        void append(const char* pch);
        void append(const str& s);
        void print() const;
        const char* chars() const;
        void replace(char c1, char c2);
        str substr(int start, int count) const;
        void remove(int start, int count);
        str reverse() const;
        char get_char(int loc) const;
    }

- کلاس جبرانی چهارشنبه 
