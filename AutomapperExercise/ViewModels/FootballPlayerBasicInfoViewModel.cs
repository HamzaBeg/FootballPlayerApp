using AutoMapper;
using AutomapperExercise.Models;

namespace AutomapperExercise.ViewModels
{
    public class FootballPlayerBasicInfoViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public int MarketValue { get; set; }

        public double Salary { get; set; }

        public string ClubName { get; set; }

        public List<StatisticViewModel> Statistics { get; set; }

        public int TotalGoals { get; set; }

        public int TotalAssists { get; set; }


        public class FootballPlayerBasicInfoViewModelProfile : Profile
        {
            public FootballPlayerBasicInfoViewModelProfile()
            {
                CreateMap<Statistic, StatisticViewModel>();

                CreateMap<FootballPlayer, StatisticViewModel>()
                    .ForMember(dest => dest.Id, src => src.MapFrom(src => src.Statistics.Select(x => x.Id)))
                    .ForMember(dest => dest.NumberOfGoals, src => src.MapFrom(src => src.Statistics.Select(x => x.NumberOfGoals)))
                    .ForMember(dest => dest.NumberOfAssists, src => src.MapFrom(src => src.Statistics.Select(x => x.NumberOfAssists)))
                    .ForMember(dest => dest.YearOfStatistic, src => src.MapFrom(src => src.Statistics.Select(x => x.YearOfStatistic)))
                    .ForMember(dest => dest.FootballPlayerId, src => src.MapFrom(src => src.Statistics.Select(x => x.FootballPlayerId)));

                CreateMap<FootballPlayer, FootballPlayerBasicInfoViewModel>()
                    .IncludeMembers(src => src.Club)
                    .ForMember(dest => dest.TotalGoals, src => src.MapFrom(x => x.Statistics.Select(x => x.NumberOfGoals).Sum()))
                    .ForMember(dest => dest.TotalAssists, src => src.MapFrom(x => x.Statistics.Select(x => x.NumberOfAssists).Sum()));

                CreateMap<Club, FootballPlayerBasicInfoViewModel>();
            }
        }
    }

}


