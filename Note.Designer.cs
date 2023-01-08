namespace EasyTasks
{
    partial class Note
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
            this.noteTitleTextbox = new System.Windows.Forms.TextBox();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // noteTitleTextbox
            // 
            this.noteTitleTextbox.BackColor = System.Drawing.Color.IndianRed;
            this.noteTitleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTitleTextbox.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.noteTitleTextbox.ForeColor = System.Drawing.Color.White;
            this.noteTitleTextbox.Location = new System.Drawing.Point(8, 3);
            this.noteTitleTextbox.MaximumSize = new System.Drawing.Size(343, 32);
            this.noteTitleTextbox.MinimumSize = new System.Drawing.Size(113, 32);
            this.noteTitleTextbox.Name = "noteTitleTextbox";
            this.noteTitleTextbox.PlaceholderText = "Note Title";
            this.noteTitleTextbox.Size = new System.Drawing.Size(113, 32);
            this.noteTitleTextbox.TabIndex = 6;
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.AcceptsTab = true;
            this.noteRichTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.noteRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.noteRichTextBox.Location = new System.Drawing.Point(8, 41);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(455, 353);
            this.noteRichTextBox.TabIndex = 7;
            this.noteRichTextBox.Text = "";
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.noteRichTextBox);
            this.Controls.Add(this.noteTitleTextbox);
            this.Name = "Note";
            this.Size = new System.Drawing.Size(474, 421);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox noteTitleTextbox;
        private RichTextBox noteRichTextBox;
    }
}
