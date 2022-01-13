namespace BBFReferee.Core.Entities
{
    public class Adress
    {
        public int Id { get; set; }
        public string Adds { get; set; }
        public User User { get; set; }
        public Team Team { get; set; }

    }
}
