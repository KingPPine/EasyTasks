namespace EasyTasks
{
    partial class TaskControl
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
            this.bottomRightCornerImage = new System.Windows.Forms.PictureBox();
            this.bottomLeftCornerImage = new System.Windows.Forms.PictureBox();
            this.topRightCornerImage = new System.Windows.Forms.PictureBox();
            this.topLeftCornerImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightCornerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftCornerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightCornerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftCornerImage)).BeginInit();
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
            // bottomRightCornerImage
            // 
            this.bottomRightCornerImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomRightCornerImage.BackColor = System.Drawing.Color.Transparent;
            this.bottomRightCornerImage.Image = global::EasyTasks.Properties.Resources.pixel_corner_bottomright;
            this.bottomRightCornerImage.Location = new System.Drawing.Point(385, 95);
            this.bottomRightCornerImage.Name = "bottomRightCornerImage";
            this.bottomRightCornerImage.Size = new System.Drawing.Size(3, 3);
            this.bottomRightCornerImage.TabIndex = 27;
            this.bottomRightCornerImage.TabStop = false;
            // 
            // bottomLeftCornerImage
            // 
            this.bottomLeftCornerImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomLeftCornerImage.BackColor = System.Drawing.Color.Transparent;
            this.bottomLeftCornerImage.Image = global::EasyTasks.Properties.Resources.pixel_corner_bottomleft;
            this.bottomLeftCornerImage.Location = new System.Drawing.Point(0, 95);
            this.bottomLeftCornerImage.Name = "bottomLeftCornerImage";
            this.bottomLeftCornerImage.Size = new System.Drawing.Size(3, 3);
            this.bottomLeftCornerImage.TabIndex = 26;
            this.bottomLeftCornerImage.TabStop = false;
            // 
            // topRightCornerImage
            // 
            this.topRightCornerImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topRightCornerImage.BackColor = System.Drawing.Color.Transparent;
            this.topRightCornerImage.Image = global::EasyTasks.Properties.Resources.pixel_corner_topright;
            this.topRightCornerImage.Location = new System.Drawing.Point(385, 0);
            this.topRightCornerImage.Name = "topRightCornerImage";
            this.topRightCornerImage.Size = new System.Drawing.Size(3, 3);
            this.topRightCornerImage.TabIndex = 25;
            this.topRightCornerImage.TabStop = false;
            // 
            // topLeftCornerImage
            // 
            this.topLeftCornerImage.BackColor = System.Drawing.Color.Transparent;
            this.topLeftCornerImage.Image = global::EasyTasks.Properties.Resources.pixel_corner;
            this.topLeftCornerImage.Location = new System.Drawing.Point(0, 0);
            this.topLeftCornerImage.Name = "topLeftCornerImage";
            this.topLeftCornerImage.Size = new System.Drawing.Size(3, 3);
            this.topLeftCornerImage.TabIndex = 24;
            this.topLeftCornerImage.TabStop = false;
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(195)))), ((int)(((byte)(145)))));
            this.Controls.Add(this.bottomRightCornerImage);
            this.Controls.Add(this.bottomLeftCornerImage);
            this.Controls.Add(this.topRightCornerImage);
            this.Controls.Add(this.topLeftCornerImage);
            this.Controls.Add(this.taskTitleLabel);
            this.Controls.Add(this.taskTitleTextbox);
            this.Controls.Add(this.editButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(388, 98);
            this.Click += new System.EventHandler(this.taskControl_Click);
            this.MouseEnter += new System.EventHandler(this.taskControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.taskControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightCornerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftCornerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightCornerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftCornerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button editButton;
        private TextBox taskTitleTextbox;
        private System.Windows.Forms.Timer controlTimer;
        private Label taskTitleLabel;
        private PictureBox bottomRightCornerImage;
        private PictureBox bottomLeftCornerImage;
        private PictureBox topRightCornerImage;
        private PictureBox topLeftCornerImage;
    }
}
