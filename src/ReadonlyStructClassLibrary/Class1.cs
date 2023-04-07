using System;

public readonly struct Marvel
{
    // field
    private readonly string _name;

    public Marvel(string name)
    {
        _name = name;
    }

    // public readonly prop
    public string Name
    {
        get { return _name; }
    }

    public void PrintCharecterName()
    {
        Console.WriteLine(this.Name);
    }


}