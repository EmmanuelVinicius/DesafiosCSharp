using System;

public class RemoveRepetitions
{
    public static string Transform(string input)
    {
        char element = ' ';
        string fullText = "";
        foreach (char c in input)
            if (element != c)
            {
                element = c;
                fullText += element;
            }
        return fullText;
    }
}
