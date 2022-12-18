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
            this.addTaskButton = new System.Windows.Forms.Button();
            this.addGoalButton = new System.Windows.Forms.Button();
            this.taskLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.goalLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.expandCollapseButton = new EasyTasks.RoundButton();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.IndianRed;
            this.addTaskButton.BackgroundImage = global::EasyTasks.Properties.Resources.roundedButton;
            this.addTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.addTaskButton.FlatAppearance.BorderSize = 0;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.Location = new System.Drawing.Point(12, 53);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(37, 30);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.Text = "+";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // addGoalButton
            // 
            this.addGoalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addGoalButton.BackColor = System.Drawing.Color.IndianRed;
            this.addGoalButton.BackgroundImage = global::EasyTasks.Properties.Resources.roundedButton;
            this.addGoalButton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.addGoalButton.FlatAppearance.BorderSize = 0;
            this.addGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGoalButton.ForeColor = System.Drawing.Color.White;
            this.addGoalButton.Location = new System.Drawing.Point(1282, 59);
            this.addGoalButton.Name = "addGoalButton";
            this.addGoalButton.Size = new System.Drawing.Size(37, 30);
            this.addGoalButton.TabIndex = 2;
            this.addGoalButton.Text = "+";
            this.addGoalButton.UseVisualStyleBackColor = false;
            // 
            // taskLayoutPanel
            // 
            this.taskLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.taskLayoutPanel.AutoScroll = true;
            this.taskLayoutPanel.Location = new System.Drawing.Point(12, 89);
            this.taskLayoutPanel.MaximumSize = new System.Drawing.Size(560, 0);
            this.taskLayoutPanel.MinimumSize = new System.Drawing.Size(560, 0);
            this.taskLayoutPanel.Name = "taskLayoutPanel";
            this.taskLayoutPanel.Size = new System.Drawing.Size(560, 734);
            this.taskLayoutPanel.TabIndex = 3;
            this.taskLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.taskLayoutPanel_Paint);
            // 
            // goalLayoutPanel
            // 
            this.goalLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalLayoutPanel.AutoScroll = true;
            this.goalLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.goalLayoutPanel.Location = new System.Drawing.Point(759, 95);
            this.goalLayoutPanel.MaximumSize = new System.Drawing.Size(560, 0);
            this.goalLayoutPanel.MinimumSize = new System.Drawing.Size(560, 0);
            this.goalLayoutPanel.Name = "goalLayoutPanel";
            this.goalLayoutPanel.Size = new System.Drawing.Size(560, 728);
            this.goalLayoutPanel.TabIndex = 4;
            // 
            // expandCollapseButton
            // 
            this.expandCollapseButton.BackColor = System.Drawing.Color.IndianRed;
            this.expandCollapseButton.FlatAppearance.BorderSize = 0;
            this.expandCollapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandCollapseButton.Location = new System.Drawing.Point(441, -13);
            this.expandCollapseButton.Name = "expandCollapseButton";
            this.expandCollapseButton.RoundedRadius = 10;
            this.expandCollapseButton.Size = new System.Drawing.Size(204, 17);
            this.expandCollapseButton.TabIndex = 5;
            this.expandCollapseButton.UseVisualStyleBackColor = false;
            this.expandCollapseButton.Click += new System.EventHandler(this.expandCollapseButton_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1331, 873);
            this.Controls.Add(this.expandCollapseButton);
            this.Controls.Add(this.goalLayoutPanel);
            this.Controls.Add(this.taskLayoutPanel);
            this.Controls.Add(this.addGoalButton);
            this.Controls.Add(this.addTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parent";
            this.ShowInTaskbar = false;
            this.Text = "EasyTasks";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Parent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        
        private Button addTaskButton;
        private Button addGoalButton;
        private FlowLayoutPanel taskLayoutPanel;
        private FlowLayoutPanel goalLayoutPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundButton expandCollapseButton;
    }
}