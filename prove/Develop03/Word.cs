public class Word
{
    private string _text; 
    private bool _isHidden; 

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

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
        if (_isHidden)
        {
             string hiddenText = "";
             foreach (char letter in _text)  // What type is "letter"?
             {
                hiddenText += "_";
             }
             return hiddenText;
        }
        else
        {
             return _text;
        }

        // IF _isHidden
        //      hiddenText <- ""
        //      FOR letter in _text
        //          hiddenText += "_"
        //      RETURN hiddenText
        // ELSE
        //      RETURN _text
    }
}