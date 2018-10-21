using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppUILibrary
{
    public interface IMenu
    {
        string Title();
        string Instruction();
        void Play();
    }
}
