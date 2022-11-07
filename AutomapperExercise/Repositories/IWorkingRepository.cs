using AutomapperExercise.ViewModels;

namespace AutomapperExercise.Repositories
{
    public interface IWorkingRepository
    {
        List<FootballPlayerBasicInfoViewModel> GetFootballPlayers();

        List<StatisticPerYearViewModel> GetStatistics();
    }
}