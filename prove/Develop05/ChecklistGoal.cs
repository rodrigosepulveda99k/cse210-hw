public class ChecklistGoal : Goal
{
    private int _currentCount;
    private readonly int _targetCount;
    private readonly int _bonusValue;

    public ChecklistGoal(string name, int value, int targetCount, int bonusValue) : base(name, value)
    {
        _currentCount = 0;
        _targetCount = targetCount;
        _bonusValue = bonusValue;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount == _targetCount)
        {
            MarkCompleted();
            return Value + _bonusValue;
        }
        return Value;
    }

    public override string DisplayStatus()
    {
        return Completed ? $"[X] {Name}" : $"Completed {_currentCount}/{_targetCount} times {Name}";
    }
}
