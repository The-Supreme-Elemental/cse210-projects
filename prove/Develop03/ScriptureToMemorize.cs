public class ScriptureToMemorize
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private bool _completeyHidden;

    public ScriptureToMemorize()
    {
        _reference = new Reference("1 Nephi", 3, 7);
        string goAndDo = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ";
        string[] strings = goAndDo.Split(" ");
        foreach (string s in strings)
        {
            _words.Add(new Word(s));
        }
    }

    public void HideRandomWord()
    {
        if (CompleteyHidden() == false)
        {
            Random random = new Random();
            int number = random.Next(_words.Count());
            Word hiddenWord = _words[number];
            while (hiddenWord.IsRevealed() != true)
            {
                number = random.Next(_words.Count());
                hiddenWord = _words[number];
            }
            hiddenWord.Hide();

        }
        
        
    }

    public string GetText()
    {
        string result = _reference.GetReferenceString();
        foreach (Word word in _words)
        {
            result += " ";
            result += word.GetWord();
        }
        return result;
    }

    public bool CompleteyHidden()
    {
        _completeyHidden = true;

        foreach (Word word in _words)
        {
            if (word.IsRevealed())
            {
                _completeyHidden = false;
            }
        }
        return _completeyHidden;
    }
}