public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = 0;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = startVerse;
        _lastVerse = endVerse;
    }

    public string GetReferenceString()
    {
        if (_lastVerse != 0) {
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
    }

}