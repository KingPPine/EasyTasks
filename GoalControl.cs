using System.Runtime.InteropServices;

namespace EasyTasks
{
    public partial class GoalControl : UserControl
    {
        private bool editMode;
        private Color standardColour;
        private Color hoverColour;
        private Color editColour;
        private Color desiredColour;
        private float colourChangeSpeed;
        private Size editSize;
        private Size normalSize;
        private Size desiredSize;
        private GoalType goalType;

        public GoalControl()
        {
            InitializeComponent();
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            editMode = true;
            setEditProperties();

            standardColour = Color.IndianRed;
            hoverColour = Color.FromArgb(255, 220, 142, 142);
            editColour = Color.FromArgb(255, 233, 195, 145);
            desiredColour = editColour;
            colourChangeSpeed = 0.6f;

            Size = new Size(0, 0);
            editSize = new Size(388, 194);
            normalSize = new Size(388, 98);
            desiredSize = editSize;

            goalType = GoalType.Counter;

            rangeValueNumericUpDown.Controls.RemoveAt(0); //removes the up and down arrows
        }

        private void setEditProperties()
        {
            if (editMode)
            {
                editButton.BackgroundImage = Properties.Resources.checkmark;
                goalTitleTextbox.ReadOnly = false;
                Cursor = Cursors.Default;
                desiredColour = editColour;
                desiredSize = editSize;
                counterRadioButton.Enabled = true;
                numberRangeRadioButton.Enabled = true;
                dateRangeRadioButton.Enabled = true;
                goalTitleLabel.Visible = false;
                goalTitleTextbox.Visible = true;
                startValueLabel.Visible = false;
                endValueLabel.Visible = false;
                rangeValueNumericUpDown.Visible = false;
                setValueButton.Visible = false;

                counterButton.Visible = false;

                if (goalType == GoalType.Counter)
                {
                    startValueNumericUpDown.Visible = true;
                    EndValueNumericUpDown.Visible = true;
                    startDateTimePicker.Visible = false;
                    endDateTimePicker.Visible = false;
                }
                else if (goalType == GoalType.NumberRange)
                {
                    startValueNumericUpDown.Visible = true;
                    EndValueNumericUpDown.Visible = true;
                    startDateTimePicker.Visible = false;
                    endDateTimePicker.Visible = false;
                }
                else if (goalType == GoalType.DateRange)
                {
                    startValueNumericUpDown.Visible = false;
                    EndValueNumericUpDown.Visible = false;
                    startDateTimePicker.Visible = true;
                    endDateTimePicker.Visible = true;
                }
            }
            else // Not in edit mode
            {
                editButton.BackgroundImage = Properties.Resources.edit;
                goalTitleTextbox.ReadOnly = true;
                Cursor = Cursors.Hand;
                desiredColour = standardColour;
                desiredSize = normalSize;
                counterRadioButton.Enabled = false;
                numberRangeRadioButton.Enabled = false;
                dateRangeRadioButton.Enabled = false;
                goalTitleLabel.Visible = true;
                goalTitleTextbox.Visible = false; 
                startValueNumericUpDown.Visible = false;
                EndValueNumericUpDown.Visible = false;
                startDateTimePicker.Visible = false;
                endDateTimePicker.Visible = false;
                startValueLabel.Visible = true;
                endValueLabel.Visible = true;


                if (goalType == GoalType.Counter)
                {
                    counterButton.Visible = true;
                    rangeValueNumericUpDown.Visible = false;
                    setValueButton.Visible = false;
                }
                else if (goalType == GoalType.NumberRange)
                {
                    counterButton.Visible = false;
                    rangeValueNumericUpDown.Visible = true;
                    setValueButton.Visible = true;
                    setValueButton.BringToFront();
                }
                else if (goalType == GoalType.DateRange)
                {
                    counterButton.Visible = false;
                    rangeValueNumericUpDown.Visible = false;
                    setValueButton.Visible = false;
                    startValueLabel.Text = startDateTimePicker.Text;
                    endValueLabel.Text = endDateTimePicker.Text;
                }
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,  // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        //for loading a goal when the program opens
        public void LoadGoal(string title, GoalType goalType, int startNumericalValue, int endNumericalValue, int customProgressBarValue, DateTime startDate, DateTime endDate)
        {
            goalTitleLabel.Text = title;
            goalTitleTextbox.Text = title;
            customProgressBar.Minimum = startNumericalValue;
            startValueNumericUpDown.Value = startNumericalValue;
            customProgressBar.Maximum = endNumericalValue;
            EndValueNumericUpDown.Value = endNumericalValue;
            customProgressBar.Value = customProgressBarValue;
            startDateTimePicker.Value = startDate;
            endDateTimePicker.Value = endDate;

            if (goalType == GoalType.Counter) counterRadioButton.Checked = true;
            if (goalType == GoalType.NumberRange) numberRangeRadioButton.Checked = true;
            if (goalType == GoalType.DateRange) dateRangeRadioButton.Checked = true;

            editMode = false;
            setEditProperties();
        }

        private int Lerp(int a, int b, float t)
        {
            return (int)(a + (b - a) * t);
        }

        private Color CLerp(Color a, Color b, float t)
        {
            return Color.FromArgb(
                Lerp(a.A, b.A, t),
                Lerp(a.R, b.R, t),
                Lerp(a.G, b.G, t),
                Lerp(a.B, b.B, t)
                );
        }

        private Size SLerp(Size a, Size b, float t)
        {
            return new Size(
                Lerp(a.Width, b.Width, t),
                Lerp(a.Height, b.Height, t)
                );
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if ((editMode && //if it's in edit mode, make sure a goal type was selected, as well as a title given
                (counterRadioButton.Checked || numberRangeRadioButton.Checked || dateRangeRadioButton.Checked)
                && goalTitleTextbox.Text.Length > 0)
                || !editMode)
            {
                //additional logic for edit mode. Not efficient but code can be cleaned up later
                if (editMode)
                {
                    if (goalType == GoalType.DateRange)
                    {
                        startValueLabel.Text = startDateTimePicker.Text;
                        endValueLabel.Text = endDateTimePicker.Text;
                        customProgressBar.Minimum = 0;
                        customProgressBar.Maximum = (int)(endDateTimePicker.Value - startDateTimePicker.Value).TotalDays;
                        customProgressBar.Value = (int)(DateTime.Now - startDateTimePicker.Value).TotalDays;
                    }
                    else
                    {
                        customProgressBar.Minimum = (int)startValueNumericUpDown.Value;
                        customProgressBar.Maximum = (int)EndValueNumericUpDown.Value;
                    }
                }

                editMode = !editMode;
                setEditProperties();
            }
        }

        private void goalTitleTextbox_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(goalTitleTextbox.Text, goalTitleTextbox.Font);
            goalTitleTextbox.Width = size.Width;
            goalTitleTextbox.Height = size.Height;
            goalTitleLabel.Text = goalTitleTextbox.Text;
        }

        private void GoalControl_Click(object sender, EventArgs e)
        {
            if (!editMode && customProgressBar.Value >= customProgressBar.Maximum)
            {
                Parent parentForm = (Parent)ParentForm;
                parentForm.removeGoal(this);
            }
        }

        private void TimerUpdate(object sender, EventArgs e)
        {
            if (BackColor != desiredColour || Size.Height != desiredSize.Height) //to prevent the resizing / redrawing of the region from constantly happening (causes crash)
            {
                float changeSpeed = colourChangeSpeed;

                if (Math.Abs(Size.Height - desiredSize.Height) < 2) // to make sure there are no rounding issues
                    changeSpeed = 1f;

                Color frameColour = CLerp(BackColor, desiredColour, changeSpeed);
                Size = SLerp(Size, desiredSize, changeSpeed);
                //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                BackColor = frameColour;
                goalTitleTextbox.BackColor = frameColour;
                editButton.BackColor = frameColour;
            }

            if (goalType == GoalType.DateRange)
                customProgressBar.Value = (int)(DateTime.Now - startDateTimePicker.Value).TotalDays;
        }

        private void counterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (counterRadioButton.Checked)
            {
                goalType = GoalType.Counter;
                setEditProperties();
            }
        }

