using System;

class Program
{
    
    
    
    
    static void Main(string[] args)
    {
        Assignment myAssignment = new("Samuel Bennet", "Multiplication");
        MathAssignment mathAssignment = new("Mark Anthony", "Calculus", "13.5", "45-87, odd");
        WritingAssignment writingAssignment = new("Mary Waters", "European History", "The Causes of World War II");

        // string summary = myAssignment.GetSummary();
        // string summary = mathAssignment.GetHomeworkList();
        string summary = writingAssignment.GetWritingInformation();
        Console.WriteLine(summary);
    }



}