using AutomapperExercise.Models;

namespace AutomapperExercise.Data
{
    public class InsertedData
    {
        public List<FootballPlayer> FootballPlayers = new List<FootballPlayer>()
        {
            new FootballPlayer()
            {
                Id = 1,
                FullName = "Leo Messi",
                Age = 33,
                MarketValue = 22,
                Salary = 35,
                ClubId = 1,
                Club= new Club()
                {
                    Id = 1,
                    Name = "Paris Saint Man",
                    Country = "France",
                    LeagueId = 1,
                },
                Statistics = new List<Statistic>()
                {
                     new Statistic
                     {
                         Id = 1,
                         YearOfStatistic = 2018,
                         NumberOfAssists = 20,
                         NumberOfGoals = 20,
                         FootballPlayerId = 1,
                     },

                     new Statistic()
                     {
                          Id = 2,
                          YearOfStatistic = 2017,
                          NumberOfAssists = 30,
                          NumberOfGoals = 10,
                          FootballPlayerId = 1,

                     },
                }
            },

            new FootballPlayer()
            {
                Id = 2,
                FullName = "Cristiano Ronaldo",
                Age = 37,
                MarketValue = 15,
                Salary = 25,
                ClubId = 2,
                Club= new Club()
                {
                    Id = 1,
                    Name = "Manchester United",
                    Country = "England",
                    LeagueId = 2,
                },
                 Statistics = new List<Statistic>()
                 {
                     new Statistic()
                     {
                         Id = 3,
                         YearOfStatistic = 2016,
                         NumberOfAssists = 25,
                         NumberOfGoals = 5,
                         FootballPlayerId = 2,
                     },
                 }
            },

             new FootballPlayer()
             {
                Id = 3,
                FullName = "Neymar Junior",
                Age = 32,
                MarketValue = 50,
                Salary = 38,
                ClubId = 1,
                Club= new Club()
                {
                    Id = 1,
                    Name = "Paris Saint Man",
                    Country = "France",
                    LeagueId = 1,
                },
                Statistics = new List<Statistic>()
                {
                     new Statistic
                     {
                         Id = 4,
                         YearOfStatistic = 2018,
                         NumberOfAssists = 10,
                         NumberOfGoals = 33,
                         FootballPlayerId = 3,
                     }
                }
             }
    };

        public List<Club> Clubs = new List<Club>()
        {
             new Club()
             {
                 Id = 1,
                 Name = "Paris Saint Man",
                 Country = "France",
                 LeagueId = 1,
             },

              new Club()
              {
                 Id = 1,
                 Name = "Manchester United",
                 Country = "England",
                 LeagueId = 2,
              }
        };

        public List<League> Leagues = new List<League>()
        {
             new League()
             {
                 Id = 1,
                 Name = "League 1",
             },

              new League()
             {
                 Id = 2,
                 Name = "Premier League",
             }
        };

        public List<Statistic> Statistics = new List<Statistic>()
        {
             new Statistic()
             {
                Id = 1,
                YearOfStatistic = 2018,
                NumberOfAssists = 20,
                NumberOfGoals = 20,
                FootballPlayerId = 1,
                FootballPlayer = new FootballPlayer()
                {
                    Id = 1,
                    FullName = "Leo Messi",
                    Age = 33,
                    MarketValue = 22,
                    Salary = 35,
                    ClubId = 1,
                    Club= new Club()
                    {
                        Id = 1,
                        Name = "Paris Saint Man",
                        Country = "France",
                        LeagueId = 1,
                    },
                }
             },

              new Statistic()
              {
                  Id = 2,
                  YearOfStatistic = 2017,
                  NumberOfAssists = 30,
                  NumberOfGoals = 10,
                  FootballPlayerId = 1,
                  FootballPlayer = new FootballPlayer()
                  {
                      Id = 1,
                      FullName = "Leo Messi",
                      Age = 33,
                      MarketValue = 22,
                      Salary = 35,
                      ClubId = 1,
                      Club= new Club()
                      {
                          Id = 1,
                          Name = "Paris Saint Man",
                          Country = "France",
                          LeagueId = 1,
                      },
                  }
              },

              new Statistic()
              {
                  Id = 3,
                  YearOfStatistic = 2016,
                  NumberOfAssists = 25,
                  NumberOfGoals = 5,
                  FootballPlayerId = 2,
                  FootballPlayer = new FootballPlayer()
                  {
                      Id = 2,
                      FullName = "Cristiano Ronaldo",
                      Age = 37,
                      MarketValue = 15,
                      Salary = 25,
                      ClubId = 2,
                      Club= new Club()
                      {
                         Id = 1,
                         Name = "Manchester United",
                         Country = "England",
                         LeagueId = 2,
                      },
                  }
              },

              new Statistic()
              {
                  Id = 4,
                  YearOfStatistic = 2018,
                  NumberOfAssists = 10,
                  NumberOfGoals = 33,
                  FootballPlayerId = 3,
                  FootballPlayer = new FootballPlayer()
                  {
                      Id = 3,
                      FullName = "Neymar Junior",
                      Age = 32,
                      MarketValue = 50,
                      Salary = 38,
                      ClubId = 1,
                      Club= new Club()
                      {
                          Id = 1,
                          Name = "Paris Saint Man",
                          Country = "France",
                          LeagueId = 1,
                      },
                  }
              }
        };
    }
}
