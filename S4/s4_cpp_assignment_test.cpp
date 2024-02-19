#define DOCTEST_CONFIG_IMPLEMENT_WITH_MAIN
#include "doctest.h"
#include<iostream>
#include "s4_cpp_assignment.h"


TEST_CASE("Student class") {
    Student student("Alice");

    SUBCASE("Test initial average grade") {
        CHECK(student.getAverageGrade() == 0.0);
    }

    SUBCASE("Test adding grades and average calculation") {
        student.addGrade(90);
        student.addGrade(85);
        student.addGrade(95);

        CHECK(student.getAverageGrade() == doctest::Approx(90.0));
    }
}

TEST_CASE("Course class") {
    Course course("Programming 101", "John Doe");

    SUBCASE("Test initial course average") {
        CHECK(course.getCourseAverage() == 0.0);
    }

    SUBCASE("Test adding students and course average calculation") {
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

        CHECK(course.getCourseAverage() == doctest::Approx(82.5));
    }

    SUBCASE("Test displaying student grades") {
        Student student("Alice");
        student.addGrade(90);
        student.addGrade(85);
        student.addGrade(95);
        course.addStudent(student);

        std::string output = course.displayStudentGrades("Alice");
        CHECK(output == "Grades for Alice:\n90 85 95 \n");

        output = course.displayStudentGrades("Bob");
        CHECK(output == "Student not found.");
    }
}

TEST_CASE("Instructor class") {
    Course course("Programming 101", "John Doe");

    Student student("Bob");
    student.addGrade(75);
    student.addGrade(80);
    student.addGrade(70);
    course.addStudent(student);

    Instructor instructor("Jane Smith", course);
    instructor.changeGrade("Bob", 85);

    std::string output = course.displayStudentGrades("Bob");
    CHECK(output == "Grades for Bob:\n75 80 70 85 \n");
}
