
namespace Assignment03
{
    partial class AddPlayerForm
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
            this.PlayerForm_TeamBox = new System.Windows.Forms.ListBox();
            this.AddPlayer_text = new System.Windows.Forms.TextBox();
            this.PlayerAccept_Btn = new System.Windows.Forms.Button();
            this.CancelPlayer_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerForm_TeamBox
            // 
            this.PlayerForm_TeamBox.FormattingEnabled = true;
            this.PlayerForm_TeamBox.ItemHeight = 20;
            this.PlayerForm_TeamBox.Location = new System.Drawing.Point(27, 47);
            this.PlayerForm_TeamBox.Name = "PlayerForm_TeamBox";
            this.PlayerForm_TeamBox.Size = new System.Drawing.Size(220, 264);
            this.PlayerForm_TeamBox.TabIndex = 0;
            // 
            // AddPlayer_text
            // 
            this.AddPlayer_text.Location = new System.Drawing.Point(265, 47);
            this.AddPlayer_text.Name = "AddPlayer_text";
            this.AddPlayer_text.Size = new System.Drawing.Size(227, 27);
            this.AddPlayer_text.TabIndex = 1;
            // 
            // PlayerAccept_Btn
            // 
            this.PlayerAccept_Btn.Location = new System.Drawing.Point(265, 103);
            this.PlayerAccept_Btn.Name = "PlayerAccept_Btn";
            this.PlayerAccept_Btn.Size = new System.Drawing.Size(94, 29);
            this.PlayerAccept_Btn.TabIndex = 2;
            this.PlayerAccept_Btn.Text = "Add Player";
            this.PlayerAccept_Btn.UseVisualStyleBackColor = true;
            this.PlayerAccept_Btn.Click += new System.EventHandler(this.PlayerAccept_Btn_Click);
            // 
            // CancelPlayer_Btn
            // 
            this.CancelPlayer_Btn.Location = new System.Drawing.Point(398, 103);
            this.CancelPlayer_Btn.Name = "CancelPlayer_Btn";
            this.CancelPlayer_Btn.Size = new System.Drawing.Size(94, 29);
            this.CancelPlayer_Btn.TabIndex = 3;
            this.CancelPlayer_Btn.Text = "Cancel";
            this.CancelPlayer_Btn.UseVisualStyleBackColor = true;
            this.CancelPlayer_Btn.Click += new System.EventHandler(this.CancelPlayer_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(265, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name";
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelPlayer_Btn);
            this.Controls.Add(this.PlayerAccept_Btn);
            this.Controls.Add(this.AddPlayer_text);
            this.Controls.Add(this.PlayerForm_TeamBox);
            this.Name = "AddPlayerForm";
            this.Text = "Add Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlayerForm_TeamBox;
        private System.Windows.Forms.TextBox AddPlayer_text;
        private System.Windows.Forms.Button PlayerAccept_Btn;
        private System.Windows.Forms.Button CancelPlayer_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}