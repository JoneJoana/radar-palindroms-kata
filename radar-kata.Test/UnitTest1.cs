namespace radar_kata.Test;

public class Radar_Test
{
    Radar radar;
    public Radar_Test()
    {
        radar = new();
    }

    [Fact]
    public void ShouldReturnFalseWhenReceivedEmptyString()
    {
        //Given
        string signal = "";
        //When        
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
        bool isAnOvni = radar.InterpretSignal(signal);
        //Then
        Assert.True(isAnOvni);
    }
    
    [Theory]
    [InlineData("aa", true)]
    [InlineData("ab", false)]
    [InlineData("Aa", true)]
    public void ShouldReturnTrueWhenReceivingSameCharacterTwice(string signal, bool expectedResult)
    {
        //When
        bool isAnOvni = radar.InterpretSignal(signal);
        //Then
        Assert.Equal(expectedResult, isAnOvni);
    }

    [Fact]
    public void ShouldIgnoreSpaces()
    {
        //Given
        string signal = "a a";
        //When
        bool isAnOvni = radar.InterpretSignal(signal);
        //Then
        Assert.True(isAnOvni);
    }
}
