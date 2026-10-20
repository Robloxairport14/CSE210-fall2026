class Entry
{
    // attribute
    public string _date = "";
    public string _prompt = "";
    public string _response = "";

    // behavior
    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_response}");
        

    }

}