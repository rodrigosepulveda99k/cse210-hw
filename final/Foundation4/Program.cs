using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Activity runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity bicycleActivity = new StationaryBicycle(new DateTime(2022, 11, 4), 45, 20);
        Activity swimmingActivity = new Swimming(new DateTime(2022, 11, 5), 60, 10);

        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(bicycleActivity);
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
