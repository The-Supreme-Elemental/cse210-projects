
// Class Job
public class Job
{

    // Attribute
    public string _company {get; set;}
    public string _jobTitle {get; set;}
    public int _startYear {get; set;}
    public int _endYear {get; set;}

    public string display() 
    {
        return $"{_jobTitle} ({_company}) {_startYear}-{_endYear}";
    } 
}