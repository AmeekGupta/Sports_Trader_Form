
namespace Assignment03
{
    partial class TradePlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newSquadListBox = new System.Windows.Forms.ListBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.currentTeamLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newSquadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newSquadListBox
            // 
            this.newSquadListBox.BackColor = System.Drawing.SystemColors.Info;
            this.newSquadListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newSquadListBox.FormattingEnabled = true;
            this.newSquadListBox.ItemHeight = 23;
            this.newSquadListBox.Location = new System.Drawing.Point(190, 175);
            this.newSquadListBox.Name = "newSquadListBox";
            this.newSquadListBox.Size = new System.Drawing.Size(208, 96);
            this.newSquadListBox.TabIndex = 0;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.playerNameLabel.Location = new System.Drawing.Point(12, 9);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(132, 34);
            this.playerNameLabel.TabIndex = 1;
            this.playerNameLabel.Text = "label1";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teamNameLabel.Location = new System.Drawing.Point(22, 54);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(59, 23);
            this.teamNameLabel.TabIndex = 2;
            this.teamNameLabel.Text = "label2";
            // 
            // currentTeamLabel
            // 
            this.currentTeamLabel.AutoSize = true;
            this.currentTeamLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentTeamLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentTeamLabel.Location = new System.Drawing.Point(22, 93);
            this.currentTeamLabel.Name = "currentTeamLabel";
            this.currentTeamLabel.Size = new System.Drawing.Size(104, 20);
            this.currentTeamLabel.TabIndex = 3;
            this.currentTeamLabel.Text = "Current Team";
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acceptButton.Location = new System.Drawing.Point(190, 297);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(94, 29);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(304, 297);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // newSquadLabel
            // 
            this.newSquadLabel.AutoSize = true;
            this.newSquadLabel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newSquadLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.newSquadLabel.Location = new System.Drawing.Point(217, 141);
            this.newSquadLabel.Name = "newSquadLabel";
            this.newSquadLabel.Size = new System.Drawing.Size(145, 29);
            this.newSquadLabel.TabIndex = 6;
            this.newSquadLabel.Text = "New Squad";
            // 
            // TradePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(591, 338);
            this.Controls.Add(this.newSquadLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.currentTeamLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.newSquadListBox);
            this.Name = "TradePlayerForm";
            this.Text = "TradePlayerForm";
            this.Load += new System.EventHandler(this.TradePlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox newSquadListBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label currentTeamLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label newSquadLabel;
    }
}