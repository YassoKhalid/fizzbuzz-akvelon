using System.Text;
namespace FizzBuzz;

public class FizzBuzzDetector
{
    private bool isAlphaNumeric(char c)
    {
        return c >= '0' && c <= '9' || c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z';
    }
    private bool isEscapeCharacter(char c)
    {
        return c == '\'';
    }
    public FizzBuzzResult getOverlappings(string input)
    {
        StringBuilder result = new StringBuilder();
        int count = 0, i = 0, currentPos = 0;
        while (i < input.Length)
        {
            if (!isAlphaNumeric(input[i]))
            {
                result.Append(input[i]);
                i++;
                continue;
            }
            StringBuilder current = new StringBuilder();
            while (i < input.Length)
            {
                if (isAlphaNumeric(input[i]))
                {
                    current.Append(input[i]);
                    i++;
                }
                else if (isEscapeCharacter(input[i]) && i + 1 < input.Length && isAlphaNumeric(input[i + 1]))
                {
                    current.Append(input[i]);
                    i++;
                }
                else
                {
                    break;
                }
            }
            currentPos++;
            string word = current.ToString();
            if (currentPos % 15 == 0)
            {
                count++;
                result.Append("FizzBuzz");
            }
            else if (currentPos % 3 == 0)
            {
                count++;
                result.Append("Fizz");
            }
            else if (currentPos % 5 == 0)
            {
                count++;
                result.Append("Buzz");
            }
            else
            {
                result.Append(word);
            }
        }
        return new FizzBuzzResult(result.ToString(), count);
    }
}
