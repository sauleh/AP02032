
- Student-Grade Dictionary (GetHashCode, Equals) (continued)
    Student name/id
    Grade course/credit/grade

- Dictionary slow example
- stopwatch
- getter/setter 
    - 

- getter/setter for course grade letter
- Transcript Example
    - getter
- readonly/const
- calling other constructors
- getter/setter
- operator== -->









        switch (grade.ToUpper())
        {
            case "A":
                return 4.0;
            case "B+":
                return 3.5;
            case "B":
                return 3.0;
            case "C+":
                return 2.5;
            case "C":
                return 2.0;
            case "D+":
                return 1.5;
            case "D":
                return 1.0;
            case "F":
                return 0.0;
            default:
                return -1;
        }
    
    
    private Dictionary<string, double> gradePointsMap = new Dictionary<string, double>()
    {
        { "A", 4.0 },
        { "B+", 3.5 },
        { "B", 3.0 },
        { "C+", 2.5 },
        { "C", 2.0 },
        { "D+", 1.5 },
        { "D", 1.0 },
        { "F", 0.0 }
    };

    private double GetGradePoints(string grade)
    {
        if (gradePointsMap.TryGetValue(grade.ToUpper(), out double gradePoints))
        {
            return gradePoints;
        }

        throw new ArgumentException("Invalid grade: " + grade);
    }