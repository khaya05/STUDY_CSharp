public struct Category
{
    // private fields
    private int _categoryId;
    private string _categoryName;

    public Category(int categoryId, string categoryName)
    {
        _categoryName = categoryName;
        _categoryId = categoryId;
    }

    //public properties
    public int CategoryId
    {
        set
        {
            if(value >= 1 && value <= 100)
            { 
                _categoryId = value;
            }
        }

        get { return _categoryId; } 
    }

    public string CategoryName
    {
        set
        {
            if(value.Length <= 40)
            {
                _categoryName = value;  
            }
        }

        get { return _categoryName; }
    }

    public int GetCategoryNameLength()
    {
        return this._categoryName.Length;
    }
}