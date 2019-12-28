using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MessageCreation : Form
    {
        public event EventHandler<MessageModel> OnMessageCreated;

        public MessageCreation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that handles the CreateMessage button click event
        /// </summary>
        private void CreateMessage_Click(object sender, EventArgs e)
        {
            Notify();
            Clear();
            Close();
        }

        /// <summary>
        /// Clear TextBox values
        /// </summary>
        private void Clear()
        {
            messageText.Text = string.Empty;
            nameText.Text = string.Empty;
        }

        /// <summary>
        /// Notifies subscribers and sends the MessageModel results
        /// </summary>
        private void Notify()
        {
            if (ValidateText())
                OnMessageCreated?.Invoke(this, Factory.CreateMessageModel(nameText.Text, messageText.Text));
        }

        /// <summary>
        /// Returns false if both name and message are empty
        /// </summary>
        private bool ValidateText() => !string.IsNullOrWhiteSpace(nameText.Text) &&
                                       !string.IsNullOrWhiteSpace(messageText.Text);
    }
}