using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly HashSet<StudentGrade> studentGrades = [];
    public bool Add(string student, int grade) =>
        studentGrades.Add(new StudentGrade() { Grade = grade, Student = student});

    public IEnumerable<string> Roster() => 
        studentGrades
        .Order()
        .Select(sg => sg.Student);

    public IEnumerable<string> Grade(int grade) => 
        studentGrades
        .Where( sg => sg.Grade == grade)
        .Order()
        .Select( sg => sg.Student);
}

public struct StudentGrade: IComparable
{
    public int Grade;
    public string Student;

    public int CompareTo(object obj)
    {
        if (obj is StudentGrade sg)
        {
            int gradeCompare = Grade.CompareTo(sg.Grade);

            return gradeCompare == 0 ? Student.CompareTo(sg.Student) : gradeCompare;
        }

        throw new ArgumentException("Not a student grade");
    }

    public override bool Equals(object obj) => obj is StudentGrade sg && sg.Student == Student;
    public override int GetHashCode() => Student.GetHashCode();

}