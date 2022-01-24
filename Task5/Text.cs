using System;

namespace Task5
{
    internal abstract class Text
    {
        protected abstract ConsoleColor consoleColor { get; }
        protected string content;
        protected abstract string message { get; }
        public virtual string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return message;
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
