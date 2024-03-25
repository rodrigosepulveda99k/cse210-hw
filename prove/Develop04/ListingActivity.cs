public class ListingActivity : Activity
{
    private string[] _listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

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
        StartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        DateTime startTime = DateTime.Now;
        Random rnd = new Random();
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string prompt = _listingPrompts[rnd.Next(_listingPrompts.Length)];
            Console.WriteLine(prompt);
            Pause(3);
            ListItems();
            if ((DateTime.Now - startTime).TotalSeconds >= _duration) break;
        }
        EndingMessage("Listing Activity");
    }

    public void ListItems()
    {
        List<string> items = new();
        Console.WriteLine("Start listing items (type 'done' to finish):");
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            items.Add(item);
        }
        Console.WriteLine($"Number of items listed: {items.Count}");
    }
}
