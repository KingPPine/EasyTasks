using System.Runtime.InteropServices;
using System.Text.Json;

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

            LoadDataFromJson();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            TaskControl taskControl = new TaskControl();
            taskLayoutPanel.Controls.Add(taskControl);
        }

        private void LoadTask(string title)
        {
            TaskControl taskControl = new TaskControl();
            taskControl.LoadTask(title);
            taskLayoutPanel.Controls.Add(taskControl);
        }

        private void LoadGoal(string title, GoalType goalType, int startNumericalValue, int endNumericalValue, int customProgressBarValue, DateTime startDate, DateTime endDate)
        {
            GoalControl goalControl = new GoalControl();
            goalControl.LoadGoal(title, goalType, startNumericalValue, endNumericalValue, customProgressBarValue, startDate, endDate);
            goalLayoutPanel.Controls.Add(goalControl);
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
            SaveDataToJson();
        }

        public void removeGoal(Control goalControl)
        {
            goalLayoutPanel.Controls.Remove(goalControl);
            SaveDataToJson();
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

        public void SaveDataToJson()
        {
            
            TaskSaveData[] taskSaveData = new TaskSaveData[taskLayoutPanel.Controls.Count];
            GoalSaveData[] goalSaveData = new GoalSaveData[goalLayoutPanel.Controls.Count];
            SaveData saveData = new SaveData();

            int i = 0;
            foreach(TaskControl control in taskLayoutPanel.Controls)
            {
                taskSaveData[i] = new TaskSaveData();
                taskSaveData[i].title = control.getTitle();
                i++;
            }

            i = 0;
            foreach (GoalControl control in goalLayoutPanel.Controls)
            {
                goalSaveData[i] = new GoalSaveData();
                goalSaveData[i].title = control.getTitle();
                goalSaveData[i].goalType = control.getGoalType();
                goalSaveData[i].startNumericalValue = control.getStartNumericalValue();
                goalSaveData[i].endNumericalValue = control.getEndNumericalValue();
                goalSaveData[i].customProgressBarValue = control.getCustomProgressBarValue();
                goalSaveData[i].startDate = control.getStartDateTime();
                goalSaveData[i].endDate = control.getEndDateTime();
                i++;
            }

            saveData.tasks = taskSaveData;
            saveData.goals = goalSaveData;

            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EasyTasksSaveData.json");
            string jsonString = JsonSerializer.Serialize(saveData);
            File.WriteAllText(fileName, jsonString );
        }

        public void LoadDataFromJson()
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EasyTasksSaveData.json");
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                SaveData saveData = JsonSerializer.Deserialize<SaveData>(jsonString);

                if (saveData != null || saveData.tasks.Length > 0)
                {
                    foreach (TaskSaveData task in saveData.tasks)
                    {
                        LoadTask(task.title);
                    }
                    foreach(GoalSaveData goal in saveData.goals)
                    {
                        LoadGoal(goal.title, goal.goalType, goal.startNumericalValue, goal.endNumericalValue , goal.customProgressBarValue, goal.startDate, goal.endDate);
                    }
                }
            }
        }
    }
}