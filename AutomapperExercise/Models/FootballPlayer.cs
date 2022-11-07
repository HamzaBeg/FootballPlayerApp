namespace AutomapperExercise.Models
{
    public class FootballPlayer
    {
        public int Id { get; set; }

        public string FullName { get; set; } = default!;

        public int Age { get; set; }

        public int MarketValue { get; set; }

        public double Salary { get; set; }

        public Club Club { get; set; } = new();

        public int ClubId { get; set; }

        public List<Statistic> Statistics { get; set; } = new();
    }
}
