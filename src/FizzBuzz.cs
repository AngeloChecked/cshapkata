using src;

namespace csharp;

public class FizzBuzz : IFizzBuzz
{
    public string Say(int number)
    {
        string result = String.Empty;

        var fizz = new DivisorAndWord(3, "Fizz");
        var buzz = new DivisorAndWord(5, "Buzz");

        result += number % fizz.Divisor == 0 ? fizz.Word : "";

        if (number % buzz.Divisor == 0)
        {
            result += buzz.Word;
        }

        return String.IsNullOrEmpty(result) ? number.ToString() : result;
    }
}