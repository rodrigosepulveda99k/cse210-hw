public class Activity
{
    protected int _duration;

    public virtual void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public virtual void StartingMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public virtual void EndingMessage(string activityName)
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {activityName} for {_duration} seconds.");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
