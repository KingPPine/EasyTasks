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
            this.customProgressBar = new EasyTasks.CustomProgressBar();
            this.startValueLabel = new System.Windows.Forms.Label();
            this.endValueLabel = new System.Windows.Forms.Label();
            this.counterRadioButton = new System.Windows.Forms.RadioButton();
            this.numberRangeRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRangeRadioButton = new System.Windows.Forms.RadioButton();
            this.counterButton = new System.Windows.Forms.Button();
            this.goalTitleLabel = new System.Windows.Forms.Label();
            this.startValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EndValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rangeValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setValueButton = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.startValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeValueNumericUpDown)).BeginInit();
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
            this.goalTitleTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.goalTitleTextbox_KeyDown);
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
            // customProgressBar
            // 
            this.customProgressBar.Location = new System.Drawing.Point(8, 41);
            this.customProgressBar.Maximum = 100;
            this.customProgressBar.Minimum = 0;
            this.customProgressBar.Name = "customProgressBar";
            this.customProgressBar.ProgressBarColor = System.Drawing.Color.Turquoise;
            this.customProgressBar.Size = new System.Drawing.Size(368, 13);
            this.customProgressBar.TabIndex = 6;
            this.customProgressBar.Value = 0;
            // 
            // startValueLabel
            // 
            this.startValueLabel.AutoSize = true;
            this.startValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.startValueLabel.ForeColor = System.Drawing.Color.White;
            this.startValueLabel.Location = new System.Drawing.Point(8, 57);
            this.startValueLabel.Name = "startValueLabel";
            this.startValueLabel.Size = new System.Drawing.Size(13, 15);
            this.startValueLabel.TabIndex = 7;
            this.startValueLabel.Text = "0";
            this.startValueLabel.Visible = false;
            // 
            // endValueLabel
            // 
            this.endValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.endValueLabel.ForeColor = System.Drawing.Color.White;
            this.endValueLabel.Location = new System.Drawing.Point(276, 57);
            this.endValueLabel.Name = "endValueLabel";
            this.endValueLabel.Size = new System.Drawing.Size(100, 15);
            this.endValueLabel.TabIndex = 8;
            this.endValueLabel.Text = "0";
            this.endValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.endValueLabel.Visible = false;
            // 
            // counterRadioButton
            // 
            this.counterRadioButton.AutoSize = true;
            this.counterRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.counterRadioButton.Checked = true;
            this.counterRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.counterRadioButton.Location = new System.Drawing.Point(18, 100);
            this.counterRadioButton.Name = "counterRadioButton";
            this.counterRadioButton.Size = new System.Drawing.Size(68, 19);
            this.counterRadioButton.TabIndex = 9;
            this.counterRadioButton.TabStop = true;
            this.counterRadioButton.Text = "Counter";
            this.counterRadioButton.UseVisualStyleBackColor = false;
            this.counterRadioButton.CheckedChanged += new System.EventHandler(this.counterRadioButton_CheckedChanged);
            // 
            // numberRangeRadioButton
            // 
            this.numberRangeRadioButton.AutoSize = true;
            this.numberRangeRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.numberRangeRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.numberRangeRadioButton.Location = new System.Drawing.Point(18, 125);
            this.numberRangeRadioButton.Name = "numberRangeRadioButton";
            this.numberRangeRadioButton.Size = new System.Drawing.Size(105, 19);
            this.numberRangeRadioButton.TabIndex = 10;
            this.numberRangeRadioButton.Text = "Number Range";
            this.numberRangeRadioButton.UseVisualStyleBackColor = false;
            this.numberRangeRadioButton.CheckedChanged += new System.EventHandler(this.numberRangeRadioButton_CheckedChanged);
            // 
            // dateRangeRadioButton
            // 
            this.dateRangeRadioButton.AutoSize = true;
            this.dateRangeRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.dateRangeRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dateRangeRadioButton.Location = new System.Drawing.Point(18, 150);
            this.dateRangeRadioButton.Name = "dateRangeRadioButton";
            this.dateRangeRadioButton.Size = new System.Drawing.Size(85, 19);
            this.dateRangeRadioButton.TabIndex = 11;
            this.dateRangeRadioButton.Text = "Date Range";
            this.dateRangeRadioButton.UseVisualStyleBackColor = false;
            this.dateRangeRadioButton.CheckedChanged += new System.EventHandler(this.dateRangeRadioButton_CheckedChanged);
            // 
            // counterButton
            // 
            this.counterButton.BackColor = System.Drawing.Color.Transparent;
            this.counterButton.FlatAppearance.BorderSize = 0;
            this.counterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.counterButton.Location = new System.Drawing.Point(138, 57);
            this.counterButton.Name = "counterButton";
            this.counterButton.Size = new System.Drawing.Size(104, 23);
            this.counterButton.TabIndex = 12;
            this.counterButton.Text = "add to counter";
            this.counterButton.UseVisualStyleBackColor = false;
            this.counterButton.Click += new System.EventHandler(this.counterButton_Click);
            // 
            // goalTitleLabel
            // 
            this.goalTitleLabel.AutoSize = true;
            this.goalTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.goalTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalTitleLabel.ForeColor = System.Drawing.Color.White;
            this.goalTitleLabel.Location = new System.Drawing.Point(8, 3);
            this.goalTitleLabel.Name = "goalTitleLabel";
            this.goalTitleLabel.Size = new System.Drawing.Size(69, 32);
            this.goalTitleLabel.TabIndex = 13;
            this.goalTitleLabel.Text = "label";
            this.goalTitleLabel.Visible = false;
            // 
            // startValueNumericUpDown
            // 
            this.startValueNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startValueNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.startValueNumericUpDown.Location = new System.Drawing.Point(8, 57);
            this.startValueNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startValueNumericUpDown.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.startValueNumericUpDown.Name = "startValueNumericUpDown";
            this.startValueNumericUpDown.Size = new System.Drawing.Size(73, 19);
            this.startValueNumericUpDown.TabIndex = 14;
            this.startValueNumericUpDown.ValueChanged += new System.EventHandler(this.startValueNumericUpDown_ValueChanged);
            // 
            // EndValueNumericUpDown
            // 
            this.EndValueNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EndValueNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.EndValueNumericUpDown.Location = new System.Drawing.Point(303, 57);
            this.EndValueNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EndValueNumericUpDown.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.EndValueNumericUpDown.Name = "EndValueNumericUpDown";
            this.EndValueNumericUpDown.Size = new System.Drawing.Size(73, 19);
            this.EndValueNumericUpDown.TabIndex = 15;
            this.EndValueNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndValueNumericUpDown.ValueChanged += new System.EventHandler(this.EndValueNumericUpDown_ValueChanged);
            // 
            // rangeValueNumericUpDown
            // 
            this.rangeValueNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.rangeValueNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.rangeValueNumericUpDown.Location = new System.Drawing.Point(109, 57);
            this.rangeValueNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.rangeValueNumericUpDown.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.rangeValueNumericUpDown.Name = "rangeValueNumericUpDown";
            this.rangeValueNumericUpDown.Size = new System.Drawing.Size(83, 23);
            this.rangeValueNumericUpDown.TabIndex = 16;
            // 
            // setValueButton
            // 
            this.setValueButton.BackColor = System.Drawing.Color.Transparent;
            this.setValueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.setValueButton.Location = new System.Drawing.Point(176, 57);
            this.setValueButton.Name = "setValueButton";
            this.setValueButton.Size = new System.Drawing.Size(75, 23);
            this.setValueButton.TabIndex = 17;
            this.setValueButton.Text = "set value";
            this.setValueButton.UseVisualStyleBackColor = false;
            this.setValueButton.Click += new System.EventHandler(this.setValueButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.startDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.startDateTimePicker.Location = new System.Drawing.Point(8, 57);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(162, 23);
            this.startDateTimePicker.TabIndex = 18;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.endDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.endDateTimePicker.Location = new System.Drawing.Point(214, 57);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(162, 23);
            this.endDateTimePicker.TabIndex = 19;
            // 
            // GoalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(195)))), ((int)(((byte)(145)))));
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.setValueButton);
            this.Controls.Add(this.rangeValueNumericUpDown);
            this.Controls.Add(this.EndValueNumericUpDown);
            this.Controls.Add(this.startValueNumericUpDown);
            this.Controls.Add(this.goalTitleLabel);
            this.Controls.Add(this.counterButton);
            this.Controls.Add(this.dateRangeRadioButton);
            this.Controls.Add(this.numberRangeRadioButton);
            this.Controls.Add(this.counterRadioButton);
            this.Controls.Add(this.endValueLabel);
            this.Controls.Add(this.startValueLabel);
            this.Controls.Add(this.customProgressBar);
            this.Controls.Add(this.goalTitleTextbox);
            this.Controls.Add(this.editButton);
            this.Name = "GoalControl";
            this.Size = new System.Drawing.Size(388, 194);
            this.Click += new System.EventHandler(this.GoalControl_Click);
            this.MouseEnter += new System.EventHandler(this.GoalControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.GoalControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.startValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer controlTimer;
        private TextBox goalTitleTextbox;
        private Button editButton;
        private CustomProgressBar customProgressBar;
        private Label startValueLabel;
        private Label endValueLabel;
        private RadioButton counterRadioButton;
        private RadioButton numberRangeRadioButton;
        private RadioButton dateRangeRadioButton;
        private Button counterButton;
        private Label goalTitleLabel;
        private NumericUpDown startValueNumericUpDown;
        private NumericUpDown EndValueNumericUpDown;
        private NumericUpDown rangeValueNumericUpDown;
        private Button setValueButton;
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;
    }
}
