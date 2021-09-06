using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment03;
using System.Collections.Generic;
using System.Linq;

namespace EmptyRosterTest
{
    [TestClass]
    public class EmptyRosterTests
    {
        [TestMethod]
        public void CheckEmptyRosters_CompareResults_Success()
        {
            // Assign
            List<Team> teams = new List<Team>();

            //--- Creating teams and Adding Rosters
            var team1 = new Team("firstTeam") { Roster = new List<Player>() { new Player() } };
            var team2 = new Team("secondTeam") { Roster = new List<Player>() { new Player() } };
            var team3 = new Team("thirdTeam") { Roster = new List<Player>() { new Player() } };

            //--- Not adding Roster in team 4
            var team4 = new Team("fourthTeam");

            //--- Providing Team Id to the teams
            team1.TeamId = 1;
            team2.TeamId = 2;
            team3.TeamId = 3;
            team4.TeamId = 4;

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

            Assert.IsTrue(
                matchups.Where(m => m.HomeTeam.Roster.Count() == 0 || m.AwayTeam.Roster.Count() == 0).Count() == 0);
        }
    }
}

    //foreach(Matchup match in matchups)
    //{
    //    Assert.IsTrue(match.HomeTeam.Roster.Count != 0);
    //    Assert.IsTrue(match.AwayTeam.Roster.Count != 0);
    //}