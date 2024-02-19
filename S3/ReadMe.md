- حل سوال جلسه قبل
- template<typename T> function: max, min, swap (https://cppinsights.io/)
- template class: pair, liist, matrix
- Memory Management in Cpp vs C#
- Why allocate on heap
    1. Too large for stack
    2. Size unknown
    3. Needed beyond the scope
- new/delete (https://www.geeksforgeeks.org/new-vs-malloc-and-free-vs-delete-in-c/), 
    - new X[], delete [] X
- smart pointers: (https://www.internalpointers.com/post/beginner-s-look-smart-pointers-modern-c)
    - make_unique
    - make_shared (reference counting)
- copy constructor problem (shared data) (not delivered)


-   کار کلاسی اختیاری: کلاس زیر را تا هرجا که توانستید پیاده‌سازی کنید
- اگر علاقمند بودید، تغییر بدهید که بجای 
    T*
    از
    unique_ptr<T>
    استفاده شود.
    
template<typename T>
class Matrix {
private:
    T* data;
    size_t rows;
    size_t columns;

public:
    Matrix(size_t numRows, size_t numColumns);
    size_t numRows() const;
    size_t numColumns() const;
    T& at(size_t row, size_t col);
    const T& at(size_t row, size_t col) const;
    Matrix<T> add(const Matrix<T>& other) const;
    Matrix<T> multiply(const Matrix<T>& other) const;
    Matrix<T> multiply(const T& scalar) const;
    Matrix<T> transpose() const;
    void display() const;
};