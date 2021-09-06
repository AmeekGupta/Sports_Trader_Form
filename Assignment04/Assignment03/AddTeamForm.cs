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
    public partial class AddTeamForm : Form
    {
        TeamRepository teamRepository = new TeamRepository(TeamRepository.FileName);
        public AddTeamForm()
        {
            InitializeComponent();
            teamRepository.Load(TeamRepository.FileName);
        }

        private void AddTeam_Btn_Click(object sender, EventArgs e)
        {
            // Add whatever written in the textbox to the list of teams

            Team team = new Team(AddTeam_Text.Text);
            team.Name = AddTeam_Text.Text;
            team.TeamId = Team.NextId;

            teamRepository.Teams.Add(team);
            teamRepository.Save(TeamRepository.FileName);

            Close();
        }

        private void TeamCancel_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
