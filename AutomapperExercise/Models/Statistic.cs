namespace AutomapperExercise.Models
{
    public class Statistic
    {
        public int Id { get; set; }

        public int NumberOfGoals { get; set; }

        public int NumberOfAssists { get; set; }

        public int YearOfStatistic { get; set; }

        public FootballPlayer FootballPlayer { get; set; } = new();

        public int FootballPlayerId { get; set; }
    }
}
