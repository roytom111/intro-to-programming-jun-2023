

namespace CsharpStuff;

public class Collections
{
    [Fact]
    public void ListOfThings()
    {
        var luckyNumbers = new List<int>();
        luckyNumbers.Add(9);
        luckyNumbers.Add(20);

        Assert.Equal(9, luckyNumbers[0]);  
        Assert.Equal(20, luckyNumbers[1]);

    }
    [Fact]
    public void EnumaratingAList()
    {
        var luckyNumbers = new List<int>();
        luckyNumbers.Add(9);
        luckyNumbers.Add(20);

        Assert.Equal(9, luckyNumbers[0]);
        Assert.Equal(20, luckyNumbers[1]);

        int total = 0;

        foreach (var currentNumber in luckyNumbers) 
        {
            total += currentNumber;
        
        
        }
        Assert.Equal(29, total);
    }

    [Fact]
    public void Dictionary()
    {
        var scores = new Dictionary<string, int>();
        {
            //{"Jim",220}

            scores.Add("Jim", 220);
            scores.Add("Sue", 300);

            Assert.Equal(220, scores["Jim"]);

            Assert.Throws<ArgumentException>(() => scores.Add("Jim", 300));

            scores["Jim"] = 300;


            Assert.Equal(300, scores["Jim"]);

            Assert.True(scores.ContainsKey("Jim"));
            Assert.True(scores.ContainsKey("Barb"));

        }
    }
}
