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
        private Size desiredSize;

        public GoalControl()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void setEditProperties()
        {
            if (editMode)
            {
                editButton.BackgroundImage = Properties.Resources.checkmark;
                goalTitleTextbox.ReadOnly = false;
                Cursor = Cursors.Default;
                desiredColour = editColour;
            }
            else
            {
                editButton.BackgroundImage = Properties.Resources.edit;
                goalTitleTextbox.ReadOnly = true;
                Cursor = Cursors.Hand;
                desiredColour = standardColour;
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
            editMode = !editMode;
            setEditProperties();
        }

        private void goalTitleTextbox_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(goalTitleTextbox.Text, goalTitleTextbox.Font);
            goalTitleTextbox.Width = size.Width;
            goalTitleTextbox.Height = size.Height;
        }

        private void GoalControl_Click(object sender, EventArgs e)
        {
            //normall this would complete the goal, but I don't think I want this behaviour
        }

        private void TimerUpdate(object sender, EventArgs e)
        {
            Color frameColour = CLerp(BackColor, desiredColour, colourChangeSpeed);
            Size = SLerp(Size, desiredSize, colourChangeSpeed);
            BackColor = frameColour;
            goalTitleTextbox.BackColor = frameColour;
            editButton.BackColor = frameColour;
        }
    }
}
