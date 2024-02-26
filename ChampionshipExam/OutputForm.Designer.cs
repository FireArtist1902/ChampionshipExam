namespace ChampionshipExam
{
    partial class OutputForm
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
            NameLb = new Label();
            TownLb = new Label();
            WinsLb = new Label();
            DefeatsLb = new Label();
            DrawsLb = new Label();
            GoalsScoredLb = new Label();
            GoalsConcededLb = new Label();
            SuspendLayout();
            // 
            // NameLb
            // 
            NameLb.AutoSize = true;
            NameLb.Location = new Point(130, 85);
            NameLb.Name = "NameLb";
            NameLb.Size = new Size(50, 20);
            NameLb.TabIndex = 1;
            NameLb.Text = "label1";
            // 
            // TownLb
            // 
            TownLb.AutoSize = true;
            TownLb.Location = new Point(130, 128);
            TownLb.Name = "TownLb";
            TownLb.Size = new Size(50, 20);
            TownLb.TabIndex = 2;
            TownLb.Text = "label2";
            // 
            // WinsLb
            // 
            WinsLb.AutoSize = true;
            WinsLb.Location = new Point(130, 170);
            WinsLb.Name = "WinsLb";
            WinsLb.Size = new Size(50, 20);
            WinsLb.TabIndex = 3;
            WinsLb.Text = "label3";
            // 
            // DefeatsLb
            // 
            DefeatsLb.AutoSize = true;
            DefeatsLb.Location = new Point(130, 214);
            DefeatsLb.Name = "DefeatsLb";
            DefeatsLb.Size = new Size(50, 20);
            DefeatsLb.TabIndex = 4;
            DefeatsLb.Text = "label4";
            // 
            // DrawsLb
            // 
            DrawsLb.AutoSize = true;
            DrawsLb.Location = new Point(130, 261);
            DrawsLb.Name = "DrawsLb";
            DrawsLb.Size = new Size(50, 20);
            DrawsLb.TabIndex = 5;
            DrawsLb.Text = "label5";
            // 
            // GoalsScoredLb
            // 
            GoalsScoredLb.AutoSize = true;
            GoalsScoredLb.Location = new Point(130, 312);
            GoalsScoredLb.Name = "GoalsScoredLb";
            GoalsScoredLb.Size = new Size(50, 20);
            GoalsScoredLb.TabIndex = 6;
            GoalsScoredLb.Text = "label6";
            // 
            // GoalsConcededLb
            // 
            GoalsConcededLb.AutoSize = true;
            GoalsConcededLb.Location = new Point(130, 360);
            GoalsConcededLb.Name = "GoalsConcededLb";
            GoalsConcededLb.Size = new Size(50, 20);
            GoalsConcededLb.TabIndex = 7;
            GoalsConcededLb.Text = "label7";
            // 
            // OutputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 434);
            Controls.Add(GoalsConcededLb);
            Controls.Add(GoalsScoredLb);
            Controls.Add(DrawsLb);
            Controls.Add(DefeatsLb);
            Controls.Add(WinsLb);
            Controls.Add(TownLb);
            Controls.Add(NameLb);
            Name = "OutputForm";
            Text = "OutputForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLb;
        private Label TownLb;
        private Label WinsLb;
        private Label DefeatsLb;
        private Label DrawsLb;
        private Label GoalsScoredLb;
        private Label GoalsConcededLb;
    }
}