using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebAPI.Model;

namespace BasicWebAPI.Data
{
    public class BookData
    {
         public static List<Book> booklist=null;

        public static List<Book> GetBookStore()
        {
            if (booklist == null)
                booklist = new List<Book>() { new Book { name = "CleanCode1", price = 100, pages = 350, author = "NoOne", id = 1 } };
            return booklist;
        }
        public string AddBook(Book book)
        {
            booklist = GetBookStore();
                booklist.Add(book);
            return "Book with ID ="+book.id+" added successfully";
        }
        public List<Book> getlist()
        {
            booklist = GetBookStore();
            return booklist;
        }
        public string getbyid(int id)
        {
            
            foreach (Book book in booklist)
            {
                if (book.id == id) 
                    return book.name+" "+book.price+" "+book.author;
            }
            return "Book Not found";
        }
        public string DeleteBookById(int id)
        {
            
            booklist = GetBookStore();
            foreach (Book b in booklist)
            {

                if (b.id == id)
                {
                    booklist.Remove(b);
                    return "Book with id " + id + " deleted successfully";
                }
            }
            return "Cannot delete as book does not exist";
        }
        public string UpdateBookName(int id,string newname)
        {
            booklist = GetBookStore();
            foreach (Book b in booklist)
            {
                if (b.id == id)
                {
                    b.name = newname;
                    return "Book details updated successfully";
                }
            }
            return "Book ID not found";
        }
    }
}
