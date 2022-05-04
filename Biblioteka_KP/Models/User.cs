using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_KP.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }

        public User(int id, string login)
        {
            Id = id;
            Login = login;
        }
    }
}
