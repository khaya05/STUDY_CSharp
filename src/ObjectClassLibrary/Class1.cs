public class Person
{
    public string PersonName { get; set; }
    public string Email { get; set; }

    // override equals method

    public override bool Equals(object obj)
    {
        Person p = (Person)obj;
        if(this.PersonName == p.PersonName && this.Email == p.Email)
        {
            return true;
        }
        return false;
    }

    //overriding toString method
    public override string ToString()
    {
        return "person name: " + this.PersonName;
    }
}