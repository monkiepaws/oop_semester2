using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApi.Models
{
    public struct PostDataModel
    {
        public string Name;
        public string Email;
        public string Message;
        public PostDataModel(string name, string email, string message)
        {
            this.Name = name;
            this.Email = email;
            this.Message = message;
        }
    }
}
