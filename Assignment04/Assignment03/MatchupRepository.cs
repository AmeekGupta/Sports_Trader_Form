using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Assignment03
{
    public class MatchupRepository : IRepository
    {
        public static string MatchUpFile = "matchups.json";

        private List<Matchup> _Matchups = new List<Matchup>();
        public List<Matchup> Matchups
        {
            get
            {
                return _Matchups;
            }
        }
        public void GenerateSeason(List<Team> teams)
        {
            // 1. No teams with empty roster
            // 2. Every team plays one home game against every other team
            // 3. Every team plays one away game against every other team

            foreach (Team homeTeam in teams)
            {
                if (homeTeam.Roster != null && homeTeam.Roster.Count() > 0)
                {
                    foreach (Team awayTeam in teams)
                    {
                        // make the matchup
                        if (awayTeam.Roster != null && awayTeam.Roster.Count() > 0 && homeTeam.TeamId != awayTeam.TeamId)
                        {
                            _Matchups.Add(new Matchup(homeTeam, awayTeam));
                        }
                    }
                }
            }
            
            Save(MatchUpFile);
        }

        public void Load(string matchUpFile)
        {
            string jsonString = File.ReadAllText(matchUpFile);
            _Matchups = JsonSerializer.Deserialize<List<Matchup>>(jsonString);
        }

        public void Save(string matchUpFile)
        {
            string jsonString = JsonSerializer.Serialize(Matchups);
            File.WriteAllText(matchUpFile, jsonString);
        }
    }
}

