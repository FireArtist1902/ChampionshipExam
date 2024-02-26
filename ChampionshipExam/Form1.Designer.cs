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
            DeleteTeamBtn = new Button();
            AddTeamBtn = new Button();
            TEamByMoreGoalsConcededBtn = new Button();
            TEamByMostGoalsBtn = new Button();
            TeamByMostDrawsBtn = new Button();
            TeamByMostDefeatsBtn = new Button();
            TeamWithMostWinsBtn = new Button();
            TeamByNameAndTownBtn = new Button();
            TeamByTownNameBtn = new Button();
            InfoByTeamNameBtn = new Button();
            SubmitBtn = new Button();
            GoalsConcededTB = new TextBox();
            GoalsScoredTB = new TextBox();
            DrawsTB = new TextBox();
            DefeatsTB = new TextBox();
            WinsTB = new TextBox();
            TownTB = new TextBox();
            NameTB = new TextBox();
            SuspendLayout();
            // 
            // DeleteTeamBtn
            // 
            DeleteTeamBtn.AutoSize = true;
            DeleteTeamBtn.Location = new Point(126, 75);
            DeleteTeamBtn.Name = "DeleteTeamBtn";
            DeleteTeamBtn.Size = new Size(148, 30);
            DeleteTeamBtn.TabIndex = 1;
            DeleteTeamBtn.Text = "Видалити команду";
            DeleteTeamBtn.UseVisualStyleBackColor = true;
            DeleteTeamBtn.Click += DeleteTeamBtn_Click;
            // 
            // AddTeamBtn
            // 
            AddTeamBtn.AutoSize = true;
            AddTeamBtn.Location = new Point(134, 34);
            AddTeamBtn.Name = "AddTeamBtn";
            AddTeamBtn.Size = new Size(132, 30);
            AddTeamBtn.TabIndex = 0;
            AddTeamBtn.Text = "Додати команду";
            AddTeamBtn.UseVisualStyleBackColor = true;
            AddTeamBtn.Click += AddTeamBtn_Click;
            // 
            // TEamByMoreGoalsConcededBtn
            // 
            TEamByMoreGoalsConcededBtn.AutoSize = true;
            TEamByMoreGoalsConcededBtn.Location = new Point(9, 403);
            TEamByMoreGoalsConcededBtn.Name = "TEamByMoreGoalsConcededBtn";
            TEamByMoreGoalsConcededBtn.Size = new Size(382, 30);
            TEamByMoreGoalsConcededBtn.TabIndex = 15;
            TEamByMoreGoalsConcededBtn.Text = "Команда з найбільшою кількістю пропущених голів";
            TEamByMoreGoalsConcededBtn.UseVisualStyleBackColor = true;
            TEamByMoreGoalsConcededBtn.Click += TEamByMoreGoalsConcededBtn_Click;
            // 
            // TEamByMostGoalsBtn
            // 
            TEamByMostGoalsBtn.AutoSize = true;
            TEamByMostGoalsBtn.Location = new Point(26, 362);
            TEamByMostGoalsBtn.Name = "TEamByMostGoalsBtn";
            TEamByMostGoalsBtn.Size = new Size(349, 30);
            TEamByMostGoalsBtn.TabIndex = 14;
            TEamByMostGoalsBtn.Text = "Команда з найбільшою кількістю забитих голів";
            TEamByMostGoalsBtn.UseVisualStyleBackColor = true;
            TEamByMostGoalsBtn.Click += TEamByMostGoalsBtn_Click;
            // 
            // TeamByMostDrawsBtn
            // 
            TeamByMostDrawsBtn.AutoSize = true;
            TeamByMostDrawsBtn.Location = new Point(30, 321);
            TeamByMostDrawsBtn.Name = "TeamByMostDrawsBtn";
            TeamByMostDrawsBtn.Size = new Size(340, 30);
            TeamByMostDrawsBtn.TabIndex = 13;
            TeamByMostDrawsBtn.Text = "Команда з найбільшою кількістю ігор у нічию";
            TeamByMostDrawsBtn.UseVisualStyleBackColor = true;
            TeamByMostDrawsBtn.Click += TeamByMostDrawsBtn_Click;
            // 
            // TeamByMostDefeatsBtn
            // 
            TeamByMostDefeatsBtn.AutoSize = true;
            TeamByMostDefeatsBtn.Location = new Point(44, 280);
            TeamByMostDefeatsBtn.Name = "TeamByMostDefeatsBtn";
            TeamByMostDefeatsBtn.Size = new Size(313, 30);
            TeamByMostDefeatsBtn.TabIndex = 12;
            TeamByMostDefeatsBtn.Text = "Команда з найбільшою кількістю поразок";
            TeamByMostDefeatsBtn.UseVisualStyleBackColor = true;
            TeamByMostDefeatsBtn.Click += TeamByMostDefeatsBtn_Click;
            // 
            // TeamWithMostWinsBtn
            // 
            TeamWithMostWinsBtn.AutoSize = true;
            TeamWithMostWinsBtn.Location = new Point(39, 239);
            TeamWithMostWinsBtn.Name = "TeamWithMostWinsBtn";
            TeamWithMostWinsBtn.Size = new Size(323, 30);
            TeamWithMostWinsBtn.TabIndex = 11;
            TeamWithMostWinsBtn.Text = "Команда за найбільшою кількістю перемог";
            TeamWithMostWinsBtn.UseVisualStyleBackColor = true;
            TeamWithMostWinsBtn.Click += TeamWithMostWinsBtn_Click;
            // 
            // TeamByNameAndTownBtn
            // 
            TeamByNameAndTownBtn.AutoSize = true;
            TeamByNameAndTownBtn.Location = new Point(87, 198);
            TeamByNameAndTownBtn.Name = "TeamByNameAndTownBtn";
            TeamByNameAndTownBtn.Size = new Size(227, 30);
            TeamByNameAndTownBtn.TabIndex = 10;
            TeamByNameAndTownBtn.Text = "Команда за назвою та містом";
            TeamByNameAndTownBtn.UseVisualStyleBackColor = true;
            TeamByNameAndTownBtn.Click += TeamByNameAndTownBtn_Click;
            // 
            // TeamByTownNameBtn
            // 
            TeamByTownNameBtn.AutoSize = true;
            TeamByTownNameBtn.Location = new Point(102, 157);
            TeamByTownNameBtn.Name = "TeamByTownNameBtn";
            TeamByTownNameBtn.Size = new Size(197, 30);
            TeamByTownNameBtn.TabIndex = 9;
            TeamByTownNameBtn.Text = "Команда за назвою міста";
            TeamByTownNameBtn.UseVisualStyleBackColor = true;
            TeamByTownNameBtn.Click += TeamByTownNameBtn_Click;
            // 
            // InfoByTeamNameBtn
            // 
            InfoByTeamNameBtn.AutoSize = true;
            InfoByTeamNameBtn.Location = new Point(65, 116);
            InfoByTeamNameBtn.Name = "InfoByTeamNameBtn";
            InfoByTeamNameBtn.Size = new Size(270, 30);
            InfoByTeamNameBtn.TabIndex = 8;
            InfoByTeamNameBtn.Text = "Інформація про команду за назвою";
            InfoByTeamNameBtn.UseVisualStyleBackColor = true;
            InfoByTeamNameBtn.Click += InfoByTeamNameBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(495, 491);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 29);
            SubmitBtn.TabIndex = 26;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // GoalsConcededTB
            // 
            GoalsConcededTB.Location = new Point(480, 431);
            GoalsConcededTB.Name = "GoalsConcededTB";
            GoalsConcededTB.PlaceholderText = "GoalsConceded";
            GoalsConcededTB.Size = new Size(125, 27);
            GoalsConcededTB.TabIndex = 25;
            // 
            // GoalsScoredTB
            // 
            GoalsScoredTB.Location = new Point(480, 371);
            GoalsScoredTB.Name = "GoalsScoredTB";
            GoalsScoredTB.PlaceholderText = "GoalsScored";
            GoalsScoredTB.Size = new Size(125, 27);
            GoalsScoredTB.TabIndex = 24;
            // 
            // DrawsTB
            // 
            DrawsTB.Location = new Point(480, 311);
            DrawsTB.Name = "DrawsTB";
            DrawsTB.PlaceholderText = "Draws";
            DrawsTB.Size = new Size(125, 27);
            DrawsTB.TabIndex = 23;
            // 
            // DefeatsTB
            // 
            DefeatsTB.Location = new Point(480, 251);
            DefeatsTB.Name = "DefeatsTB";
            DefeatsTB.PlaceholderText = "Defeats";
            DefeatsTB.Size = new Size(125, 27);
            DefeatsTB.TabIndex = 22;
            // 
            // WinsTB
            // 
            WinsTB.Location = new Point(480, 191);
            WinsTB.Name = "WinsTB";
            WinsTB.PlaceholderText = "Wins";
            WinsTB.Size = new Size(125, 27);
            WinsTB.TabIndex = 21;
            // 
            // TownTB
            // 
            TownTB.Location = new Point(480, 131);
            TownTB.Name = "TownTB";
            TownTB.PlaceholderText = "Town";
            TownTB.Size = new Size(125, 27);
            TownTB.TabIndex = 20;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(480, 71);
            NameTB.Name = "NameTB";
            NameTB.PlaceholderText = "Name";
            NameTB.Size = new Size(125, 27);
            NameTB.TabIndex = 19;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 536);
            Controls.Add(SubmitBtn);
            Controls.Add(GoalsConcededTB);
            Controls.Add(GoalsScoredTB);
            Controls.Add(DrawsTB);
            Controls.Add(DefeatsTB);
            Controls.Add(WinsTB);
            Controls.Add(TownTB);
            Controls.Add(NameTB);
            Controls.Add(TEamByMoreGoalsConcededBtn);
            Controls.Add(TEamByMostGoalsBtn);
            Controls.Add(DeleteTeamBtn);
            Controls.Add(TeamByMostDrawsBtn);
            Controls.Add(AddTeamBtn);
            Controls.Add(TeamByMostDefeatsBtn);
            Controls.Add(TeamWithMostWinsBtn);
            Controls.Add(TeamByNameAndTownBtn);
            Controls.Add(TeamByTownNameBtn);
            Controls.Add(InfoByTeamNameBtn);
            Name = "StartForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteTeamBtn;
        private Button AddTeamBtn;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button TEamByMoreGoalsConcededBtn;
        private Button TEamByMostGoalsBtn;
        private Button TeamByMostDrawsBtn;
        private Button TeamByMostDefeatsBtn;
        private Button TeamWithMostWinsBtn;
        private Button TeamByNameAndTownBtn;
        private Button TeamByTownNameBtn;
        private Button InfoByTeamNameBtn;
        private Button SubmitBtn;
        private TextBox GoalsConcededTB;
        private TextBox GoalsScoredTB;
        private TextBox DrawsTB;
        private TextBox DefeatsTB;
        private TextBox WinsTB;
        private TextBox TownTB;
        private TextBox NameTB;
    }
}