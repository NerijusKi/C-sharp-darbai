using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Biblioteka
{
    public class Library : ILendable
    {
        public Library(Address address)
        {





            Address = address;
            Books = new List<Book>();
            Magazines = new List<Magazine>();

        }


        public Address Address { get; set; }
        public List<Book> Books { get; set; }
        public List<Magazine> Magazines { get; set; }



        public void AddBook(Book book)
        {
            bool bookExists = false;
            foreach (var item in Books)
            {
                if (book.GetIsbn() == book.GetIsbn())
                {
                    bookExists = true;
                }
            }
            if (!bookExists)
            {
                Books.Add(book);
            }
        }

        public void ShowAvailableBookList()
        {
            var availableBooks = Books.Where(x => x.IsAvailable).ToList(); //tas pats, kas zemiau, tik viena eilute
            //foreach (var item in Books)
            //{
            //    if (item.IsAvailable)
            //    {
            //        Console.WriteLine(item.Title);
            //    }
            //}
        }

        public IEnumerable<Book> GetAvailableBooks()
        {
            return Books.Where(x => x.IsAvailable);
        }

        public Book LendBook(Book book)
        {

            return Books.Where(b => b.GetIsbn() == book.GetIsbn()).Where(x=>x.IsAvailable).First();
            //foreach (var item in Books)
            //{
            //    if (item.GetIsbn() == book.GetIsbn() && item.IsAvailable)
            //    {
            //        return item;
            //    }
            //}
            //return null;
        }
        public bool DoesBookExist(string isbn)
        {
            return Books.Any(b => b.GetIsbn() == isbn);
        }


        public Magazine LendMagazine(Magazine magazine)
        {
            foreach (var item in Magazines)
            {
                if ((item.GetIsbn() == magazine.GetIsbn() && item.IsAvailable))
                {
                    return item;
                }
            }
            return null; //magazine not found or not available
        }
    }
}
