using System;
using System.Windows.Forms;
using WinFormUI.Models;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {    
        IMessageHandler Handler { get; } = Factory.CreateMessageHandler();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void launchMessage_Click(object sender, EventArgs e)
        {
            ShowMessageWindow();
            ShowMessageResults();
        }

        private void LaunchSubDashboard_Click(object sender, EventArgs e) => Handler.DisplayDashboardForm();

        private void ShowMessageWindow() => Handler.DisplayMessageForm();

        private void ShowMessageResults() => messageText.Text = Handler.GetMessage();
    }
}