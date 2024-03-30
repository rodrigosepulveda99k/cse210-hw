public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override int RecordEvent()
    {
        return Value;
    }

    public override string DisplayStatus()
    {
        return Completed ? $"[X] {Name}" : $"[ ] {Name}";
    }
}
