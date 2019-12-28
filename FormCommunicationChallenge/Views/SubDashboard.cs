using System.Windows.Forms;
using WinFormUI.Models;

namespace WinFormUI
{
    public partial class SubDashboard : Form
    {
        IMessageHandler Handler { get; } = Factory.CreateMessageHandler();

        public SubDashboard()
        {
            InitializeComponent();
        }

        private void LaunchMessage_Click(object sender, System.EventArgs e)
        {
            ShowMessageWindow();
            ShowMessageResults();
        }

        private void ShowMessageWindow() => Handler.DisplayMessageForm();

        private void ShowMessageResults() => nameAndMessageText.Text = Handler.GetNameAndMessage();
    }
}