namespace WinFormUI.Models
{
    public class MessageHandler : IMessageHandler
    {
        private MessageModel MessageModel { get; set; }
        
        public void DisplayDashboardForm()
        {
            // Get dashboard form instance
            var form = Factory.CreateSubDashboardForm();

            // Display form on the screen
            form.ShowDialog();
        }

        public void DisplayMessageForm()
        {
            // Get message form instance
            var form = Factory.CreateMessageForm();

            // Subscribe to message created event
            form.OnMessageCreated += HandleMessageCreated;

            // Display form on the screen
            form.ShowDialog();

            // UnSubscribe from event
            form.OnMessageCreated -= HandleMessageCreated;
        }

        public string GetMessage() => MessageModel.Message;

        public string GetNameAndMessage()
        {
            if (MessageModel == null)
                return null;

            return $"{MessageModel.Name} {MessageModel.Message}";
        }

        private void HandleMessageCreated(object sender, MessageModel e) => MessageModel = e;
    }
}