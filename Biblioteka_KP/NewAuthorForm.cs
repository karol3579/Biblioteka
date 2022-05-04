using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_KP
{
    public partial class NewAuthorForm : Form
    {
        SQL.SqlConnector sql; 
        public NewAuthorForm()
        {
            InitializeComponent();
            addAuthor();
        }

        private void addAuthor() {
            sql = new SQL.SqlConnector();
            buttonAddAuthor.Click += (s, e) => {
                if (textBoxFirstName.Text == "" && textBoxLastName.Text == "") labelErrorAuthor.Text = "Uzupełnij dane!";
                else if (textBoxFirstName.Text == "") labelErrorAuthor.Text = "Wskaż imię!";
                else if (textBoxLastName.Text == "") labelErrorAuthor.Text = "Wskaż nazwisko!";
                else
                {
                    sql.sendQuery($"insert into author(first_name, last_name) values('{textBoxFirstName.Text}', '{textBoxLastName.Text}');").Close();
                    Close();
                }
            };
        
        }
    }
}
