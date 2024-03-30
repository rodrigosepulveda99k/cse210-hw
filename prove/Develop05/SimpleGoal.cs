public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override int RecordEvent()
    {
        MarkCompleted();
        return Value;
    }

    public override string DisplayStatus()
    {
        return Completed ? $"[X] {Name}" : $"[ ] {Name}";
    }
}
