namespace EasyTasks
{
    partial class GoalControl
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controlTimer = new System.Windows.Forms.Timer(this.components);
            this.goalTitleTextbox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.customProgressBar1 = new EasyTasks.CustomProgressBar();
            this.startValueLabel = new System.Windows.Forms.Label();
            this.endValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controlTimer
            // 
            this.controlTimer.Enabled = true;
            this.controlTimer.Interval = 5;
            this.controlTimer.Tick += new System.EventHandler(this.TimerUpdate);
            // 
            // goalTitleTextbox
            // 
            this.goalTitleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(195)))), ((int)(((byte)(145)))));
            this.goalTitleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goalTitleTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalTitleTextbox.ForeColor = System.Drawing.Color.White;
            this.goalTitleTextbox.Location = new System.Drawing.Point(8, 3);
            this.goalTitleTextbox.MaximumSize = new System.Drawing.Size(343, 32);
            this.goalTitleTextbox.MinimumSize = new System.Drawing.Size(113, 32);
            this.goalTitleTextbox.Name = "goalTitleTextbox";
            this.goalTitleTextbox.PlaceholderText = "Goal Title";
            this.goalTitleTextbox.ReadOnly = true;
            this.goalTitleTextbox.Size = new System.Drawing.Size(113, 32);
            this.goalTitleTextbox.TabIndex = 5;
            this.goalTitleTextbox.TextChanged += new System.EventHandler(this.goalTitleTextbox_TextChanged);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackgroundImage = global::EasyTasks.Properties.Resources.edit;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(344, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(32, 32);
            this.editButton.TabIndex = 4;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.Location = new System.Drawing.Point(8, 41);
            this.customProgressBar1.Maximum = 100;
            this.customProgressBar1.Minimum = 0;
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.ProgressBarColor = System.Drawing.Color.IndianRed;
            this.customProgressBar1.Size = new System.Drawing.Size(368, 13);
            this.customProgressBar1.TabIndex = 6;
            this.customProgressBar1.Value = 20;
            // 
            // startValueLabel
            // 
            this.startValueLabel.AutoSize = true;
            this.startValueLabel.Location = new System.Drawing.Point(8, 57);
            this.startValueLabel.Name = "startValueLabel";
            this.startValueLabel.Size = new System.Drawing.Size(62, 15);
            this.startValueLabel.TabIndex = 7;
            this.startValueLabel.Text = "Start Value";
            // 
            // endValueLabel
            // 
            this.endValueLabel.AutoSize = true;
            this.endValueLabel.Location = new System.Drawing.Point(314, 57);
            this.endValueLabel.Name = "endValueLabel";
            this.endValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endValueLabel.Size = new System.Drawing.Size(58, 15);
            this.endValueLabel.TabIndex = 8;
            this.endValueLabel.Text = "End Value";
            this.endValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GoalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(195)))), ((int)(((byte)(145)))));
            this.Controls.Add(this.endValueLabel);
            this.Controls.Add(this.startValueLabel);
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.goalTitleTextbox);
            this.Controls.Add(this.editButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GoalControl";
            this.Size = new System.Drawing.Size(388, 98);
            this.Click += new System.EventHandler(this.GoalControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer controlTimer;
        private TextBox goalTitleTextbox;
        private Button editButton;
        private CustomProgressBar customProgressBar1;
        private Label startValueLabel;
        private Label endValueLabel;
    }
}
