using System;

namespace Task5
{
    class Body : Text
    {
        protected override ConsoleColor consoleColor { get => ConsoleColor.Yellow; }
        protected override string message { get => "Тело документа отсутствует."; }
    }
}
