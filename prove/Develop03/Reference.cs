class Reference
{
    public string _Book { get; }
    public int _StartVerse { get; }
    public int _EndVerse { get; }

    public Reference(string reference)
    {
        string[] parts = reference.Split(':');
        _Book = parts[0];
        string[] verses = parts[1].Split('-');
        _StartVerse = int.Parse(verses[0]);
        _EndVerse = verses.Length > 1 ? int.Parse(verses[1]) : _StartVerse;
    }
}
