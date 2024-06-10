public class Person 
{
    public string firstName;
    public string lastName;


    public Person() 
    {
        Console.WriteLine("What is your first name? ");
        firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        lastName = Console.ReadLine();
    }

}