namespace Cod4ServerLauncher
{
    partial class Form1
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
            LaunchBtn = new Button();
            CloseBtn = new Button();
            groupBox1 = new GroupBox();
            BrowseBtn = new Button();
            MapList = new ListBox();
            label1 = new Label();
            CoD4PathInput = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            checkBoxDedicated = new CheckBox();
            label2 = new Label();
            NumBots = new TextBox();
            label3 = new Label();
            SkillLvl = new TextBox();
            label4 = new Label();
            ScoreLimit = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LaunchBtn
            // 
            LaunchBtn.Location = new Point(614, 397);
            LaunchBtn.Name = "LaunchBtn";
            LaunchBtn.Size = new Size(75, 23);
            LaunchBtn.TabIndex = 0;
            LaunchBtn.Text = "Launch";
            LaunchBtn.UseVisualStyleBackColor = true;
            LaunchBtn.Click += LaunchBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(695, 397);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 1;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ScoreLimit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SkillLvl);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(NumBots);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkBoxDedicated);
            groupBox1.Controls.Add(BrowseBtn);
            groupBox1.Controls.Add(MapList);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CoD4PathInput);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(LaunchBtn);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuration";
            // 
            // BrowseBtn
            // 
            BrowseBtn.Location = new Point(723, 54);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(35, 23);
            BrowseBtn.TabIndex = 5;
            BrowseBtn.Text = "...";
            BrowseBtn.UseVisualStyleBackColor = true;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // MapList
            // 
            MapList.FormattingEnabled = true;
            MapList.ItemHeight = 15;
            MapList.Location = new Point(20, 98);
            MapList.Name = "MapList";
            MapList.Size = new Size(276, 274);
            MapList.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 57);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "CoD4-Path:";
            // 
            // CoD4PathInput
            // 
            CoD4PathInput.Location = new Point(88, 54);
            CoD4PathInput.Name = "CoD4PathInput";
            CoD4PathInput.Size = new Size(629, 23);
            CoD4PathInput.TabIndex = 2;
            // 
            // checkBoxDedicated
            // 
            checkBoxDedicated.AutoSize = true;
            checkBoxDedicated.Location = new Point(324, 105);
            checkBoxDedicated.Name = "checkBoxDedicated";
            checkBoxDedicated.Size = new Size(78, 19);
            checkBoxDedicated.TabIndex = 6;
            checkBoxDedicated.Text = "dedicated";
            checkBoxDedicated.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 136);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "Count Bots";
            // 
            // NumBots
            // 
            NumBots.Location = new Point(396, 133);
            NumBots.MaxLength = 2;
            NumBots.Name = "NumBots";
            NumBots.Size = new Size(47, 23);
            NumBots.TabIndex = 8;
            NumBots.Text = "4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 172);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 9;
            label3.Text = "Skill Lvl";
            // 
            // SkillLvl
            // 
            SkillLvl.Location = new Point(396, 169);
            SkillLvl.MaxLength = 1;
            SkillLvl.Name = "SkillLvl";
            SkillLvl.Size = new Size(47, 23);
            SkillLvl.TabIndex = 10;
            SkillLvl.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 209);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 11;
            label4.Text = "Score limit";
            // 
            // ScoreLimit
            // 
            ScoreLimit.Location = new Point(396, 206);
            ScoreLimit.MaxLength = 5;
            ScoreLimit.Name = "ScoreLimit";
            ScoreLimit.Size = new Size(86, 23);
            ScoreLimit.TabIndex = 12;
            ScoreLimit.Text = "5000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Cod4ServerLauncher";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LaunchBtn;
        private Button CloseBtn;
        private GroupBox groupBox1;
        private TextBox CoD4PathInput;
        private Label label1;
        private ListBox MapList;
        private Button BrowseBtn;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBoxDedicated;
        private TextBox NumBots;
        private Label label2;
        private Label label3;
        private TextBox SkillLvl;
        private TextBox ScoreLimit;
        private Label label4;
    }
}