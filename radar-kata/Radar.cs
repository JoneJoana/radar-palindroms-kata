using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class Radar
{
    public bool InterpretSignal(string signal)
    {
        var elements = signal.ToLower().ToArray();
        elements = [.. elements.Where(x => x != ' ')];
        
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