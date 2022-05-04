using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_KP.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public Author author { get; set; }

        public string authorData { get; set; }
        public int rating { get; set; }

        public int reviewsCount { get; set; }

        

        public Book(int id, string title, Author author, int rating)
        {
            this.id = id;
            Title = title;
            this.author = author;
            authorData = author.first_name +" "+ author.last_name;
            this.rating = rating;
        }

        public Book(int id, string title, Author author)
        {
            this.id = id;
            Title = title;
            this.author = author;
        }

        public Book(int id, string title, int rating, int reviewsCount)
        {
            this.id = id;
            Title = title;
            this.rating = rating;
            this.reviewsCount = reviewsCount;
        }
    }
}
