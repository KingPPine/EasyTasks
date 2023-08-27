namespace EasyTasks
{
    partial class Parent
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
            components = new System.ComponentModel.Container();
            addTaskButton = new Button();
            addGoalButton = new Button();
            taskLayoutPanel = new FlowLayoutPanel();
            goalLayoutPanel = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            expandCollapseButton = new RoundButton();
            expandCollapseTimer = new System.Windows.Forms.Timer(components);
            testButton = new Button();
            SuspendLayout();
            // 
            // addTaskButton
            // 
            addTaskButton.BackColor = Color.IndianRed;
            addTaskButton.BackgroundImage = Properties.Resources.roundedButton;
            addTaskButton.FlatAppearance.BorderColor = Color.IndianRed;
            addTaskButton.FlatAppearance.BorderSize = 0;
            addTaskButton.FlatStyle = FlatStyle.Flat;
            addTaskButton.ForeColor = Color.White;
            addTaskButton.Location = new Point(12, 53);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(37, 30);
            addTaskButton.TabIndex = 1;
            addTaskButton.Text = "+";
            addTaskButton.UseVisualStyleBackColor = false;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // addGoalButton
            // 
            addGoalButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addGoalButton.BackColor = Color.IndianRed;
            addGoalButton.BackgroundImage = Properties.Resources.roundedButton;
            addGoalButton.FlatAppearance.BorderColor = Color.IndianRed;
            addGoalButton.FlatAppearance.BorderSize = 0;
            addGoalButton.FlatStyle = FlatStyle.Flat;
            addGoalButton.ForeColor = Color.White;
            addGoalButton.Location = new Point(1282, 53);
            addGoalButton.Name = "addGoalButton";
            addGoalButton.Size = new Size(37, 30);
            addGoalButton.TabIndex = 2;
            addGoalButton.Text = "+";
            addGoalButton.UseVisualStyleBackColor = false;
            addGoalButton.Click += addGoalButton_Click;
            // 
            // taskLayoutPanel
            // 
            taskLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            taskLayoutPanel.AutoScroll = true;
            taskLayoutPanel.BackgroundImageLayout = ImageLayout.None;
            taskLayoutPanel.Location = new Point(12, 89);
            taskLayoutPanel.MaximumSize = new Size(550, 0);
            taskLayoutPanel.Name = "taskLayoutPanel";
            taskLayoutPanel.Size = new Size(550, 735);
            taskLayoutPanel.TabIndex = 3;
            // 
            // goalLayoutPanel
            // 
            goalLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            goalLayoutPanel.AutoScroll = true;
            goalLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            goalLayoutPanel.Location = new Point(769, 89);
            goalLayoutPanel.MaximumSize = new Size(550, 0);
            goalLayoutPanel.Name = "goalLayoutPanel";
            goalLayoutPanel.Size = new Size(550, 735);
            goalLayoutPanel.TabIndex = 4;
            // 
            // expandCollapseButton
            // 
            expandCollapseButton.BackColor = Color.IndianRed;
            expandCollapseButton.FlatAppearance.BorderSize = 0;
            expandCollapseButton.FlatStyle = FlatStyle.Flat;
            expandCollapseButton.Location = new Point(441, -14);
            expandCollapseButton.Name = "expandCollapseButton";
            expandCollapseButton.RoundedRadius = 10;
            expandCollapseButton.Size = new Size(204, 17);
            expandCollapseButton.TabIndex = 5;
            expandCollapseButton.UseVisualStyleBackColor = false;
            expandCollapseButton.Click += expandCollapseButton_Click;
            // 
            // expandCollapseTimer
            // 
            expandCollapseTimer.Enabled = true;
            expandCollapseTimer.Interval = 5;
            expandCollapseTimer.Tick += TimerUpdate;
            // 
            // testButton
            // 
            testButton.Location = new Point(978, 34);
            testButton.Name = "testButton";
            testButton.Size = new Size(75, 23);
            testButton.TabIndex = 6;
            testButton.Text = "testButton";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // Parent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1331, 873);
            Controls.Add(testButton);
            Controls.Add(expandCollapseButton);
            Controls.Add(goalLayoutPanel);
            Controls.Add(taskLayoutPanel);
            Controls.Add(addGoalButton);
            Controls.Add(addTaskButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Parent";
            ShowInTaskbar = false;
            Text = "EasyTasks";
            TopMost = true;
            TransparencyKey = Color.Black;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion


        private Button addTaskButton;
        private Button addGoalButton;
        private FlowLayoutPanel taskLayoutPanel;
        private FlowLayoutPanel goalLayoutPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundButton expandCollapseButton;
        private System.Windows.Forms.Timer expandCollapseTimer;
        private Button testButton;
    }
}