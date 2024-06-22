using System.Security.Cryptography.X509Certificates;

class Listing : Activity
{
    public Listing(string titleParam, string descParam) : base(titleParam, descParam)
    {
        
    }

    public void InteractListing()
    {
        List<string> prompts = new List<string>()
        {
            "Think of a time you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",


            Random
        };
    }

    public override void Run()
    {
        GetDuration();
        makeAnimation(_duration);
        
    }
}