using System.Runtime.InteropServices;

namespace EasyTasks
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            TaskControl taskControl = new TaskControl();
            taskLayoutPanel.Controls.Add(taskControl);
            expandCollapseButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, expandCollapseButton.Width, expandCollapseButton.Height, 20, 20));
        }

        private void Parent_Load(object sender, EventArgs e)
        {

        }

        private void expandCollapseButton_Click(object sender, EventArgs e)
        {
            if (taskLayoutPanel.Visible)
            {
                taskLayoutPanel.Visible = false;
                goalLayoutPanel.Visible = false;
                addTaskButton.Visible = false;
                addGoalButton.Visible = false;
            }
            else
            {
                taskLayoutPanel.Visible = true;
                goalLayoutPanel.Visible = true;
                addTaskButton.Visible = true;
                addGoalButton.Visible = true;
            }
        }

        public void removeTask(Control taskControl)
        {
            taskLayoutPanel.Controls.Remove(taskControl);
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
    }
}