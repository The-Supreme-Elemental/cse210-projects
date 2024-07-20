using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Running(3.0, "5/6/19", 30);
        Activity activity1 = new Cycling(30, "5/6/19", 30);
        Activity activity2 = new Swimming(2, "5/6/19", 0.796);

        List<Activity> activities = new List<Activity>();
        activities.Add(activity);
        activities.Add(activity1);
        activities.Add(activity2);

        foreach (Activity activity3 in activities)
        {
            Console.WriteLine(activity3.GetSummary());
        }

    }
}