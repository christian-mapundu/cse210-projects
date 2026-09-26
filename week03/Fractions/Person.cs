public class Person
{
    private string _name;
    private string _firstName;
    private string _lastName;

    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }
    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }
    public string GetFullName()
    {
        return _firstName + " " + _lastName;
    }
}