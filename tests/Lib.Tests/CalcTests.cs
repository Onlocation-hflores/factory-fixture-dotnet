using Xunit;

public class CalcTests
{
    [Fact]
    public void Add_Passes() => Assert.Equal(4, Calc.Add(2, 2));

    [Fact]
    public void Add_FailsOnPurpose()
    {
        // intentionally failing: baseline must record fail
        Assert.Equal(5, Calc.Add(2, 2));
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(0, 0, 0)]
    public void Add_Theory(int a, int b, int expected) => Assert.Equal(expected, Calc.Add(a, b));
}
