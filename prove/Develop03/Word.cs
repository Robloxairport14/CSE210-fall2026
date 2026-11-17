class Word
{
    // attributes
    private string _text;
    private bool _isHidden;

    public Word(string w)
    {
        _text = w;
        _isHidden = false;
    }
    
    // Scripture count = new Scripture();
    // behavior
    public void Hide()
    {
        _isHidden = true;
    }

    public bool GetHide()
    {
        return _isHidden;

    }

    public string GetDisplay()
    {
        if (_isHidden == true)
        {
            return new string('_' ,_text.Length).Replace("_","_ ");
        }

        else
        {
            return _text;
        }
    }
}