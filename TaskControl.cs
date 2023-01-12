using System.Runtime.InteropServices;

namespace EasyTasks
{
    public partial class TaskControl : UserControl
    {
        private bool editMode;
        private Color standardColour;
        private Color hoverColour;
        private Color editColour;
        private Color desiredColour;
        private float colourChangeSpeed;
        private Size desiredSize;

        public TaskControl()
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
            desiredSize = new Size(388, 98);
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

        //for loading a task when the program opens
        public void LoadTask(string title)
        {
            taskTitleLabel.Text = title;
            taskTitleTextbox.Text = title;
            editMode= false;
            setEditProperties();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!editMode || taskTitleTextbox.Text.Length > 0)
            {
                editMode = !editMode;
                setEditProperties();

                if (!editMode)
                {
                    Parent parentForm = (Parent)ParentForm;
                    parentForm.SaveDataToJson();
                }
            }
        }

        private void taskTitleTextbox_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(taskTitleTextbox.Text, taskTitleTextbox.Font);
            taskTitleTextbox.Width = size.Width;
            taskTitleTextbox.Height = size.Height;
            taskTitleLabel.Text = taskTitleTextbox.Text;
        }

        private void taskControl_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                Parent parentForm = (Parent)ParentForm;
                parentForm.removeTask(this);
            }
        }

        private void setEditProperties()
        {
            if (editMode)
            {
                editButton.BackgroundImage = Properties.Resources.checkmark;
                taskTitleTextbox.ReadOnly = false;
                Cursor = Cursors.Default;
                desiredColour = editColour;
                taskTitleTextbox.Visible = true;
                taskTitleLabel.Visible = false;
            }
            else
            {
                editButton.BackgroundImage = Properties.Resources.edit;
                taskTitleTextbox.ReadOnly = true;
                Cursor = Cursors.Hand;
                desiredColour = standardColour;
                taskTitleTextbox.Visible = false;
                taskTitleLabel.Visible = true;
            }
        }

        private void TimerUpdate(object sender, EventArgs e)
        {
            Color frameColour = CLerp(BackColor, desiredColour, colourChangeSpeed);
            Size = SLerp(Size, desiredSize, colourChangeSpeed);
            BackColor = frameColour;
            taskTitleTextbox.BackColor = frameColour;
            editButton.BackColor = frameColour;
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

        private void taskControl_MouseEnter(object sender, EventArgs e)
        {
            if (editMode)
            {
                desiredColour = editColour;
            }
            else
            {
                desiredColour = hoverColour;
            }
        }

        private void taskControl_MouseLeave(object sender, EventArgs e)
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

        private void taskTitleTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && editMode)
            {
                editButton_Click(sender, e);
            }
        }

        public string getTitle()
        {
            return taskTitleLabel.Text;
        }
    }
}
