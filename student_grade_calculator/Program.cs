using System;


public class StudentScore
{
    static int currentAssignments = 5;
    int gradeAssignments = 0;
    public decimal currentStudentExamScore = 0;
    public decimal currentStudentExtraCreditScore = 0;
    public decimal sumExtraCreditScores = 0;
    
    public decimal Avg(int[] name)
    {
        currentStudentExamScore = 0;
        currentStudentExtraCreditScore = 0;
        sumExtraCreditScores = 0;
        decimal avg = 0;
        int gradeAssignments = 0;
        int sumAssignmentScore = 0;

        foreach (int n in name)
        {
            gradeAssignments++;

            if (gradeAssignments <= currentAssignments)
            {
                sumAssignmentScore += n;
                if (gradeAssignments == currentAssignments)
                {
                    currentStudentExamScore += ((decimal)sumAssignmentScore / currentAssignments);
                }
            }
            else {
                currentStudentExtraCreditScore += n;
                sumAssignmentScore += (n / 10);
            }
        }
        sumExtraCreditScores = ((decimal)currentStudentExtraCreditScore / 10) / 5;
        currentStudentExtraCreditScore = (decimal)currentStudentExtraCreditScore / (gradeAssignments - currentAssignments);

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
        StudentScore score = new StudentScore();
        StudentGrade grade = new StudentGrade();

        string[] studentName = { "sophia", "nicolas", "zahirah", "jeong", "Becky", "Chris", "Eric", "Gregor" };

        int[] sophiaScore = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] nicolasScore = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] zahirahScore = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] jeongScore = new int[] { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

        decimal studentScore = 0;
        string studentGrade = "";

        Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

        foreach (string name in studentName)
        {
            if (name == "sophia")
            {
                studentScore = score.Avg(sophiaScore);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "nicolas")
            {
                studentScore = score.Avg(nicolasScore);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "zahirah")
            {
                studentScore = score.Avg(zahirahScore);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "jeong")
            {
                studentScore = score.Avg(jeongScore);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "Becky")
            {
                studentScore = score.Avg(beckyScores);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "Chris")
            {
                studentScore = score.Avg(chrisScores);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "Eric")
            {
                studentScore = score.Avg(ericScores);
                studentGrade = grade.studentGrade(studentScore);
            }
            else if (name == "Gregor")
            {
                studentScore = score.Avg(gregorScores);
                studentGrade = grade.studentGrade(studentScore);
            }

            Console.WriteLine($"{name}\t\t{score.currentStudentExamScore}\t\t{studentScore}\t{studentGrade}\t{score.currentStudentExtraCreditScore}\t{score.sumExtraCreditScores}");
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}
