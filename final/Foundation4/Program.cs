using System;

class Program
{
    static void Main(string[] args)
    {
        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2024, 2, 1), 30, 3);
        RunningActivity runningActivity = new RunningActivity(new DateTime(2024, 2, 1), 10, 3.0f);
        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2024, 2, 1), 20, 4.0f);

        List<Activity> activities = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}