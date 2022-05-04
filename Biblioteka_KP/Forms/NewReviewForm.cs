using Biblioteka_KP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_KP.Forms
{
    public partial class NewReviewForm : Form
    {
        UsersRating rating;
        SQL.SqlConnector sql;
        public NewReviewForm(Book book, User user)
        {
            sql = new SQL.SqlConnector();

            InitializeComponent();
            buttonAddReview.Click += (s, e) => {
                int value = int.Parse(comboBoxValue.SelectedItem.ToString());
                rating = new UsersRating(book.id, value, textBoxDescription.Text, user.Login);
                sql.sendQuery($"insert into book_rating(book_id, user_id, value, description) values ({book.id}, {user.Id}, {value}, '{textBoxDescription.Text}');").Close();
                book.reviewsCount++;
                Close();
            };
        }

        public UsersRating getReview() {
            return rating;
            
        }



        
    }
}
