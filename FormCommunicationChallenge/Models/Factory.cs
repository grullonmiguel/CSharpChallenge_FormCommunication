using WinFormUI.Models;

namespace WinFormUI
{
    public class Factory
    {
        public static MessageCreation CreateMessageForm() => new MessageCreation();

        public static IMessageHandler CreateMessageHandler() => new MessageHandler();

        public static MessageModel CreateMessageModel(string name, string message) => new MessageModel(name, message);

        public static SubDashboard CreateSubDashboardForm() => new SubDashboard();
    }
}