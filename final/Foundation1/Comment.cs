public class Comment
{
    private string _account;
    private string _text;

    public Comment(string account, string text)
    {
        _account = account;
        _text = text;
    }
    public string GetAccount()
    {
        return _account;
    }

    public string GetText()
    {
        return _text;
    }
}