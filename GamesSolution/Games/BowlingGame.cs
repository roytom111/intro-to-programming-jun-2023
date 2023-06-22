namespace Games;



public class BowlingGame
{
    // "Primitive Obsession"
    private readonly List<Player> _players = new();

    public void AddPlayer(string name, int score)
    {

        if (PlayerExists(name))
        {
            throw new PlayerAlreadyAddedToGameException();
        }
        else
        {
            _players.Add(new Player(name, score));
        }
        // store some kind of list of players and their scores
        // unless a player with that same name already exists.
        // in that case, punch them in the nose.
    }

    private bool PlayerExists(string name)
    {
        return _players.Any(p => p.Name.Trim().ToLowerInvariant() == name.Trim().ToLowerInvariant());
    }
}



public record Player(string Name, int score);