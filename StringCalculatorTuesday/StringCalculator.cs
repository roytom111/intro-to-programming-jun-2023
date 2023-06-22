
using System.ComponentModel.Design;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers, string num2)
    {
        if (numbers == "" && num2 == "")
        {
            return 0;

        }
        else 
        {
            var num1 = int.Parse(numbers);
            var nums = int.Parse(num2);
          
            return num1 +nums;

        } 
    }
}
    
