using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using EasyTasks.HTTP_Content_Objects;
using Microsoft.VisualBasic.Devices;

namespace EasyTasks
{
    public partial class SettingsControl : UserControl
    {
        private HttpClient httpClient;

        public SettingsControl()
        {
            InitializeComponent();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            var parentForm = (Parent)ParentForm;
            var result = parentForm.Authenticate(usernameTextbox.Text, passwordTextbox.Text);
            await result;
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            var parentForm = (Parent)ParentForm;
            parentForm.Register(registerUsernameTextbox.Text, registerPasswordTextbox.Text);
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            var parentForm = (Parent)ParentForm;
            parentForm.ChangePassword(changePassUsername.Text, changePassCurrentPassword.Text, changePassNewPassword.Text);
        }
    }
}
