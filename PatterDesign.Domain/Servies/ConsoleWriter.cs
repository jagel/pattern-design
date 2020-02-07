using PatterDesign.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatterDesign.Domain.Servies
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void WriteByColor(string message, ConsoleColor foregroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void WriteErrorMessage(string message)
        {
            message = "[Err] " + message;
            WriteLine(message, ConsoleColor.Red);
        }

        public void WriteInfoMessage(string message)
        {
            message = "[Info] " + message;
            WriteLine(message, ConsoleColor.Blue);
        }

        public void WriteMeesage(string message)
        {
            message = "[Wrn] " + message;
            WriteLine(message, ConsoleColor.Yellow);
        }

        public void WriteLine(string message, ConsoleColor foregroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
