using System.Runtime.InteropServices;

namespace EasyTasks
{
    public partial class Parent : Form
    {
        private bool collapse; //bool to tell elements if they should expand or collapse. false by default.
        private Point addTaskButtonLocation; //the desired position of the add task button when expanded
        private Point addGoalButtonLocation; //the desired position of the add goal button when expanded
        private Point taskPanelLocation; //the desired position of the task panel when expanded
        private Point goalPanelLocation; //the desired position of the goal panel when expanded
        private Size taskPanelSize; //the desired size of the task panel when expanded
        private Size goalPanelSize; //the desired size of the goal panel when expanded
        private Point collapsePos; //the desired position for all content when collapsed
        private Size collapseSize; //the desired size for all content when collapsed
        private float expandCollapseSpeed; //the ratio by which the Lerp happens for expanding and collapsing (must be between 0 and 1)

        public Parent()
        {
            InitializeComponent();

            addTaskButtonLocation = new Point(12, 53);
            addGoalButtonLocation = new Point(Screen.PrimaryScreen.WorkingArea.Right - 49, 53);
            taskPanelSize = new Size(420, Screen.PrimaryScreen.WorkingArea.Height - 89);
            taskPanelLocation = new Point(12, 89);
            goalPanelSize = new Size(420, Screen.PrimaryScreen.WorkingArea.Height - 89);
            goalPanelLocation = new Point(Screen.PrimaryScreen.WorkingArea.Right - goalPanelSize.Width - 12, 89);
            collapsePos = new Point(expandCollapseButton.Location.X + (expandCollapseButton.Width / 2),
                    expandCollapseButton.Location.Y - 100);
            collapseSize = new Size(0, 0);
            expandCollapseSpeed = 0.15f;
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            taskControl taskControl = new taskControl();
            taskLayoutPanel.Controls.Add(taskControl);
            //expandCollapseButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, expandCollapseButton.Width, expandCollapseButton.Height, 20, 20));
        }

        private void addGoalButton_Click(object sender, EventArgs e)
        {
            GoalControl goalControl = new GoalControl();
            goalLayoutPanel.Controls.Add(goalControl);
        }

        private void expandCollapseButton_Click(object sender, EventArgs e)
        {
            if (!collapse)
            {
                collapse = true;
            }
            else
            {
                collapse = false;
            }
        }

        public void removeTask(Control taskControl)
        {
            taskLayoutPanel.Controls.Remove(taskControl);
        }

        public void removeGoal(Control goalControl)
        {
            goalLayoutPanel.Controls.Remove(goalControl);
        }

        public void SaveData()
        {
            //Save the data as a JSON file
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

        private void TimerUpdate(object sender, EventArgs e)
        {
            if (collapse)
            {
                addTaskButton.Location = PLerp(addTaskButton.Location, collapsePos, expandCollapseSpeed);
                addGoalButton.Location = PLerp(addGoalButton.Location, collapsePos, expandCollapseSpeed);
                taskLayoutPanel.Location = PLerp(taskLayoutPanel.Location, collapsePos, expandCollapseSpeed);
                goalLayoutPanel.Location = PLerp(goalLayoutPanel.Location, collapsePos, expandCollapseSpeed);
                taskLayoutPanel.Size = SLerp(taskLayoutPanel.Size, collapseSize, expandCollapseSpeed);
                goalLayoutPanel.Size = SLerp(goalLayoutPanel.Size, collapseSize, expandCollapseSpeed);
            }
            else
            {
                addTaskButton.Location = PLerp(addTaskButton.Location, addTaskButtonLocation, expandCollapseSpeed);
                addGoalButton.Location = PLerp(addGoalButton.Location, addGoalButtonLocation, expandCollapseSpeed);
                taskLayoutPanel.Location = PLerp(taskLayoutPanel.Location, taskPanelLocation, expandCollapseSpeed);
                goalLayoutPanel.Location = PLerp(goalLayoutPanel.Location, goalPanelLocation, expandCollapseSpeed);
                taskLayoutPanel.Size = SLerp(taskLayoutPanel.Size, taskPanelSize, expandCollapseSpeed);
                goalLayoutPanel.Size = SLerp(goalLayoutPanel.Size, goalPanelSize, expandCollapseSpeed);
            }
        }

        private int Lerp(int a, int b, float t)
        {
            return (int)(a + (b - a) * t);
        }

        private Point PLerp(Point a, Point b, float t)
        {
            return new Point(
                Lerp(a.X, b.X, t),
                Lerp(a.Y, b.Y, t)
                );
        }

        private Size SLerp(Size a, Size b, float t)
        {
            return new Size(
                Lerp(a.Width, b.Width, t),
                Lerp(a.Height, b.Height, t)
                );
        }
    }
}