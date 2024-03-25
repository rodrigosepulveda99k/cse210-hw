public class ReflectionActivity : Activity
{
    private string[] _reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
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
        StartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        DateTime startTime = DateTime.Now;
        Random rnd = new Random();
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string prompt = _reflectionPrompts[rnd.Next(_reflectionPrompts.Length)];
            Console.WriteLine(prompt);
            Pause(3);
            ReflectOnQuestions();
            if ((DateTime.Now - startTime).TotalSeconds >= _duration) break;
        }
        EndingMessage("Reflection Activity");
    }

    public void ReflectOnQuestions()
    {
        foreach (string question in _reflectionQuestions)
        {
            Console.WriteLine(question);
            Pause(3);
        }
    }
}