        private void numberRangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (numberRangeRadioButton.Checked)
            {
                goalType = GoalType.NumberRange;
                setEditProperties();
            }
        }

        private void dateRangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dateRangeRadioButton.Checked)
            {
                goalType = GoalType.DateRange;
                setEditProperties();
            }
        }

        private void counterButton_Click(object sender, EventArgs e)
        {
            customProgressBar.Value += 1;
        }

        private void startValueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            startValueLabel.Text = startValueNumericUpDown.Value.ToString();
            customProgressBar.Minimum = (int)startValueNumericUpDown.Value;
            if (customProgressBar.Value < (int)startValueNumericUpDown.Value)
            {
                customProgressBar.Value = (int)startValueNumericUpDown.Value;
            }
        }

        private void EndValueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            endValueLabel.Text = EndValueNumericUpDown.Value.ToString();
            customProgressBar.Maximum = (int)EndValueNumericUpDown.Value;
        }

        private void setValueButton_Click(object sender, EventArgs e)
        {
            customProgressBar.Value = (int)rangeValueNumericUpDown.Value;
        }

        private void GoalControl_MouseEnter(object sender, EventArgs e)
        {
            if (editMode)
            {
                desiredColour = editColour;
                Cursor = Cursors.Default;
            }
            else if (customProgressBar.Value >= customProgressBar.Maximum)
            {
                desiredColour = hoverColour;
                Cursor = Cursors.Hand;
            }
        }

        private void GoalControl_MouseLeave(object sender, EventArgs e)
        {
            if (editMode)
            {
                desiredColour = editColour;
            }
            else
            {
                desiredColour = standardColour;
            }
        }

        private void goalTitleTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && editMode)
            {
                editButton_Click(sender, e);
            }
        }

        public string getTitle()
        {
            return goalTitleLabel.Text;
        }
        public GoalType getGoalType()
        {
            return goalType;
        }
        public int getStartNumericalValue()
        {
            return customProgressBar.Minimum;
        }
        public int getEndNumericalValue()
        {
            return customProgressBar.Maximum;
        }
        public int getCustomProgressBarValue()
        {
            return customProgressBar.Value;
        }
        public DateTime getStartDateTime()
        {
            return startDateTimePicker.Value;
        }
        public DateTime getEndDateTime()
        {
            return endDateTimePicker.Value;
        }
    }

    public enum GoalType
    {
        Counter, //A counter from a min value to a max value (button to add +1)
        NumberRange, //A range between a min value to a max value (button to set the value)
        DateRange //A range between a start date and an end date
    }
}
