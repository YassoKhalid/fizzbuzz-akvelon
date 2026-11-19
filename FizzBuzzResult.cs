namespace FizzBuzz;

public class FizzBuzzResult
{
    public string Output { get; }
    public int Count { get; }

    public FizzBuzzResult(string output, int count)
    {
        Output = output;
        Count = count;
    }
}