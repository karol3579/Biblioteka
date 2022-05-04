using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_KP.Models
{
    public class UsersRating
    {
        public int book_id;
        int rating;
        string descritption;
        string userLogin;

        public UsersRating(int book_id, int rating, string descritption, string userLogin)
        {
            this.book_id = book_id;
            this.rating = rating;
            this.descritption = descritption;
            this.userLogin = userLogin;
        }

        public string getReview() {
            return $"użytkownik: {userLogin} Ocena: ★ {rating}\n " +
                $"----------------------------------- \n" +
                $"{descritption} \n" +
                $"----------------------------------- \n";
        
        }
    }
}
