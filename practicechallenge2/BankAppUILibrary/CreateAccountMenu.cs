using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppUILibrary
{
    public class CreateAccountMenu : IMenu
    {
        public string Title()
        {
            return "Create new account";
        }

        public string Instruction()
        {
            return "Creates new accounts and initial balances";
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
