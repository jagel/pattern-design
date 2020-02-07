using System;
using System.Collections.Generic;
using System.Text;

namespace PatterDesign.Domain.Interfaces
{
    public interface ILogger
    {
        void WriteMeesage(string message);

        void WriteErrorMessage(string message);

        void WriteInfoMessage(string message);

        void WriteByColor(string message, ConsoleColor foregroundColor);

    }
}
