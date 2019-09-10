using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebAPI.Data;
using BasicWebAPI.Exceptions;
using BasicWebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace BasicWebAPI.Service
{
    
    public class BookService : IService
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        BookData bookdata;
        public BookService()
        {
            bookdata = new BookData();
        }
        public string AddNewBook( Book book)
        {
            logger.Info("Inside AddNewBook method");

            if (book.id < 0)
            {
                logger.Error(new InvalidIdException());
                return new InvalidIdException().Message;
            }
            if (book.price < 50)
            {
                logger.Error(new InvalidPriceException());
                return new InvalidPriceException().Message;
            }
            if (!book.name.All(Char.IsLetter))
            {
                logger.Error(new InvalidBookNameException());
                return new InvalidBookNameException().Message;
            }
            if (!book.author.All(Char.IsLetter))
            {
                logger.Error(new InvalidAuthorNameException());
                return new InvalidAuthorNameException().Message;
            }
            logger.Info("Book added succesfully");
            return bookdata.AddBook(book);
        }

        public string GetBookById(int id)
        {
            logger.Info("Inside GetBookById method");
            if (id < 0)
            {
                logger.Error(new InvalidIdException());
                return new InvalidIdException().Message;
            }
            logger.Info("Returned Book By Id Successfully");
            return bookdata.getbyid(id);
        }

        public List<Book> GetBookList()
        {
            logger.Info("Returned Book List Successfully");
            return bookdata.getlist();
        }
        public string DeleteBook(int id)
        {
            logger.Info("Inside DeleteBook Method");
            if (id < 0)
            {
                logger.Error(new InvalidIdException());
                return new InvalidIdException().Message;
            }
            logger.Info("Book Deleted Successfully");
            return bookdata.DeleteBookById(id);
        }
        public string UpdateBook(int id, string newbookname)
        {
            logger.Info("Inside UpdateBook method");
            if (id < 0)
            {
                logger.Error(new InvalidIdException());
                return new InvalidIdException().Message;
            }

            if (newbookname.All(Char.IsLetter))
            {
                logger.Error(new InvalidBookNameException());
                return new InvalidBookNameException().Message;
            }
            logger.Info("Book Updated Successfully");
            return bookdata.UpdateBookName(id,newbookname);          
        }
    }
}
