using System;


class Program
{
    static void Main(string[] args)
    {
        LectureEvent event1 = new LectureEvent("Gala Ball Lecture", "Fashion Gallery", new Address("324 W Cottenburey Ave", "Denver", "CO", "USA", 456), "7/24/19", "9:30am", "Kim Jong Un IV", 56800);
        OutdoorEvent outdoorEvent = new OutdoorEvent("Zone Conference", "zone conference", new Address("324 W Cottenburey Ave", "Denver", "CO", "USA", 456), "724/21", "6:30pm", "Sunny, with a chance of clouds.");
        ReceptionEvent reception = new ReceptionEvent("K&J Wedding Reception", "Reception for K&J", new Address("324 W Cottenburey Ave", "Denver", "CO", "USA", 456), "12/13/22", "3:00pm", "kandjharrisRSVP@gmail.com");
        
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
    }
}