using System;


class Program
{
    static void Main(string[] args)
    {
        LectureEvent event1 = new LectureEvent("Gala Ball Lecture", "Fashion Gallery", new Address("324 W Cottenburey Ave", "Denver", "CO", "USA", 456), "7/24/19", "9:30am", "Kim Jong Un IV", 56800);
        Console.WriteLine(event1.GetFullDetails());
    }
}