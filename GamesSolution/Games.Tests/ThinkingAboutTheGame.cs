

namespace Games.Tests
{
    public class ThinkingAboutTheGame
    {
        [Fact]
        public void DuplicateNamesAreNotAllowed()
        {
            //given
            var game = new BowlingGame();
            //When
            game.AddPlayer("Jim", 120);

            //Then
            Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer("Jim", 200));
        }
    }
}
