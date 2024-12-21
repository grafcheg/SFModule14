namespace SFModule14;

public class Contact
{
    public Contact(string name, string lastName, long phoneNumber, string email)
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name {get;}
    public String LastName {get;}
    public long PhoneNumber {get;}
    public String Email {get;}
}