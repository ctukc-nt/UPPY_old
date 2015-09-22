using System.Collections.Generic;
using System.Linq;

namespace Utils.Common
{
    public class Logger :  ILogging
    {

        private readonly List<LogMessage> _messages = new List<LogMessage>();

        public bool ErrorHappens
        {
            get { return _messages.Any(x => x.Type == TypeMessage.Error); }
        }
        public IEnumerable<LogMessage> Messages => _messages.AsEnumerable();

        public void AppendMessage(string message)
        {
            _messages.Add(new LogMessage(message));
        }

        public void AppendMessage(string message, TypeMessage typeMessage)
        {
            _messages.Add(new LogMessage(message, typeMessage));
        }

        public void AppendMessage(string message, object obj)
        {
            _messages.Add(new LogMessage(message, obj));
        }

        public void AppendMessage(string message, object obj, TypeMessage typeMessage)
        {
            _messages.Add(new LogMessage(message, obj, typeMessage));
        }

        public void AppendMessage(LogMessage message)
        {
            _messages.Add(message);
        }

        public void Clear()
        {
            _messages.Clear();
        }
    }
}