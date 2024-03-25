public class BreathingActivity : Activity
{
    public override void SetDuration()
    {
        base.SetDuration();
    }

    public override void StartingMessage(string activityName, string description)
    {
        base.StartingMessage(activityName, description);
    }

    public override void EndingMessage(string activityName)
    {
        base.EndingMessage(activityName);
    }

    public void Execute()
    {
        StartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Breathe("Breathe in...");
            Pause(3);
            if ((DateTime.Now - startTime).TotalSeconds >= _duration) break;
            Breathe("Breathe out...");
            Pause(3);
        }
        EndingMessage("Breathing Activity");
    }

    public void Breathe(string message)
    {
        Console.WriteLine(message);
    }
}
