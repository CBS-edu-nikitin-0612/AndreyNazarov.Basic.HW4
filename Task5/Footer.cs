using System;

namespace Task5
{
    class Footer : Text
    {
        protected override ConsoleColor consoleColor { get => ConsoleColor.Green; }
        protected override string message { get => "Нижний колонтитул отсутствует."; }
    }
}
