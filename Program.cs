using BookStore;

namespace Bookstore.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author("Jorj", "Oruell", DateTime.Now, "Some bio", "Great Britan");
            Book book1 = new Book(author1, Genres.Drama, "1984");
            PublishingHouse publishingHouse1 = new PublishingHouse("GB ph", "Great Britan");
            Edition edition1 = new Edition("lux edition", 567, 1995, book1, publishingHouse1, coverTypesEnum.Hard);
            BookStore.BookStore bookStore1 = new BookStore.BookStore();
            bookStore1.addEdition(edition1, 800);
            ShoppingCart cart1 = new ShoppingCart();
            cart1.addProduct(new Item(edition1, 1));

            void PrintMessage(string message) { Console.WriteLine(message); }

            cart1.AddProductEvent += PrintHello;
            cart1.addProduct(new Item(edition1, 1));

            void PrintHello(string message) { Console.WriteLine(message + "\n Successfull"); };
        }
    }
}