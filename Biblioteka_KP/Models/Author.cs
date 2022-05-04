using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_KP.Models
{
    public class Author
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public Author(int id, string first_name, string last_name)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
        }
    }
}
