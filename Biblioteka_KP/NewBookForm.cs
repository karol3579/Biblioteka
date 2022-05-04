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

namespace Biblioteka_KP
{
    public partial class NewBookForm : Form
    {

        SQL.SqlConnector sql;
        List<Author> authors;
        Book book;

        public NewBookForm()
        {
            InitializeComponent();
            sql = new SQL.SqlConnector();
            loadAuthors();
            addBook();
        }


        private void addBook() {
            buttonCreateNewBook.Click += (s, e) => {
                if (comboBoxAuthors.SelectedIndex != -1)
                {
                    sql.sendQuery($"insert into book(title, author_id) values ('{textBookTitle.Text}', '{authors[comboBoxAuthors.SelectedIndex].id}');").Close();
                    book = new Book((int)sql.getSqlCommand().LastInsertedId, textBookTitle.Text, authors[comboBoxAuthors.SelectedIndex]);
                    Close();
                }
                else {
                    labelWrongAuthor.Visible = true;
                }
            };
            
        }

        private void loadAuthors() {
            MySql.Data.MySqlClient.MySqlDataReader reader;
            authors = new List<Author>();
            reader = sql.sendQuery($"select * from Author");
            while (reader.Read()) {
                Author author = new Author(int.Parse(reader["id"].ToString()), reader["first_name"].ToString(), reader["last_name"].ToString());
                authors.Add(author);
                comboBoxAuthors.Items.Add(author.first_name + " " + author.last_name);
            }
            reader.Close();
           
        }

        public Book GetBook() {
            return book;
            
        }

        public Button GetAddButton() {
            return buttonCreateNewBook;
        }

       
    }
}
