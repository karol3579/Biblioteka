using Biblioteka_KP.Interfaces;
using Biblioteka_KP.Models;
using Biblioteka_KP.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_KP
{

    
    public partial class MainForm : Form, IDataManager
    {
      
        NewBookForm newBookForm;
        NewAuthorForm newAuthorForm;
        SqlConnector sql;
        User user; // user na którego jesteśmy zalogowani 
        List<UsersRating> usersRatings; // główna lista z recenzjami 
        List<Book> books; // główna lista z książkami 
        BindingSource bindingSourceBooks;

        public MainForm(User user)
        {
            InitializeComponent();

            this.user = user;
            sql = new SqlConnector();
            
           
            usersRatings = loadBookRating();
            loadData();

            buttonAddBook.Click += (s,e) => {
              if (newBookForm == null)
              {
                  newBookForm = new NewBookForm();
                  newBookForm.Show();
                  
                  newBookForm.GetAddButton().Click += (s, e) => {
                      Book b = newBookForm.GetBook();
                      if (b != null) bindingSourceBooks.Add(b); //po kliknięciu 'dodaj' pobieramy obiekt książki i dodajemy go do grida (tak by nie ładować bez sesnu wszystkich ksiazek z sqla)
                      newBookForm.Close();
                      newBookForm = null; // czyszczenie obiektu po zamknięciu

                  };

                
              }
          };

            // otwiera form z dodaniem autora
            buttonAddAuthor.Click += (s, e) => {
                if (newAuthorForm == null)
                {
                    newAuthorForm = new NewAuthorForm();
                    newAuthorForm.Show();

                    newAuthorForm.FormClosed += (s, e) => { newAuthorForm = null; }; // czyszczenie obiektu po zamknięciu
                }
            };

            // wczytanie recenzji po kliknięciu w rząd z książką
            dataGridViewCatalog.SelectionChanged += (s,e) => {
                refreshReviews();
            };

            buttonAddReview.Click += (s,e) => {
                // tworzy nowy form, jako parametry wrzucana jest obecnie zaznaczona książka oraz user na którego jesteśmy zalogowani
                NewReviewForm reviewForm = new NewReviewForm(books.Find( b => b.id == int.Parse(dataGridViewCatalog.SelectedRows[0].Cells[0].Value.ToString())), user);
                reviewForm.Show();

                reviewForm.FormClosing += (s,e ) => {
                    UsersRating usersRating = reviewForm.getReview();
                    if (usersRating != null)
                    {
                        usersRatings.Add(reviewForm.getReview());
                        refreshReviews();
                    }
                };
               

            };

            textBoxSearch.TextChanged += (s, e) => {
                dataGridViewCatalog.DataSource = filteredBooks(books, textBoxSearch.Text);
            };

            checkBoxSortType.CheckStateChanged += (s, e) => {
                if (checkBoxSortType.CheckState == CheckState.Checked)
                     books = books.OrderByDescending(b => b.reviewsCount).ToList();
                else 
                    books = books.OrderBy(b => b.id).ToList();
                

                bindingSourceBooks.DataSource = books;

                
            };
            

        }


        private List<Book> filteredBooks(List<Book> lista,string text) {
            return lista.Where(l => l.Title.ToLower().Contains(text.ToLower()) || (l.author.first_name+" "+ l.author.last_name).ToLower().Contains(text.ToLower())).ToList();
        }

        public void loadData()
        {
            string select = $"select b.id as bookid," +
                $" b.title," +
                $" a.id as author_id," +
                $" a.first_name," +
                $" a.last_name," +
                $" ifnull(br.value, 0) as rating, " +
                $" br.description " +
                    $"from book b " +

                $"left join author a on b.author_id=a.id " +
                $"left join book_rating br on b.id=br.book_id " +
                $"where user_id={user.Id} or value is null order by b.id;";
                

            books = new List<Book>();

            MySql.Data.MySqlClient.MySqlDataReader reader = sql.sendQuery(select);

            while (reader.Read())
            {
                Author autor = new Author(int.Parse(reader["author_id"].ToString()), reader["first_name"].ToString(), reader["last_name"].ToString());
                Book book = new Book(int.Parse(reader["bookid"].ToString()), reader["title"].ToString(), autor, int.Parse(reader["rating"].ToString()));
                book.reviewsCount = countReviews(book, usersRatings);
                books.Add(book);
            }
            reader.Close();

            bindingSourceBooks = new BindingSource { DataSource = books };
            // ustawianie danych dla głównego grida z danymi 
            dataGridViewCatalog.DataSource = bindingSourceBooks;
            dataGridViewCatalog.Columns[0].HeaderText = "Id";
            dataGridViewCatalog.Columns[1].HeaderText = "Tytuł";
            dataGridViewCatalog.Columns[2].Visible = false;
            dataGridViewCatalog.Columns[3].HeaderText = "Autor";
            dataGridViewCatalog.Columns[4].HeaderText = "Moja ocena";
            dataGridViewCatalog.Columns[5].HeaderText = "Ilość ocena";


        }

        //funkcja zwracająca listę recenzji  książek z bazy danych. 
        private List<UsersRating> loadBookRating() {
           
            List<UsersRating> usrRating = new List<UsersRating>();
            MySql.Data.MySqlClient.MySqlDataReader reader = sql.sendQuery($"select book_id, value, description, u.login from book_rating br left join user u on user_id=u.id;");

            while (reader.Read()) {
                usrRating.Add(new UsersRating(int.Parse(reader["book_id"].ToString()), int.Parse(reader["value"].ToString()),
                    reader["description"].ToString(), reader["login"].ToString()));
            }
            reader.Close();

            return usrRating;
        }

        // funkcja tworząca widok recenzji
        private void displayRating(List<UsersRating> usersRatings, int selected_index){

            if (selected_index != null && usersRatings!= null)
            {
                listBoxDescription.Items.Clear();
                List<string> rating = usersRatings.Where(u => u.book_id == selected_index).Select(u => u.getReview()).ToList();
                foreach (var r in rating)
                {
                    foreach (string s in Regex.Split(r, "\n"))
                        listBoxDescription.Items.Add(s);
                }
            }
        }

        private void refreshReviews() {
            if (dataGridViewCatalog.SelectedRows.Count != 0) // jeśli któryś z rzędów jest zaznaczony 
            {
                displayRating(usersRatings, int.Parse(dataGridViewCatalog.SelectedRows[0].Cells[0].Value.ToString()));
                buttonAddReview.Visible = true;
            }
            else buttonAddReview.Visible = false;
        }

        public void refreshData()
        {
            throw new NotImplementedException();
        }

        private int countReviews(Book book, List<UsersRating> ratings) {
            
                int quantity;
                var tmp = ratings.Where(u => u.book_id == book.id);
                if (tmp == null) quantity = 0;
                else quantity = tmp.Count();

                return quantity;

        }
        
    }
}
