
namespace Assignment03
{
    partial class SeasonForm
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
            this.Season_GridBox = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Season_GridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Season_GridBox
            // 
            this.Season_GridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Season_GridBox.Location = new System.Drawing.Point(12, 12);
            this.Season_GridBox.Name = "Season_GridBox";
            this.Season_GridBox.RowHeadersWidth = 51;
            this.Season_GridBox.RowTemplate.Height = 29;
            this.Season_GridBox.Size = new System.Drawing.Size(568, 332);
            this.Season_GridBox.TabIndex = 0;
            // 
            // SeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 356);
            this.Controls.Add(this.Season_GridBox);
            this.Name = "SeasonForm";
            this.Text = "SeasonForm";
            ((System.ComponentModel.ISupportInitialize)(this.Season_GridBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Season_GridBox;
    }
}