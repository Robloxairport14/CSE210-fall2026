class Scripture
{
    // attributes
    private List<Word> _words;
    private Reference _reference;

    // behavior
    public void Random()
    {
        
    }

    public void Display()
    {
        string enter = Console.ReadLine();
        foreach (char disappear in enter)
        {
            if (enter == "")
            {
            Console.Clear();
            // then reappear the scripture with the removed word
            }
            else if (enter == "quit")
            {
                Console.Clear();
                Console.WriteLine("good bye");
            }
            
        }


    }

}