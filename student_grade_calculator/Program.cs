using System;


public class Average
{
    int currentAssignments = 5;

    public decimal Avg(int[] name)
    {
        decimal avg = 0;
        int sum = 0;
        foreach (int n in name)
        {
            sum += n;
        }
        avg = (decimal)sum / currentAssignments;
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

        string[] studentName = { "sophia", "nicolas", "zahirah", "jeong" };

        int[] sophia = { 93, 87, 98, 95, 100 };
        int[] nicolas = { 80, 83, 82, 88, 85 };
        int[] zahirah = { 84, 96, 73, 85, 79 };
        int[] jeong = { 90, 92, 98, 100, 97 };

        decimal studentScore = 0;
        string studentGrade = "";

        Console.WriteLine("Student\t\tGrade\n");

        foreach (string name in studentName)
        {
            if (name == "sophia")
            {
                studentScore = average.Avg(sophia);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "nicolas")
            {
                studentScore = average.Avg(nicolas);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "zahirah")
            {
                studentScore = average.Avg(zahirah);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "jeong")
            {
                studentScore = average.Avg(jeong);
                studentGrade = grade.studentGrade(studentScore);
            }
            
            Console.WriteLine(@$"{name}:        {studentScore}  {studentGrade}");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}
