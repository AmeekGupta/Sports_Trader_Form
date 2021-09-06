
namespace Assignment03
{
    partial class AddTeamForm
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
            this.AddTeam_Text = new System.Windows.Forms.TextBox();
            this.AddTeam_Btn = new System.Windows.Forms.Button();
            this.TeamCancel_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddTeam_Text
            // 
            this.AddTeam_Text.Location = new System.Drawing.Point(82, 74);
            this.AddTeam_Text.Name = "AddTeam_Text";
            this.AddTeam_Text.Size = new System.Drawing.Size(408, 27);
            this.AddTeam_Text.TabIndex = 0;
            // 
            // AddTeam_Btn
            // 
            this.AddTeam_Btn.Location = new System.Drawing.Point(163, 126);
            this.AddTeam_Btn.Name = "AddTeam_Btn";
            this.AddTeam_Btn.Size = new System.Drawing.Size(94, 29);
            this.AddTeam_Btn.TabIndex = 1;
            this.AddTeam_Btn.Text = "Add Team";
            this.AddTeam_Btn.UseVisualStyleBackColor = true;
            this.AddTeam_Btn.Click += new System.EventHandler(this.AddTeam_Btn_Click);
            // 
            // TeamCancel_Btn
            // 
            this.TeamCancel_Btn.Location = new System.Drawing.Point(319, 126);
            this.TeamCancel_Btn.Name = "TeamCancel_Btn";
            this.TeamCancel_Btn.Size = new System.Drawing.Size(94, 29);
            this.TeamCancel_Btn.TabIndex = 2;
            this.TeamCancel_Btn.Text = "Cancel";
            this.TeamCancel_Btn.UseVisualStyleBackColor = true;
            this.TeamCancel_Btn.Click += new System.EventHandler(this.TeamCancel_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team Name";
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamCancel_Btn);
            this.Controls.Add(this.AddTeam_Btn);
            this.Controls.Add(this.AddTeam_Text);
            this.Name = "AddTeamForm";
            this.Text = "Add Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddTeam_Text;
        private System.Windows.Forms.Button AddTeam_Btn;
        private System.Windows.Forms.Button TeamCancel_Btn;
        private System.Windows.Forms.Label label1;
    }
}