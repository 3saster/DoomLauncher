namespace DoomLauncher
{
    partial class StatsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Winform Designer", "VS2015 SP1")]
        private void InitializeComponent()
        {
            this.tblStats = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSecrets = new System.Windows.Forms.PictureBox();
            this.ctrlStatsSecrets = new DoomLauncher.StatBar();
            this.ctrlStatsKills = new DoomLauncher.StatBar();
            this.pbKills = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecrets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKills)).BeginInit();
            this.SuspendLayout();
            // 
            // tblStats
            // 
            this.tblStats.ColumnCount = 3;
            this.tblStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStats.Controls.Add(this.label1, 1, 0);
            this.tblStats.Controls.Add(this.label2, 1, 1);
            this.tblStats.Controls.Add(this.pbKills, 0, 0);
            this.tblStats.Controls.Add(this.pbSecrets, 0, 1);
            this.tblStats.Controls.Add(this.ctrlStatsSecrets, 2, 1);
            this.tblStats.Controls.Add(this.ctrlStatsKills, 2, 0);
            this.tblStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStats.Location = new System.Drawing.Point(0, 0);
            this.tblStats.Margin = new System.Windows.Forms.Padding(0);
            this.tblStats.MinimumSize = new System.Drawing.Size(160, 0);
            this.tblStats.Name = "tblStats";
            this.tblStats.RowCount = 3;
            this.tblStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblStats.Size = new System.Drawing.Size(306, 150);
            this.tblStats.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secrets:";
            // 
            // pbSecrets
            // 
            this.pbSecrets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSecrets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSecrets.Location = new System.Drawing.Point(15, 25);
            this.pbSecrets.Margin = new System.Windows.Forms.Padding(0);
            this.pbSecrets.Name = "pbSecrets";
            this.pbSecrets.Size = new System.Drawing.Size(20, 20);
            this.pbSecrets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSecrets.TabIndex = 7;
            this.pbSecrets.TabStop = false;
            // 
            // ctrlStatsSecrets
            // 
            this.ctrlStatsSecrets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlStatsSecrets.Location = new System.Drawing.Point(104, 28);
            this.ctrlStatsSecrets.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.ctrlStatsSecrets.MaximumSize = new System.Drawing.Size(0, 21);
            this.ctrlStatsSecrets.Name = "ctrlStatsSecrets";
            this.ctrlStatsSecrets.Size = new System.Drawing.Size(198, 19);
            this.ctrlStatsSecrets.TabIndex = 10;
            // 
            // ctrlStatsKills
            // 
            this.ctrlStatsKills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlStatsKills.Location = new System.Drawing.Point(104, 4);
            this.ctrlStatsKills.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.ctrlStatsKills.MaximumSize = new System.Drawing.Size(0, 21);
            this.ctrlStatsKills.Name = "ctrlStatsKills";
            this.ctrlStatsKills.Size = new System.Drawing.Size(198, 20);
            this.ctrlStatsKills.TabIndex = 12;
            // 
            // pbKills
            // 
            this.pbKills.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbKills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbKills.Location = new System.Drawing.Point(15, 2);
            this.pbKills.Margin = new System.Windows.Forms.Padding(0);
            this.pbKills.Name = "pbKills";
            this.pbKills.Size = new System.Drawing.Size(20, 20);
            this.pbKills.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKills.TabIndex = 6;
            this.pbKills.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kills:";
            // 
            // StatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblStats);
            this.Name = "StatsControl";
            this.Size = new System.Drawing.Size(306, 150);
            this.tblStats.ResumeLayout(false);
            this.tblStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecrets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSecrets;
        private StatBar ctrlStatsSecrets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbKills;
        private StatBar ctrlStatsKills;
    }
}
