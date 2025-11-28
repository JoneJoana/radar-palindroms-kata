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

        string signalClean = new string(elements);
        Array.Reverse(elements);
        string signalReverse = new string(elements);
            
        return signalReverse == signalClean;
    }
}