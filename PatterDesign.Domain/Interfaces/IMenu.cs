using System;
using System.Collections.Generic;
using System.Text;

namespace PatterDesign.Domain.Interfaces
{
    public interface IMenu
    {
        void Display();

        string ReadOption();
    }
 
}
