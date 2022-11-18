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
            result = "Fizz";
        }

        if (number % 5 == 0)
        {
            result = "Buzz";
        }

        return String.IsNullOrEmpty(result) ? number.ToString() : result;
    }
}