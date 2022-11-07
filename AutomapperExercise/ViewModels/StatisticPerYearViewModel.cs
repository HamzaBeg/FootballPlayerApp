using AutoMapper;
using AutomapperExercise.Models;

namespace AutomapperExercise.ViewModels
{
    public class StatisticPerYearViewModel
    {
        public int Id { get; set; }

        public int NumberOfGoals { get; set; }

        public int NumberOfAssists { get; set; }

        public int YearOfStatistic { get; set; }

        public int FootballPlayerId { get; set; }

        public string FootballPlayerFullName { get; set; } = default!;


        public class StatisticPerYearProfile : Profile
        {
            public StatisticPerYearProfile()
            {

                CreateMap<Statistic, StatisticPerYearViewModel>()
                    .IncludeMembers(x => x.FootballPlayer);

                CreateMap<FootballPlayer, StatisticPerYearViewModel>();
            }
        }
    }
}
