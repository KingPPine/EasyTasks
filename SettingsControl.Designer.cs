namespace EasyTasks
{
    partial class SettingsControl
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
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            connectButton = new Button();
            registerButton = new Button();
            registerPasswordTextbox = new TextBox();
            registerUsernameTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            topLeftCornerImage = new PictureBox();
            changePassCurrentPassword = new TextBox();
            changePassUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            changePassNewPassword = new TextBox();
            label5 = new Label();
            changePassButton = new Button();
            ((System.ComponentModel.ISupportInitialize)topLeftCornerImage).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = Color.FromArgb(10, 10, 10);
            usernameLabel.Location = new Point(24, 50);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(65, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "username: ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.FromArgb(10, 10, 10);
            passwordLabel.Location = new Point(24, 74);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "password:";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(95, 47);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(155, 23);
            usernameTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(95, 71);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(155, 23);
            passwordTextbox.TabIndex = 3;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(256, 71);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(114, 23);
            connectButton.TabIndex = 4;
            connectButton.Text = "connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(256, 183);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(114, 23);
            registerButton.TabIndex = 9;
            registerButton.Text = "register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // registerPasswordTextbox
            // 
            registerPasswordTextbox.Location = new Point(95, 183);
            registerPasswordTextbox.Name = "registerPasswordTextbox";
            registerPasswordTextbox.PasswordChar = '*';
            registerPasswordTextbox.Size = new Size(155, 23);
            registerPasswordTextbox.TabIndex = 8;
            // 
            // registerUsernameTextbox
            // 
            registerUsernameTextbox.Location = new Point(95, 159);
            registerUsernameTextbox.Name = "registerUsernameTextbox";
            registerUsernameTextbox.Size = new Size(155, 23);
            registerUsernameTextbox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(10, 10, 10);
            label1.Location = new Point(24, 186);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(10, 10, 10);
            label2.Location = new Point(24, 162);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "username: ";
            // 
            // topLeftCornerImage
            // 
            topLeftCornerImage.BackColor = Color.Transparent;
            topLeftCornerImage.Image = Properties.Resources.pixel_corner;
            topLeftCornerImage.Location = new Point(0, 0);
            topLeftCornerImage.Name = "topLeftCornerImage";
            topLeftCornerImage.Size = new Size(3, 3);
            topLeftCornerImage.TabIndex = 25;
            topLeftCornerImage.TabStop = false;
            // 
            // changePassCurrentPassword
            // 
            changePassCurrentPassword.Location = new Point(95, 291);
            changePassCurrentPassword.Name = "changePassCurrentPassword";
            changePassCurrentPassword.PasswordChar = '*';
            changePassCurrentPassword.Size = new Size(155, 23);
            changePassCurrentPassword.TabIndex = 29;
            // 
            // changePassUsername
            // 
            changePassUsername.Location = new Point(95, 267);
            changePassUsername.Name = "changePassUsername";
            changePassUsername.Size = new Size(155, 23);
            changePassUsername.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(10, 10, 10);
            label3.Location = new Point(24, 285);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 27;
            label3.Text = "current \r\npassword:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(10, 10, 10);
            label4.Location = new Point(24, 270);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 26;
            label4.Text = "username: ";
            // 
            // changePassNewPassword
            // 
            changePassNewPassword.Location = new Point(95, 316);
            changePassNewPassword.Name = "changePassNewPassword";
            changePassNewPassword.PasswordChar = '*';
            changePassNewPassword.Size = new Size(155, 23);
            changePassNewPassword.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(10, 10, 10);
            label5.ImageAlign = ContentAlignment.TopLeft;
            label5.Location = new Point(24, 319);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 31;
            label5.Text = "new password:";
            // 
            // changePassButton
            // 
            changePassButton.Location = new Point(256, 315);
            changePassButton.Name = "changePassButton";
            changePassButton.Size = new Size(114, 23);
            changePassButton.TabIndex = 33;
            changePassButton.Text = "change password";
            changePassButton.UseVisualStyleBackColor = true;
            changePassButton.Click += changePassButton_Click;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            Controls.Add(changePassButton);
            Controls.Add(changePassNewPassword);
            Controls.Add(label5);
            Controls.Add(changePassCurrentPassword);
            Controls.Add(changePassUsername);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(topLeftCornerImage);
            Controls.Add(registerButton);
            Controls.Add(registerPasswordTextbox);
            Controls.Add(registerUsernameTextbox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(connectButton);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "SettingsControl";
            Size = new Size(596, 438);
            ((System.ComponentModel.ISupportInitialize)topLeftCornerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button connectButton;
        private Button registerButton;
        private TextBox registerPasswordTextbox;
        private TextBox registerUsernameTextbox;
        private Label label1;
        private Label label2;
        private PictureBox topLeftCornerImage;
        private TextBox changePassCurrentPassword;
        private TextBox changePassUsername;
        private Label label3;
        private Label label4;
        private TextBox changePassNewPassword;
        private Label label5;
        private Button changePassButton;
    }
}
