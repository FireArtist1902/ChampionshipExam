namespace ChampionshipExam
{
    partial class StartForm
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
            SubmitBtn = new Button();
            GoalsConcededTB = new TextBox();
            GoalsScoredTB = new TextBox();
            DrawsTB = new TextBox();
            DefeatsTB = new TextBox();
            WinsTB = new TextBox();
            TownTB = new TextBox();
            NameTB = new TextBox();
            TeamCB = new ComboBox();
            FieldsGB = new GroupBox();
            menuToolStripMenuItem = new ToolStripMenuItem();
            DeleteTeamToolStripMenuItem = new ToolStripMenuItem();
            AddTeamToolStripMenuItem = new ToolStripMenuItem();
            InfoAboutTeamByTownNameToolStripMenuItem = new ToolStripMenuItem();
            InfoAboutTeamNAmeAndTownNameToolStripMenuItem = new ToolStripMenuItem();
            TeamWithTheMostWinsToolStripMenuItem = new ToolStripMenuItem();
            TeamWithTheMostLossesToolStripMenuItem = new ToolStripMenuItem();
            TeamWithTheMostDrawsToolStripMenuItem = new ToolStripMenuItem();
            TeamWithTheMostScoredGoalsToolStripMenuItem = new ToolStripMenuItem();
            TeamWithTheMostConcededGoalsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            FieldsGB.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(29, 454);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 29);
            SubmitBtn.TabIndex = 26;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // GoalsConcededTB
            // 
            GoalsConcededTB.Location = new Point(14, 394);
            GoalsConcededTB.Name = "GoalsConcededTB";
            GoalsConcededTB.PlaceholderText = "GoalsConceded";
            GoalsConcededTB.Size = new Size(125, 27);
            GoalsConcededTB.TabIndex = 25;
            // 
            // GoalsScoredTB
            // 
            GoalsScoredTB.Location = new Point(14, 334);
            GoalsScoredTB.Name = "GoalsScoredTB";
            GoalsScoredTB.PlaceholderText = "GoalsScored";
            GoalsScoredTB.Size = new Size(125, 27);
            GoalsScoredTB.TabIndex = 24;
            // 
            // DrawsTB
            // 
            DrawsTB.Location = new Point(14, 274);
            DrawsTB.Name = "DrawsTB";
            DrawsTB.PlaceholderText = "Draws";
            DrawsTB.Size = new Size(125, 27);
            DrawsTB.TabIndex = 23;
            // 
            // DefeatsTB
            // 
            DefeatsTB.Location = new Point(14, 214);
            DefeatsTB.Name = "DefeatsTB";
            DefeatsTB.PlaceholderText = "Defeats";
            DefeatsTB.Size = new Size(125, 27);
            DefeatsTB.TabIndex = 22;
            // 
            // WinsTB
            // 
            WinsTB.Location = new Point(14, 154);
            WinsTB.Name = "WinsTB";
            WinsTB.PlaceholderText = "Wins";
            WinsTB.Size = new Size(125, 27);
            WinsTB.TabIndex = 21;
            // 
            // TownTB
            // 
            TownTB.Location = new Point(14, 94);
            TownTB.Name = "TownTB";
            TownTB.PlaceholderText = "Town";
            TownTB.Size = new Size(125, 27);
            TownTB.TabIndex = 20;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(14, 34);
            NameTB.Name = "NameTB";
            NameTB.PlaceholderText = "Name";
            NameTB.Size = new Size(125, 27);
            NameTB.TabIndex = 19;
            // 
            // TeamCB
            // 
            TeamCB.FormattingEnabled = true;
            TeamCB.Location = new Point(171, 47);
            TeamCB.Name = "TeamCB";
            TeamCB.Size = new Size(209, 28);
            TeamCB.TabIndex = 27;
            TeamCB.Text = "Існуючі команди";
            TeamCB.SelectedIndexChanged += TeamCB_SelectedIndexChanged_1;
            // 
            // FieldsGB
            // 
            FieldsGB.Controls.Add(NameTB);
            FieldsGB.Controls.Add(TownTB);
            FieldsGB.Controls.Add(SubmitBtn);
            FieldsGB.Controls.Add(WinsTB);
            FieldsGB.Controls.Add(GoalsConcededTB);
            FieldsGB.Controls.Add(DefeatsTB);
            FieldsGB.Controls.Add(GoalsScoredTB);
            FieldsGB.Controls.Add(DrawsTB);
            FieldsGB.Location = new Point(0, 36);
            FieldsGB.Name = "FieldsGB";
            FieldsGB.Size = new Size(165, 489);
            FieldsGB.TabIndex = 28;
            FieldsGB.TabStop = false;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DeleteTeamToolStripMenuItem, AddTeamToolStripMenuItem, InfoAboutTeamByTownNameToolStripMenuItem, InfoAboutTeamNAmeAndTownNameToolStripMenuItem, TeamWithTheMostWinsToolStripMenuItem, TeamWithTheMostLossesToolStripMenuItem, TeamWithTheMostDrawsToolStripMenuItem, TeamWithTheMostScoredGoalsToolStripMenuItem, TeamWithTheMostConcededGoalsToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // DeleteTeamToolStripMenuItem
            // 
            DeleteTeamToolStripMenuItem.Name = "DeleteTeamToolStripMenuItem";
            DeleteTeamToolStripMenuItem.Size = new Size(455, 26);
            DeleteTeamToolStripMenuItem.Text = "Видалити команду";
            DeleteTeamToolStripMenuItem.Click += DeleteTeamToolStripMenuItem_Click;
            // 
            // AddTeamToolStripMenuItem
            // 
            AddTeamToolStripMenuItem.Name = "AddTeamToolStripMenuItem";
            AddTeamToolStripMenuItem.Size = new Size(455, 26);
            AddTeamToolStripMenuItem.Text = "Додати команду";
            AddTeamToolStripMenuItem.Click += AddTeamToolStripMenuItem_Click;
            // 
            // InfoAboutTeamByTownNameToolStripMenuItem
            // 
            InfoAboutTeamByTownNameToolStripMenuItem.Name = "InfoAboutTeamByTownNameToolStripMenuItem";
            InfoAboutTeamByTownNameToolStripMenuItem.Size = new Size(455, 26);
            InfoAboutTeamByTownNameToolStripMenuItem.Text = "Інформація про команду за назвою міста";
            // 
            // InfoAboutTeamNAmeAndTownNameToolStripMenuItem
            // 
            InfoAboutTeamNAmeAndTownNameToolStripMenuItem.Name = "InfoAboutTeamNAmeAndTownNameToolStripMenuItem";
            InfoAboutTeamNAmeAndTownNameToolStripMenuItem.Size = new Size(455, 26);
            InfoAboutTeamNAmeAndTownNameToolStripMenuItem.Text = "Інформація про команду за назвою та містом";
            InfoAboutTeamNAmeAndTownNameToolStripMenuItem.Click += InfoAboutTeamNAmeAndTownNameToolStripMenuItem_Click;
            // 
            // TeamWithTheMostWinsToolStripMenuItem
            // 
            TeamWithTheMostWinsToolStripMenuItem.Name = "TeamWithTheMostWinsToolStripMenuItem";
            TeamWithTheMostWinsToolStripMenuItem.Size = new Size(455, 26);
            TeamWithTheMostWinsToolStripMenuItem.Text = "Команда з найбільшою кількістю перемог";
            TeamWithTheMostWinsToolStripMenuItem.Click += TeamWithTheMostWinsToolStripMenuItem_Click;
            // 
            // TeamWithTheMostLossesToolStripMenuItem
            // 
            TeamWithTheMostLossesToolStripMenuItem.Name = "TeamWithTheMostLossesToolStripMenuItem";
            TeamWithTheMostLossesToolStripMenuItem.Size = new Size(455, 26);
            TeamWithTheMostLossesToolStripMenuItem.Text = "Команда з найбільшою кількістю поразок";
            // 
            // TeamWithTheMostDrawsToolStripMenuItem
            // 
            TeamWithTheMostDrawsToolStripMenuItem.Name = "TeamWithTheMostDrawsToolStripMenuItem";
            TeamWithTheMostDrawsToolStripMenuItem.Size = new Size(455, 26);
            TeamWithTheMostDrawsToolStripMenuItem.Text = "Команда з найбільшою кількістю ігор у нічию";
            // 
            // TeamWithTheMostScoredGoalsToolStripMenuItem
            // 
            TeamWithTheMostScoredGoalsToolStripMenuItem.Name = "TeamWithTheMostScoredGoalsToolStripMenuItem";
            TeamWithTheMostScoredGoalsToolStripMenuItem.Size = new Size(455, 26);
            TeamWithTheMostScoredGoalsToolStripMenuItem.Text = "Команда з найбільшою кількістю забитих голів";
            // 
            // TeamWithTheMostConcededGoalsToolStripMenuItem
            // 
            TeamWithTheMostConcededGoalsToolStripMenuItem.Name = "TeamWithTheMostConcededGoalsToolStripMenuItem";
            TeamWithTheMostConcededGoalsToolStripMenuItem.Size = new Size(455, 26);
            TeamWithTheMostConcededGoalsToolStripMenuItem.Text = "Команда з найбільшою кількістю пропущених голів";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(392, 28);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 529);
            Controls.Add(FieldsGB);
            Controls.Add(TeamCB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StartForm";
            Text = "Form1";
            Load += Form1_Load;
            Click += StartForm_Click;
            FieldsGB.ResumeLayout(false);
            FieldsGB.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button12;
        private Button button11;
        private Button button10;
        private Button SubmitBtn;
        private TextBox GoalsConcededTB;
        private TextBox GoalsScoredTB;
        private TextBox DrawsTB;
        private TextBox DefeatsTB;
        private TextBox WinsTB;
        private TextBox TownTB;
        private TextBox NameTB;
        private ComboBox TeamCB;
        private GroupBox FieldsGB;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem DeleteTeamToolStripMenuItem;
        private ToolStripMenuItem AddTeamToolStripMenuItem;
        private ToolStripMenuItem InfoAboutTeamByTownNameToolStripMenuItem;
        private ToolStripMenuItem InfoAboutTeamNAmeAndTownNameToolStripMenuItem;
        private ToolStripMenuItem TeamWithTheMostWinsToolStripMenuItem;
        private ToolStripMenuItem TeamWithTheMostLossesToolStripMenuItem;
        private ToolStripMenuItem TeamWithTheMostDrawsToolStripMenuItem;
        private ToolStripMenuItem TeamWithTheMostScoredGoalsToolStripMenuItem;
        private ToolStripMenuItem TeamWithTheMostConcededGoalsToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}