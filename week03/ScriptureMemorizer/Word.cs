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
            string underscores = "";
            foreach (char letter in _text)
            {
                if (char.IsLetter(letter))
                {
                    underscores += "_";
                }
                else
                {
                    underscores += letter;
                }
            }
            return underscores;
        }
        else
        {
            return _text;
        }
    }

    public string GetHintText()
    {
        if (_isHidden && _text.Length > 1)
        {
            return _text[0] + new string('_', _text.Length - 1);
        }
        return GetDisplayText();
    }
}