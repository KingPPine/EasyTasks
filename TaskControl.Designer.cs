namespace EasyTasks
{
    partial class taskControl
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
            this.editButton = new System.Windows.Forms.Button();
            this.taskTitleTextbox = new System.Windows.Forms.TextBox();
            this.controlTimer = new System.Windows.Forms.Timer(this.components);
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.editButton.TabIndex = 1;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // taskTitleTextbox
            // 
            this.taskTitleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(195)))), ((int)(((byte)(145)))));
            this.taskTitleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTitleTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taskTitleTextbox.ForeColor = System.Drawing.Color.White;
            this.taskTitleTextbox.Location = new System.Drawing.Point(8, 3);
            this.taskTitleTextbox.MaximumSize = new System.Drawing.Size(343, 32);
            this.taskTitleTextbox.MinimumSize = new System.Drawing.Size(113, 32);
            this.taskTitleTextbox.Name = "taskTitleTextbox";
            this.taskTitleTextbox.PlaceholderText = "Task Title";
            this.taskTitleTextbox.ReadOnly = true;
            this.taskTitleTextbox.Size = new System.Drawing.Size(113, 32);
            this.taskTitleTextbox.TabIndex = 3;
            this.taskTitleTextbox.TextChanged += new System.EventHandler(this.taskTitleTextbox_TextChanged);
            this.taskTitleTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskTitleTextbox_KeyDown);
            // 
            // controlTimer
            // 
            this.controlTimer.Enabled = true;
            this.controlTimer.Interval = 5;
            this.controlTimer.Tick += new System.EventHandler(this.TimerUpdate);
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.AutoSize = true;
            this.taskTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taskTitleLabel.ForeColor = System.Drawing.Color.White;
            this.taskTitleLabel.Location = new System.Drawing.Point(8, 3);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(69, 32);
            this.taskTitleLabel.TabIndex = 14;
            this.taskTitleLabel.Text = "label";
            this.taskTitleLabel.Visible = false;
            // 
            // taskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(195)))), ((int)(((byte)(145)))));
            this.Controls.Add(this.taskTitleLabel);
            this.Controls.Add(this.taskTitleTextbox);
            this.Controls.Add(this.editButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "taskControl";
            this.Size = new System.Drawing.Size(388, 98);
            this.Click += new System.EventHandler(this.taskControl_Click);
            this.MouseEnter += new System.EventHandler(this.taskControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.taskControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button editButton;
        private TextBox taskTitleTextbox;
        private System.Windows.Forms.Timer controlTimer;
        private Label taskTitleLabel;
    }
}
