using System.Diagnostics.Contracts;

public class Radar
{
    public bool InterpretSignal(string signal)
    {
        if(signal == "aa")
        {
            return true;
        }
        return signal.Length == 1;
    }
}