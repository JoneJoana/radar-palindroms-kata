using System.Diagnostics.Contracts;

public class Radar
{
    public bool InterpretSignal(string signal)
    {
        var elements = signal.ToArray();
        if(elements.Length < 2)
        {
            return signal.Length == 1;
        }
        if (elements[0] == elements[1])
        {
            return true;
        }
        return false;
    }
}