class DebitCard
{
    private string _pin;

    public string Pin
    {
        set
        {
            if (value.Length < 4)
            {
                Console.WriteLine("Error: pin shoule be 4 digits or more");
            }
            else if (value.Length > 8)
            {
                Console.WriteLine("Error: pin too long");
            }

        }

        get
        {
            return _pin;
        }
    }
}