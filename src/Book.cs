using Bookstore.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public enum Genres
    {
        Drama, 
        Fantasy, 
        FairyTale, 
        TravelBooks,
        Autobiography,
        History,
        Thriller,
        Mystery,
        Romance,
        Horror,
        Business
    }

    class Book
    {
        public Genres Genre { get; set; }
        public String Name { get; set; }

        public Author Author { get; set; }

        public Book(Author author, Genres genre, String name)
        {
            Author = author;
            Genre = genre;
            Name = name;
        }
    }
}
