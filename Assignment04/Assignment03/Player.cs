using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment03
{
    public class Player
    {
        public int PlayerId { get; set; }
        
        public string Name { get; set; }
        
        [JsonIgnore] // Ignoring Team during SERIALIZATION
        public Team Team { get; set; }

        private bool Equals (Player player)
        {
            return this.PlayerId == player.PlayerId;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return Equals(obj as Player); // Overriding the existing Equals method
        }

        // New members
        public static int NextId = 1;

        public Player()
        {
        }
        public Player (string newPlayer, Team team)
        {
            PlayerId = NextId++;
            Name = newPlayer;
            Team = team;
        }
    }
}
