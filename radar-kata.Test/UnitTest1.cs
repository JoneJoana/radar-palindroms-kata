namespace radar_kata.Test;

public class Radar_Test
{
    [Fact]
    public void ShouldReturnFalseWhenReceivedEmptyString()
    {
        //Given
        string signal = "";
        //When 
        Radar radar = new(); 
        bool isAnOvni = radar.InterpretSignal(signal);
        //Then
        Assert.False(isAnOvni);
    }

    [Fact]
    public void ShouldReturnTrueWhenReceivedOneCharacter()
    {
        //Given
        string signal = "a";
        //When 
        Radar radar = new(); 
        bool isAnOvni = radar.InterpretSignal(signal);
        //Then
        Assert.True(isAnOvni);
    }

    [Fact]
    public void ShouldReturnTrueWhenReceivingSameCharacterTwice()
    {
        //Given
        string signal = "aa";
        //When 
        Radar radar = new(); 
        bool isAnOvni = radar.InterpretSignal(signal);
        //Then
        Assert.True(isAnOvni);
    }

}
