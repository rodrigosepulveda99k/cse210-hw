class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string referenceStr, string text)
    {
        _reference = new Reference(referenceStr);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetFormattedScripture()
    {
        return $"{_reference._Book} {_reference._StartVerse}:{_reference._EndVerse}\n" +
               string.Join(" ", _words.Select(word => word.ToString()));
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _words.Count / 2);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(0, _words.Count);
            _words[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
