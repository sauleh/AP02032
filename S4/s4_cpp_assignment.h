#include <iostream>
#include <string>
#include <vector>

class Student {
    friend class Course;
private:
    std::string name;
    std::vector<int> grades;

public:
    Student(const std::string& studentName){
    }

    void addGrade(int grade) {
    }

    double getAverageGrade() const {
    }

    std::string getName() const {
    }
};

class Course {
private:
    std::string courseName;
    std::string instructorName;
    std::vector<Student> students;

public:
    Course(const std::string& name, const std::string& instructor){}

    void addStudent(const Student& student) {}

    double getCourseAverage() const {
    }

    std::string displayStudentGrades(const std::string& studentName) const {
    }
};

class Instructor {
private:
    std::string instructorName;
    Course& course;

public:
    Instructor(const std::string& name, Course& courseObj)
    {}
    
    void changeGrade(const std::string& studentName, int newGrade) {
    }
};

int main() {
    Course course("Programming 101", "John Doe");

    Student student1("Alice");
    student1.addGrade(90);
    student1.addGrade(85);
    student1.addGrade(95);
    course.addStudent(student1);

    Student student2("Bob");
    student2.addGrade(75);
    student2.addGrade(80);
    student2.addGrade(70);
    course.addStudent(student2);

    // Calculate and display the average grade for the course
    double courseAverage = course.getCourseAverage();
    std::cout << "Average grade for the course: " << courseAverage << std::endl;

    // Display grades for a specific student
    course.displayStudentGrades("Alice");

    // Instructor changes a student's grade
    Instructor instructor("Jane Smith", course);
    instructor.changeGrade("Bob", 85);

    // Display updated grades for the student
    course.displayStudentGrades("Bob");

    return 0;
}