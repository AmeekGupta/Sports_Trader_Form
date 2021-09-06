
namespace Assignment03
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tradePlayerButton = new System.Windows.Forms.Button();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.playerBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addTeam_Btn = new System.Windows.Forms.Button();
            this.addPlayer_Btn = new System.Windows.Forms.Button();
            this.generateSeason_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tradePlayerButton
            // 
            this.tradePlayerButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tradePlayerButton.Location = new System.Drawing.Point(232, 57);
            this.tradePlayerButton.Name = "tradePlayerButton";
            this.tradePlayerButton.Size = new System.Drawing.Size(116, 29);
            this.tradePlayerButton.TabIndex = 0;
            this.tradePlayerButton.Text = "Trade Player";
            this.tradePlayerButton.UseVisualStyleBackColor = true;
            this.tradePlayerButton.Click += new System.EventHandler(this.TradePlayerButton_Click);
            // 
            // teamsListBox
            // 
            this.teamsListBox.BackColor = System.Drawing.SystemColors.Info;
            this.teamsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 23;
            this.teamsListBox.Location = new System.Drawing.Point(12, 57);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(195, 211);
            this.teamsListBox.TabIndex = 1;
            this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.TeamsListBox_SelectedIndexChanged);
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.SystemColors.Info;
            this.playerBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerBox.FormattingEnabled = true;
            this.playerBox.ItemHeight = 23;
            this.playerBox.Location = new System.Drawing.Point(359, 57);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(220, 211);
            this.playerBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(403, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Players";
            // 
            // addTeam_Btn
            // 
            this.addTeam_Btn.Location = new System.Drawing.Point(428, 327);
            this.addTeam_Btn.Name = "addTeam_Btn";
            this.addTeam_Btn.Size = new System.Drawing.Size(94, 29);
            this.addTeam_Btn.TabIndex = 5;
            this.addTeam_Btn.Text = "Add Team";
            this.addTeam_Btn.UseVisualStyleBackColor = true;
            this.addTeam_Btn.Click += new System.EventHandler(this.addTeam_Btn_Click);
            // 
            // addPlayer_Btn
            // 
            this.addPlayer_Btn.Location = new System.Drawing.Point(57, 327);
            this.addPlayer_Btn.Name = "addPlayer_Btn";
            this.addPlayer_Btn.Size = new System.Drawing.Size(94, 29);
            this.addPlayer_Btn.TabIndex = 6;
            this.addPlayer_Btn.Text = "Add Player";
            this.addPlayer_Btn.UseVisualStyleBackColor = true;
            this.addPlayer_Btn.Click += new System.EventHandler(this.addPlayer_Btn_Click);
            // 
            // generateSeason_Btn
            // 
            this.generateSeason_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateSeason_Btn.Location = new System.Drawing.Point(223, 298);
            this.generateSeason_Btn.Name = "generateSeason_Btn";
            this.generateSeason_Btn.Size = new System.Drawing.Size(135, 58);
            this.generateSeason_Btn.TabIndex = 7;
            this.generateSeason_Btn.Text = "Generate Season";
            this.generateSeason_Btn.UseVisualStyleBackColor = true;
            this.generateSeason_Btn.Click += new System.EventHandler(this.generateSeason_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(591, 368);
            this.Controls.Add(this.generateSeason_Btn);
            this.Controls.Add(this.addPlayer_Btn);
            this.Controls.Add(this.addTeam_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.tradePlayerButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tradePlayerButton;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.ListBox playerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addTeam_Btn;
        private System.Windows.Forms.Button addPlayer_Btn;
        private System.Windows.Forms.Button generateSeason_Btn;
    }
}

