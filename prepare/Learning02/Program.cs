using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Constructor
        Job myJob = new() 
        {
            _company = "Microsoft",
            _jobTitle = "Software Engineer",
            _startYear = 2019,
            _endYear = 2022

        };
        Job secondJob = new()
        {
            _company = "Apple",
            _jobTitle = "Manager",
            _startYear = 2022,
            _endYear = 2023
        };

        Resume resume = new()
        {
            _personName = "Allison Rose"
        };



        resume._list_Of_Jobs.Add(myJob);
        resume._list_Of_Jobs.Add(secondJob);

        // Displays the name of the person.
        Console.WriteLine(resume._personName);
        Console.WriteLine("Jobs:");

        // Iterates through every job instance and displays them.
        foreach (Job job in resume._list_Of_Jobs) 
        {
            Console.WriteLine(job.display());

        }
        
    }
}