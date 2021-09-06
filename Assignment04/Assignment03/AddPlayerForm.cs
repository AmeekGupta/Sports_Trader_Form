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
    public partial class AddPlayerForm : Form
    {
        TeamRepository teamRepository = new TeamRepository(TeamRepository.FileName);
        //Team team = new Team();
        public AddPlayerForm()
        {
            InitializeComponent();
            teamRepository.Load(TeamRepository.FileName);
            UpdateTeams();
        }

        private void PlayerAccept_Btn_Click(object sender, EventArgs e)
        {
            var team = teamRepository.Teams.FirstOrDefault(t => t.TeamId == (PlayerForm_TeamBox.SelectedItem as Team).TeamId);

            Player player = new Player(AddPlayer_text.Text, team);
            player.Name = AddPlayer_text.Text;
            player.PlayerId = Player.NextId;

            team.Roster.Add(player);
            teamRepository.Save(TeamRepository.FileName);

            Close();
        }

        private void CancelPlayer_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void UpdateTeams()
        {
            PlayerForm_TeamBox.DataSource = teamRepository.Teams;
            PlayerForm_TeamBox.DisplayMember = nameof(Team.Name);
        }
    }
}
