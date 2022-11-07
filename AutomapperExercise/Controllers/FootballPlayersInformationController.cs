using AutomapperExercise.Repositories;
using AutomapperExercise.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayersInformationController : ControllerBase
    {
        private readonly IWorkingRepository _workingRepository;
        public FootballPlayersInformationController(IWorkingRepository workingRepository)
        {
            _workingRepository = workingRepository;
        }

        [HttpGet]
        public List<FootballPlayerBasicInfoViewModel> GetBasicInfomations()
        {
            var players = _workingRepository.GetFootballPlayers();

            return players;
        }

        [HttpGet("/getStatistics")]
        public List<StatisticPerYearViewModel> GetStatistics()
        {
            var statisticsPerYear = _workingRepository.GetStatistics();

            return statisticsPerYear;
        }
    }
}
