namespace WinFormUI.Models
{
    public interface IMessageHandler
    {
        void DisplayDashboardForm();

        void DisplayMessageForm();

        string GetMessage();

        string GetNameAndMessage();
    }
}