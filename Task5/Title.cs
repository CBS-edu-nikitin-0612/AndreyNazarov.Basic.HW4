using System;

namespace Task5
{
    class Title : Text
    {
        protected override ConsoleColor consoleColor { get => ConsoleColor.Red; }
        protected override string message { get => "Заголовок отсутствует."; }
    }
}
