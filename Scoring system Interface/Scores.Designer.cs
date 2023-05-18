
namespace Scoring_system_Interface
{
    partial class Scores
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
            this.lbl_EnterTeam = new System.Windows.Forms.Label();
            this.lbl_Event1 = new System.Windows.Forms.Label();
            this.lbl_Event2 = new System.Windows.Forms.Label();
            this.lbl_Event3 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Event4 = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.btnSaveTeamScore = new System.Windows.Forms.Button();
            this.lstTeamScore = new System.Windows.Forms.ListBox();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_EnterTeam
            // 
            this.lbl_EnterTeam.AutoSize = true;
            this.lbl_EnterTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterTeam.Location = new System.Drawing.Point(137, 84);
            this.lbl_EnterTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EnterTeam.Name = "lbl_EnterTeam";
            this.lbl_EnterTeam.Size = new System.Drawing.Size(139, 29);
            this.lbl_EnterTeam.TabIndex = 0;
            this.lbl_EnterTeam.Text = "Enter Team";
            // 
            // lbl_Event1
            // 
            this.lbl_Event1.AutoSize = true;
            this.lbl_Event1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Event1.Location = new System.Drawing.Point(112, 176);
            this.lbl_Event1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Event1.Name = "lbl_Event1";
            this.lbl_Event1.Size = new System.Drawing.Size(162, 29);
            this.lbl_Event1.TabIndex = 1;
            this.lbl_Event1.Text = "Event 1 Score";
            // 
            // lbl_Event2
            // 
            this.lbl_Event2.AutoSize = true;
            this.lbl_Event2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Event2.Location = new System.Drawing.Point(112, 265);
            this.lbl_Event2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Event2.Name = "lbl_Event2";
            this.lbl_Event2.Size = new System.Drawing.Size(162, 29);
            this.lbl_Event2.TabIndex = 2;
            this.lbl_Event2.Text = "Event 2 Score";
            // 
            // lbl_Event3
            // 
            this.lbl_Event3.AutoSize = true;
            this.lbl_Event3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Event3.Location = new System.Drawing.Point(112, 350);
            this.lbl_Event3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Event3.Name = "lbl_Event3";
            this.lbl_Event3.Size = new System.Drawing.Size(162, 29);
            this.lbl_Event3.TabIndex = 3;
            this.lbl_Event3.Text = "Event 3 Score";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(160, 514);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(138, 29);
            this.lbl_Total.TabIndex = 4;
            this.lbl_Total.Text = "Total Score";
            // 
            // lbl_Event4
            // 
            this.lbl_Event4.AutoSize = true;
            this.lbl_Event4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Event4.Location = new System.Drawing.Point(112, 428);
            this.lbl_Event4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Event4.Name = "lbl_Event4";
            this.lbl_Event4.Size = new System.Drawing.Size(162, 29);
            this.lbl_Event4.TabIndex = 5;
            this.lbl_Event4.Text = "Event 4 Score";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.Location = new System.Drawing.Point(321, 518);
            this.lblTotalScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(26, 29);
            this.lblTotalScore.TabIndex = 6;
            this.lblTotalScore.Text = "0";
            this.lblTotalScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveTeamScore
            // 
            this.btnSaveTeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTeamScore.Location = new System.Drawing.Point(144, 603);
            this.btnSaveTeamScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTeamScore.Name = "btnSaveTeamScore";
            this.btnSaveTeamScore.Size = new System.Drawing.Size(285, 57);
            this.btnSaveTeamScore.TabIndex = 7;
            this.btnSaveTeamScore.Text = "Calculate And Save Score";
            this.btnSaveTeamScore.UseVisualStyleBackColor = true;
            this.btnSaveTeamScore.Click += new System.EventHandler(this.btnSaveTeamScore_Click);
            // 
            // lstTeamScore
            // 
            this.lstTeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTeamScore.FormattingEnabled = true;
            this.lstTeamScore.ItemHeight = 25;
            this.lstTeamScore.Location = new System.Drawing.Point(704, 84);
            this.lstTeamScore.Margin = new System.Windows.Forms.Padding(4);
            this.lstTeamScore.Name = "lstTeamScore";
            this.lstTeamScore.Size = new System.Drawing.Size(371, 379);
            this.lstTeamScore.TabIndex = 8;
            this.lstTeamScore.SelectedIndexChanged += new System.EventHandler(this.TeamScore_SelectedIndexChanged);
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(312, 90);
            this.txtTeam.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeam.Multiline = true;
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(185, 43);
            this.txtTeam.TabIndex = 9;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(312, 182);
            this.txtScore1.Margin = new System.Windows.Forms.Padding(4);
            this.txtScore1.Multiline = true;
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(185, 37);
            this.txtScore1.TabIndex = 10;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(312, 271);
            this.txtScore2.Margin = new System.Windows.Forms.Padding(4);
            this.txtScore2.Multiline = true;
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(185, 38);
            this.txtScore2.TabIndex = 11;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(312, 356);
            this.txtScore3.Margin = new System.Windows.Forms.Padding(4);
            this.txtScore3.Multiline = true;
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(185, 41);
            this.txtScore3.TabIndex = 12;
            // 
            // txtScore4
            // 
            this.txtScore4.Location = new System.Drawing.Point(312, 434);
            this.txtScore4.Margin = new System.Windows.Forms.Padding(4);
            this.txtScore4.Multiline = true;
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(185, 41);
            this.txtScore4.TabIndex = 13;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1218, 706);
            this.Controls.Add(this.txtScore4);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.lstTeamScore);
            this.Controls.Add(this.btnSaveTeamScore);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.lbl_Event4);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Event3);
            this.Controls.Add(this.lbl_Event2);
            this.Controls.Add(this.lbl_Event1);
            this.Controls.Add(this.lbl_EnterTeam);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Scores";
            this.Text = "Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EnterTeam;
        private System.Windows.Forms.Label lbl_Event1;
        private System.Windows.Forms.Label lbl_Event2;
        private System.Windows.Forms.Label lbl_Event3;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Event4;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Button btnSaveTeamScore;
        private System.Windows.Forms.ListBox lstTeamScore;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore4;
    }
}