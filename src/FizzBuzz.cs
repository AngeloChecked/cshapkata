using src;

namespace csharp;

public class FizzBuzz : IFizzBuzz
{
    public string Say(int number)
    {
        string result = String.Empty;

        var fizz = new DivisorAndWord(3, "Fizz");

        if (number % 3 == 0)
        {
            result += "Fizz";
        }

        if (number % 5 == 0)
        {
            result += "Buzz";
        }

        return String.IsNullOrEmpty(result) ? number.ToString() : result;
    }
}