
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers == "") { return 0; }
        if(numbers.Contains(','))
        {
            var idx = numbers.IndexOf(',');
            var lhs = int.Parse(numbers.Substring(0, idx));
            var rhs = int.Parse(numbers.Substring(idx + 1));

            return lhs + rhs;
        }
        return int.Parse(numbers);
        
    }
}
