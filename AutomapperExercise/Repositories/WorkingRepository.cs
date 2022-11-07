using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutomapperExercise.Data;
using AutomapperExercise.ViewModels;

namespace AutomapperExercise.Repositories
{
    public class WorkingRepository : IWorkingRepository
    {
        private readonly IMapper _mapper;
        public WorkingRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        InsertedData insertedData = new InsertedData();

        public List<FootballPlayerBasicInfoViewModel> GetFootballPlayers()
        {
            var listPlayers = insertedData.FootballPlayers;

            //var listOfMappingPlayers = _mapper.Map<List<FootballPlayerBasicInfoViewModel>>(listPlayers);

            var FootballPlayersList = listPlayers.AsQueryable()
                                                 .ProjectTo<FootballPlayerBasicInfoViewModel>(_mapper.ConfigurationProvider).ToList();

            return FootballPlayersList;
        }

        public List<StatisticPerYearViewModel> GetStatistics()
        {
            var listOfStatistics = insertedData.Statistics;


            var listOfStatisticsPerYear = listOfStatistics
                 .AsQueryable()
                 .OrderBy(x => x.YearOfStatistic)
                 .ProjectTo<StatisticPerYearViewModel>(_mapper.ConfigurationProvider).ToList();

            return listOfStatisticsPerYear;
        }
    }
}
