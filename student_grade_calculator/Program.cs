using System;
public class StudentInfor
{
    public static int currentAssignments = 5;

    public int[] sophia = { 93, 87, 98, 95, 100 };
    public int[] nicolas = { 80, 83, 82, 88, 85 };
    public int[] zahirah = { 84, 96, 73, 85, 79 };
    public int[] jeong = { 90, 92, 98, 100, 97 };

}

public class ScoreAverage
{
    public decimal Avg(int[] name)
    {
        decimal avg = 0;
        int sum = 0;
        foreach(int n in name)
        {
            sum += n;
        }
        avg = (decimal)sum / StudentInfor.currentAssignments;
        return avg;
    }
}

public class StudentGrade
{
    public char stdGrade(decimal scAvg)
    {       
        if(scAvg >=70 && scAvg < 80)return 'C';
        else if(scAvg >=80 && scAvg < 90)return 'B';
        else if(scAvg >=90 && scAvg < 100)return 'A';
        else return 'F';
    }
}
public class Program
{
    public static void Main(String[] args)
    {
        StudentInfor std = new StudentInfor();
        ScoreAverage avg = new ScoreAverage();
        StudentGrade grad = new StudentGrade();

        char sophiaGrade = grad.stdGrade(avg.Avg(std.sophia));
        char nicolasGrade = grad.stdGrade(avg.Avg(std.nicolas));
        char zahirahGrade = grad.stdGrade(avg.Avg(std.zahirah));
        char jeongGrade = grad.stdGrade(avg.Avg(std.jeong));
        
        Console.WriteLine("Sophia: " + sophiaGrade);
        Console.WriteLine("Nicolas: " + nicolasGrade);
        Console.WriteLine("Zahirah: " + zahirahGrade);
        Console.WriteLine("Jeong: " + jeongGrade);
    }
}

