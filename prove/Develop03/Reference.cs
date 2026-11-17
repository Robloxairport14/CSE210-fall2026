class Reference
{
    // attributes
    private string _book;
    private int _chapter;
    private int _startVS;
    private int _endVS;

    // behavior
    public Reference(){
        _book = "Proverbs";
        _chapter = 3;
        _startVS = 5;
        _endVS = 6;
    }

    public Reference(string bk, int cr,int vs) //bcse BookChapter-Start-verse-End-verse
    {
        _book = bk;
        _chapter = cr;
        _startVS = vs;
        _endVS = vs;
    }

    public Reference(string bk, int cr,int vs, int evs)
    {
        _book = bk;
        _chapter = cr;
        _startVS = vs;
        _endVS = evs;

    }

    public void Display()
    {
        if (_startVS < _endVS)
        {
        Console.WriteLine($"{_book} {_chapter}:{_startVS} - {_endVS}");
        }
        else
        {
        Console.WriteLine($"{_book} {_chapter}:{_startVS}");
        }
    }



}

