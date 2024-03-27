using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    /// <summary>
    /// 
    /// </summary>
    public class IEnumProgram
    {
        public static void iEnumMain()
        {
            Book book0 = new Book("1st");
            Book book1 = new Book("2nd");
            Book book3 = new Book("3d");
            List<Book> books = new List<Book>(){book0, book1, book3};


            BookSelf bookSelf = new BookSelf();
            bookSelf.BookSelfFill(books);


            Console.WriteLine(bookSelf[0].Name);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
                Name = name;
        }

    }
    /// <summary>
    /// 
    /// </summary>
    public class BookSelf : IEnumerable<Book>
    {
        List<Book> books;
        public Book this[int index]
        {
            get { return books[index]; }
        }

        public void BookSelfFill(List<Book> items)
        {
            books = items;


            //foreach (var item in items)
            //{
            //    books.Add(item);
            //};
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return ((IEnumerable<Book>)books).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
