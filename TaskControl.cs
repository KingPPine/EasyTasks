using System.Runtime.InteropServices;

namespace EasyTasks
{
    public partial class TaskControl : UserControl
    {
        private Point previousLocation;

        public TaskControl()
        {
            previousLocation = Location;
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void TaskControl_Move(object sender, EventArgs e)
        {
            //This does not work, I will likely have to crate a custom FlowLayoutPanel that lerps the positions
            /*
            Point goalPosition = Location;

            //lerp from previous position to new one
            int xPos = (int)(previousLocation.X * 0.5f + goalPosition.X * 0.5f);
            int yPos = (int)(previousLocation.Y * 0.5f + goalPosition.Y * 0.5f);

            Location = new Point(xPos, yPos);
            previousLocation = Location;
            */
        }

        private void TaskControl_Click(object sender, EventArgs e)
        {
            Parent parentForm = (Parent)ParentForm;
            parentForm.removeTask(this);
        }
    }
}
