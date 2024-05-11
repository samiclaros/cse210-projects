using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new();
    private Random rng = new();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordAry = text.Split(" ");
        foreach (string wordStr in wordAry)
        {
            _words.Add(new Word(wordStr));
        }
    }

    public void HideRandomWords(int numbersToHide)
    {
        for(int i = 0; i < numbersToHide; i++)
        {
            int index;
            do
            {
                index = rng.Next(_words.Count);
            }
            while (_words[index].IsHidden());

            _words[index].Hide();
            if (IsCompletelyHidden())
                break;
        }
    }

    public string GetDisplayText()
    {
        string output = "";
        output += _reference.GetDisplayText() + " - ";
        foreach (Word word in _words) // Here it's Word class? Because if I put string, there is an error.
        {
            output += word.GetDisplayText() + " ";
        }
        return output;

        // output <- ""
        // output += reference.GetDisplayText() + " - "
        // FOREACH word in _words
        //      output += word.GetDisplayText() + " "
        // RETURN ouput
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words) // It's word here? Because if I don't declare the class Word, almost everything is wrong
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;

        // FOREACH word in _words
        //      IF !word.IsHidden()
        //          RETURN FALSE
        // RETURN TRUE
    }
}