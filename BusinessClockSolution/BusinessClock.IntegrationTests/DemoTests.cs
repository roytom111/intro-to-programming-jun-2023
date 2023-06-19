

namespace BusinessClock.IntegrationTests

{
    public class DemoTests
    {
        [Fact]
        public void CanAddTwoNumbers()
        {
            //Given
            int a = 10, b = 20, answer;
            //when 
            answer = a + b ;
            //Then
            Assert.Equal(30, answer);
        }
    }
}
