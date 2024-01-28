public class Scripture
{
    /*Class attributes*/
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    /*Class Constructors*/
    public Scripture(Reference scripRef, string scripText)
    {
        _reference = scripRef;

        // Iterate through each word of the scripture text to create Word objects, and store them
        // in the Word list
        foreach(string word in scripText.Split())
        {
            Word tempWord = new Word(word);
            _words.Add(tempWord);
        }
    }

    /*Class Methods*/
    public void HideRandomWords(int numberToHide)
    {
        int numbWords = _words.Count;
        
        while(numberToHide >= 0)
        {
            Random rnd = new Random();
            int index = rnd.Next(numbWords);

            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                numberToHide --;
            }
        }
    }

    public string GetDisplayText()
    {
        string returnMessage = "";

        foreach(Word palavra in _words)
        {
            returnMessage = returnMessage + palavra.GetDisplayText() + " ";
        }

        return returnMessage;
    }

    public bool IsCompletelyHidden()
    {
        bool flag = true;

        foreach(Word palavra in _words)
        {
            flag = flag & palavra.IsHidden(); // It will only be true if all words are hidden
        }

        return flag;
    }

// Method to know how many words are shown
    public int shownQuantity()
    {
        int total = 0;

        foreach(Word palavra in _words)
        {
            if(!palavra.IsHidden())
            {
                total ++;
            }
        }

        return total;
    }

}