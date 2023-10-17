using Bookstore.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public enum coverTypesEnum
    {
        Soft,
        Hard
    }
    class Edition : IProduct
    {
        public Book Book { get; set; }

        public PublishingHouse PublishingHouse { get; set; }

        public coverTypesEnum TypeOfCover { get; set; }

        public String Name
        {
            get
            {
                return Book.Name + Name;
            }
            set { Book.Name = value; }

        }

        public int PagesCount
        {
            get
            {
                return PagesCount;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Кількість сторінок має бути більшою за 0");
                else PagesCount = value;
            }
        }

        public int YearOfPublishing
        {
            get
            {
                return YearOfPublishing;
            }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Рік видання не може бути < 0");
                else YearOfPublishing = value;
            }
        }

        public int Price { get; set; }

        public Edition(String name, int pagesCount, int yearOfPublishing, Book book,
                        PublishingHouse publishingHouse, coverTypesEnum typeOfCover)
        {
            this.Name = name;
            this.PagesCount = pagesCount;
            this.YearOfPublishing = yearOfPublishing;
            this.Book = book;
            this.PublishingHouse = publishingHouse;
            this.TypeOfCover = typeOfCover;
        }
    }
}