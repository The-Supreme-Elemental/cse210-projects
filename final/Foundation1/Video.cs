public class Video
{
    private string _title;
    private string _author;
    private uint _length;
    private List<Comment> _comments;

    public Video(string title, string author, uint length)
    {
        _comments = new List<Comment>();
        _title = title;
        _author = author;
        _length = length;

    }

    public void StoreComment(string account, string text)
    {
        Comment commentText = new Comment(account, text);
        _comments.Add(commentText);
    }

    public int GetCommentCount()
    {
        int number = _comments.Count();
        return number;
    }

    public uint GetLengthMinutes()
    {
        return _length / 60;
    }

    public uint GetLengthSeconds()
    {
        return _length % 60;
    }

    public void Report()
    {

        Console.WriteLine($"\n{_title}, {_author}, {GetLengthMinutes()} minutes and {GetLengthSeconds()} seconds.:");
        int commentNumber = GetCommentCount();
        Console.WriteLine($"There are {commentNumber} comments for this video. They are displayed below.");
        foreach (Comment commentText in _comments)
        {
            Console.WriteLine($"{commentText.GetAccount()}: {commentText.GetText()}");
        }

    }
}