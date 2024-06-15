using System.Security.Cryptography.X509Certificates;

class Listing : Activity
{
    public Listing(string titleParam, string descParam) : base(titleParam, descParam)
    {
        
    }

    public void InteractListing()
    {

    }

    public override void Run()
    {
        GetDuration();
        makeAnimation(2);
        
    }
}