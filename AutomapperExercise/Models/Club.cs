namespace AutomapperExercise.Models
{
    public class Club
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string Country { get; set; } = default!;

        public League League { get; set; } = new();

        public int LeagueId { get; set; }
    }
}
