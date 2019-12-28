namespace WinFormUI
{
    public class MessageModel
    {
        public string Name { get; set; }

        public string Message { get; set; }

        public MessageModel(string name, string message)
        {
            Name = name;
            Message = message;
        }
    }
}