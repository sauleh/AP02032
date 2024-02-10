
- موضوع درس برنامه‌سازی پیشرفته
- اصل DRY (Do Not Repeat Yourself) (https://en.wikipedia.org/wiki/Don%27t_repeat_yourself)
- اصول SOLID (https://en.wikipedia.org/wiki/SOLID)
   - Single Responsibility Principle
   - Open/Close Principle
   - Liskov Substitution Principle
   - Interface Segregation Principle
   - Dependency Inversion Principle
- برنامه‌نویسی شی‌‌گرا چیست
- تفاوت‌های سی و سی‌پلاس‌پلاس
- کلاس و استراکت
- متغیر/تابع عضو (member variable and member function)
- سازنده (constructor) و مخرب (destructor)
- مثال کلاس Point
    - equality
    - ...
- مثال کلاس Circle
- 
- طول عمر یک شیء
- public/private

کار کلاسی
در پوشه C1

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