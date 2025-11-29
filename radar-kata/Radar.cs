using System.Text.RegularExpressions;

public class Radar
{
    public bool InterpretSignal(string signal)
    {
        var elements = RemoveInvalidCharacters(signal);

        if (elements.Length < 2)
        {
            return signal.Length == 1;
        }
            
        string validSignal = new(elements);
        Array.Reverse(elements);
        string signalReverse = new(elements);
            
        return signalReverse == validSignal;
    }

    private char[] RemoveInvalidCharacters(string signal)
    {
        return Regex.Replace(signal, @"[^\w]", "").ToLower().ToArray();
    }
}