using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class TradePlayerForm : Form
    {
        private Player _player = new Player();
        private TeamRepository _teamRepository = new TeamRepository(TeamRepository.FileName);

        public TradePlayerForm(Player player)
        {
            InitializeComponent();

            _teamRepository.Load(TeamRepository.FileName);
            _player = player;

            // Adding Text to the labels on the Trade Player Form
            playerNameLabel.Text = _player.Name;
            teamNameLabel.Text = _player.Team.Name;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

            int currentTeamId = _player.Team.TeamId;
            int newTeamId = 0;

            foreach (Team team in _teamRepository.Teams)
            {
                if (team.Name == newSquadListBox.GetItemText(newSquadListBox.SelectedItem))
                {
                    newTeamId = team.TeamId;
                    _teamRepository.TradePlayer(_player, currentTeamId, newTeamId);
                }
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TradePlayerForm_Load(object sender, EventArgs e)
        {
            foreach (Team team in _teamRepository.Teams)
            {
                if (team.Name != _player.Team.Name)
                {
                    newSquadListBox.Items.Add(team.Name); // Adding team names to the list box
                }
            }
        }
    }
}
