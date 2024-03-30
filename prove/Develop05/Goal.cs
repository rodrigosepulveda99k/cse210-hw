public abstract class Goal
{
    public string Name { get; }
    public int Value { get; }
    public bool Completed { get; private set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Completed = false;
    }

    public abstract int RecordEvent();
    public abstract string DisplayStatus();

    protected void MarkCompleted()
    {
        Completed = true;
    }
}