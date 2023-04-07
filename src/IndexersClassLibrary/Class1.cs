using System;

public class Car
{
    // private
    private string[] _brands = new string[] { "BMW", "Skoda", "Honda" };
    private string[] _names = new string[] { "first", "second", "third" };

    // publuc indexer
    public string this[int index]
    {
        set
        {
            this._brands[index] = value;
        }
        get 
        { 
            return this._brands[index];
        }
    }

    // indexer overloading
    public string this[string name]
    {
        set
        {
            this._brands[Array.IndexOf(this._names, name)] = value;
        }

        get
        {
            return _brands[Array.IndexOf(_names, name)];
        }
    }
}