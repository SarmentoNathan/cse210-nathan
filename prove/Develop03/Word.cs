public class Word
{
    /*Class Attributes*/
    private string _text;
    private bool _isHidden;

    /* Class Constructors*/
    public Word(string word)
    {
        _text = word;
    }

    /* Class Methods*/
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string returnWord = "";

        if(_isHidden)
        {
            for(int k=1; k <= _text.Length; k++)
            {
                returnWord = returnWord + "_";
            }
        }

        else
        {
            returnWord = _text;
        }

        return returnWord;
    }
}