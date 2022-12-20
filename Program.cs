using System.Resources;
using System.Windows.Forms;
using EasyTasks.Properties;

namespace EasyTasks
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MyCustomApplicationContext());
        }
    }

    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        private Parent parentForm;

        public MyCustomApplicationContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items = 
                    { 
                        new ToolStripMenuItem("Exit", null, Exit)
                    }
                },
                Visible = true
            };

            var taskControl = new TaskControl();
            taskControl.Show();

            parentForm = new Parent();
            parentForm.ShowDialog();
        }

        void Exit(object? sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            parentForm.Close();
            Application.Exit();
        }
    }
}