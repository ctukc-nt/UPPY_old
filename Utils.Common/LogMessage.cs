namespace Utils.Common
{
    public class LogMessage
    {
        public TypeMessage Type { get; set; }

        public string Message { get; set; }

        public object Tag { get; set; }

        public LogMessage()
        {
            Type = TypeMessage.Information;
            Tag = null;
            Message = string.Empty;
        }

        public LogMessage(string message):this()
        {
            Message = message;
        }

        public LogMessage(string message, TypeMessage type) : this()
        {
            Message = message;
            Type = type;
        }

        public LogMessage(string message, object tag) : this()
        {
            Message = message;
            Tag = tag;
        }

        public LogMessage(string message, object tag, TypeMessage type ) : this()
        {
            Message = message;
            Type = type;
            Tag = tag;
        }

        public LogMessage(object tag) : this()
        {
            Tag = tag;
        }

        public LogMessage(object tag, TypeMessage type) : this()
        {
            Type = type;
            Tag = tag;
        }

    }
}