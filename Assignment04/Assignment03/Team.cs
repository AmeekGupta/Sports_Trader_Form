using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class Team
    {
        TeamRepository teamRepository = new TeamRepository(TeamRepository.FileName);
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Player> Roster { get; set; } = new List<Player>();

        // New members
        public static int NextId;

        public Team()
        {

        }
        public Team(string teamName)
        {
            TeamId = NextId++;
            Name = teamName;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    public class OtherClass
    { 
        public List<Team> Teams { get; set; }
        public List<Matchup> Matchups { get; set; }
    }
}
