public class Word
{
    private string _word;
    
    private bool _revealed;

    public Word()
    {
        _word = "";
        _revealed = true;
    }

    public Word(string word)
    {
        _word = word;
        _revealed = true;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool IsRevealed()
    {
        return _revealed;
    }

    public void Hide()
    {
        _revealed = false;
        _word = "____";
    }
}