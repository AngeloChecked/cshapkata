namespace csharp;

public class FizzBuzz : IFizzBuzz
{
    public string Say(int number)
    {
        
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }

        string result = String.Empty;

        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }

        return String.IsNullOrEmpty(result) ? number.ToString() : result;
    }
}