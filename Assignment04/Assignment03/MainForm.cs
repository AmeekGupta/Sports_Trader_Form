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
    public partial class MainForm : Form
    {
        private TeamRepository _teamRepository = new TeamRepository(TeamRepository.FileName);
        private MatchupRepository _matchupRepository = new MatchupRepository();

        public MainForm()
        {
            InitializeComponent();

            // Displaying Team List on Teams List Box
            _teamRepository.Load(TeamRepository.FileName);
            UpdateTeamsAndPlayers();
        }

        private void UpdateTeamsAndPlayers()
        {
            teamsListBox.DataSource = _teamRepository.Teams;
            teamsListBox.DisplayMember = nameof(Team.Name);
        }

        private void TradePlayerButton_Click(object sender, EventArgs e)
        {
            TradePlayerForm tradePlayerForm = new TradePlayerForm(playerBox.SelectedItem as Player);
            tradePlayerForm.Show();
            tradePlayerForm.FormClosed += TradePlayerForm_FormClosed;
                //(sender, eventArgs) => { _teamRepository.Load(TeamRepository.fileName); UpdateTeamsAndPlayers(); };
         }

        // TradePlayerForm - FormClosed event method
        private void TradePlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _teamRepository.Load(TeamRepository.FileName); 
            UpdateTeamsAndPlayers();
        }

        // AddPlayerForm - FormClosed event method
        private void AddPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _teamRepository.Load(TeamRepository.FileName);
            UpdateTeamsAndPlayers();
        }

        // AddTeamForm - FormClosed event method
        private void AddTeamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _teamRepository.Load(TeamRepository.FileName);
            UpdateTeamsAndPlayers();
        }
        private void TeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Displaying players in the player box based on the team selected
            Team teamSelected = teamsListBox.SelectedItem as Team;
            playerBox.DataSource = teamSelected.Roster;
            playerBox.DisplayMember = nameof(Player.Name);
        }

        // Generate Season Button
        private void generateSeason_Btn_Click(object sender, EventArgs e)
        {
            SeasonForm seasonForm = new SeasonForm(_teamRepository.Teams);
            seasonForm.Show();
        }

        // Add player Button
        private void addPlayer_Btn_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.Show();
            addPlayerForm.FormClosed += AddPlayerForm_FormClosed;
        }

        // Add team button
        private void addTeam_Btn_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.Show();
            addTeamForm.FormClosed += AddTeamForm_FormClosed;
        }
    }
}
