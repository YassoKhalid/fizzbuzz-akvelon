using FizzBuzz;
using Xunit;

namespace FizzBuzz.Tests;

public class FizzBuzzDetectorTests
{
    private readonly FizzBuzzDetector _detector = new();

    [Fact]
    public void MatchesAssignmentExample()
    {
        const string input = "Mary had a little lamb\n" +
            "Little lamb, little lamb\n" +
            "Mary had a little lamb\n" +
            "It's fleece was white as snow";
        const string expected = "Mary had Fizz little Buzz\n" +
            "Fizz lamb, little Fizz\n" +
            "Buzz had Fizz little lamb\n" +
            "FizzBuzz fleece was Fizz as Buzz";

        var result = _detector.getOverlappings(input);

        Assert.Equal(expected, result.Output);
        Assert.Equal(9, result.Count);
    }

    [Fact]
    public void ReplacesThirdWordWithoutTrailingWhitespace()
    {
        var result = _detector.getOverlappings("one two three");

        Assert.Equal("one two Fizz", result.Output);
        Assert.Equal(1, result.Count);
    }

    [Fact]
    public void ReplacesFifthWordWithBuzz()
    {
        var result = _detector.getOverlappings("one two three four five");

        Assert.Equal("one two Fizz four Buzz", result.Output);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void ReplacesFifteenthWordWithFizzBuzzAndCountsItOnce()
    {
        var result = _detector.getOverlappings("a b c d e f g h i j k l m n o");

        Assert.Equal("a b Fizz d Buzz Fizz g h Fizz Buzz k Fizz m n FizzBuzz", result.Output);
        Assert.Equal(7, result.Count);
    }

    [Fact]
    public void PreservesSeparatorsAndCountsOnlyReplacements()
    {
        var result = _detector.getOverlappings("Fizz,\tBuzz  123\r\nfour;five!");

        Assert.Equal("Fizz,\tBuzz  Fizz\r\nfour;Buzz!", result.Output);
        Assert.Equal(2, result.Count);
    }
}
