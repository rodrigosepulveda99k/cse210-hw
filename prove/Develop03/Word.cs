class Word
{
    public string Value { get; }
    public bool IsHidden { get; set; }

    public Word(string value)
    {
        Value = value;
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Value;
    }
}
