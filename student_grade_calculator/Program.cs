using System;


public class Average
{
    static int currentAssignments = 5;
    int gradeAssignments = 0;
    public decimal Avg(int[] name)
    {
        decimal avg = 0;
        int gradeAssignments = 0;
        int sumAssignmentScore = 0;

        foreach (int n in name)
        {
            gradeAssignments++;

            if (gradeAssignments <= currentAssignments) sumAssignmentScore += n;
            else sumAssignmentScore += n/10;
            
        }
        
        avg = (decimal)sumAssignmentScore / currentAssignments;
        return avg;
    }
}

public class StudentGrade
{
    public string studentGrade(decimal average)
    {
        if (average > 96 && average <= 100) return "A+";
        else if (average > 92 && average <= 96) return "A";
        else if (average > 89 && average <= 92) return "A-";
        else if (average > 86 && average <= 89) return "B+";
        else if (average > 82 && average <= 86) return "B";
        else if (average > 79 && average <= 82) return "B-";
        else if (average > 76 && average <= 79) return "C+";
        else if (average > 72 && average <= 76) return "C";
        else if (average > 69 && average <= 72) return "C-";
        else if (average > 66 && average <= 69) return "D+";
        else if (average > 62 && average <= 66) return "D";
        else if (average > 59 && average <= 62) return "D-";
        else return "F";
    }
}
public class Program
{
    public static void Main(String[] args)
    {
        Average average = new Average();
        StudentGrade grade = new StudentGrade();

        string[] studentName = { "sophia", "nicolas", "zahirah", "jeong", "Becky", "Chris", "Eric", "Gregor"};

        int[] sophiaScore = new int[]{ 90, 86, 87, 98, 100, 94, 90 };
        int[] nicolasScore = new int[]{ 80, 83, 82, 88, 85, 93, 92 };
        int[] zahirahScore = new int[]{ 84, 96, 73, 85, 79, 100, 93 };
        int[] jeongScore = new int[]{ 90, 92, 98, 100, 97, 92, 100 };
        int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 }; 

        decimal studentScore = 0;
        string studentGrade = "";

        Console.WriteLine("Student\t\tGrade\n");

        foreach (string name in studentName)
        {
            if (name == "sophia")
            {
                studentScore = average.Avg(sophiaScore);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "nicolas")
            {
                studentScore = average.Avg(nicolasScore);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "zahirah")
            {
                studentScore = average.Avg(zahirahScore);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "jeong")
            {
                studentScore = average.Avg(jeongScore);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "Becky")
            {
                studentScore = average.Avg(beckyScores);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "Chris")
            {
                studentScore = average.Avg(chrisScores);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "Eric")
            {
                studentScore = average.Avg(ericScores);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "Gregor")
            {
                studentScore = average.Avg(gregorScores);
                studentGrade = grade.studentGrade(studentScore);
            }
            
            Console.WriteLine($"{name}\t\t{studentScore}\t{studentGrade}");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}
