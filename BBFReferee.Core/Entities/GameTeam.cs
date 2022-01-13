namespace BBFReferee.Core.Entities
{
    public class GameTeam
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
