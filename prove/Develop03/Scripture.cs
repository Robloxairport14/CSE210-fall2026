using System.Diagnostics;

class Scripture
{
    // attributes
    private List<Word> _word = new List<Word>();
    private Reference _reference;

        // List<Word> word1 = new List<Word>();

    // behavior
    public Scripture(string answer)
    {
        
        foreach (string ver5 in "Trust in the Lord with all thine heart; and lean not unto thine own understanding.".Split(" "))
        {
            Word word5 = new Word(ver5);
            _word.Add(word5);
            // Random(word5);
        }
        if (answer == "both")
        {
            foreach (string ver6 in "In all thy ways acknowledge him, and he shall direct thy paths.".Split(" "))
            {
                _reference = new Reference();
                Word word6 = new Word(ver6);
                _word.Add(word6);
                // Random(word6);
            }
        }
        else
        {
            _reference = new Reference("Proverbs" , 3 , 5);
        }

    }



    public void Random()
    {

        Random random = new Random();
        int count = random.Next(0, _word.Count);
        Word d = _word[count];
        d.Hide();
    }
    public void GetWords()
    {
        
    }

    public void Display()
    {
        _reference.Display();
        foreach (Word c in _word)
        {
            Console.Write(c.GetDisplay() + " ");
        }

    }

}