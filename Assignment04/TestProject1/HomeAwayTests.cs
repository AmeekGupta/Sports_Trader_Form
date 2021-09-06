using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment03;
using System.Collections.Generic;
using System.Linq;

namespace HomeAwayTests
{
    [TestClass]
    public class HomeAwayTests
    {
        [TestMethod]
        public void GenerateSeasonHomeVsAway_CompareResults_Success()
        {
            // Assign
            List<Team> teams = new List<Team>();

            //--- Creating teams and Adding Rosters
            var team1 = new Team("firstTeam") {  Roster = new List<Player>() { new Player() } };
            var team2 = new Team("secondTeam") { Roster = new List<Player>() { new Player() } };
            var team3 = new Team("thirdTeam") { Roster = new List<Player>() { new Player() } };
            var team4 = new Team("fourthTeam") { Roster = new List<Player>() { new Player() } };

            // Act
            teams.Add(team1);
            teams.Add(team2);
            teams.Add(team3);
            teams.Add(team4);

            MatchupRepository matchupRepository = new MatchupRepository();
            List<Matchup> matchups = new List<Matchup>();

            matchupRepository.GenerateSeason(teams);
            matchups = matchupRepository.Matchups;

            // Assert
            foreach (Team team in teams)
            {
                // homeGameCount == n-1
                Assert.IsTrue(matchups.Where(m => m.HomeTeam.TeamId == team.TeamId).Count() == teams.Count() - 1);

                // awayGameCount == n-1
                Assert.IsTrue(matchups.Where(m => m.AwayTeam.TeamId == team.TeamId).Count() == teams.Count() - 1);

            }
        }
    }
}

//--- Providing Team Id to the teams
//team1.TeamId = 1;
//team2.TeamId = 2;
//team3.TeamId = 3;
//team4.TeamId = 4;

//var homeGames = new List<Matchup>();
//var awayGames = new List<Matchup>();
//var homeGameOpponents = new List<Team>();
//var awayGameOpponents = new List<Team>();

//foreach (Matchup match in matchups)
//{
//    if (team.TeamId == match.HomeTeam.TeamId)
//    {
//        homeGames.Add(match);                        
//    }
//    if (team.TeamId == match.AwayTeam.TeamId)
//    {
//        awayGames.Add(match);
//    }
//}

//Assert.AreEqual(teams.Count - 1, homeGames.Count);
//Assert.AreEqual(teams.Count - 1, awayGames.Count);

//foreach (Matchup match in homeGames)
//{
//    if (!homeGameOpponents.Contains(match.AwayTeam))
//    {
//        homeGameOpponents.Add(match.AwayTeam);
//    }
//}
//foreach (Matchup match in awayGames)
//{
//    if (!awayGameOpponents.Contains(match.HomeTeam))
//    {
//        awayGameOpponents.Add(match.HomeTeam);
//    }
//}

//Assert.AreEqual(teams.Count - 1, homeGameOpponents.Count);
//Assert.AreEqual(teams.Count - 1, awayGameOpponents.Count);

//homeGames.Clear();
//awayGames.Clear();

//homeGameOpponents.Clear();       
//awayGameOpponents.Clear();       
