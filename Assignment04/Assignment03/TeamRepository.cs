using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment03
{
    public class TeamRepository : IRepository
    {
        public static string FileName = "assign04_teamData.json";

        private List<Team> _Teams = new List<Team>();
        public List<Team> Teams 
        {
            get
            {
                return _Teams;
            }
        }

        public TeamRepository(string fileName)
        {
            //Load(fileName);
        }
        public void TradePlayer(Player player, int currentTeamId, int newTeamId)
        {
           
            foreach (Team team in _Teams)
            {
                if (team.TeamId == currentTeamId)
                {
                    foreach (Player playerToTrade in team.Roster)
                    {
                        if (playerToTrade.PlayerId == player.PlayerId)
                        {
                            team.Roster.Remove(player); // Remove the player from current team
                            break;
                        }
                    }
                }
                else if (team.TeamId == newTeamId)
                {
                    player.Team = team; // Setting team to the player
                    team.Roster.Add(player); // Add the player to the new team 
                }
            }

            Save(TeamRepository.FileName); // Saving the changes in the file

        }
        public void Load(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);

            //Deserializing the json file
            _Teams = JsonSerializer.Deserialize<List<Team>>(jsonString);

            foreach (Team team in _Teams)
            {
                if (team.TeamId > Team.NextId)
                    Team.NextId = team.TeamId;

                foreach (Player player in team.Roster)
                {
                    player.Team = team;
                    if (player.PlayerId > Player.NextId)
                        Player.NextId = player.PlayerId;
                }
            }
        }

        public void Save(string fileName)
        {            
            // Serializing _Teams
            string jsonString = JsonSerializer.Serialize(Teams);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
