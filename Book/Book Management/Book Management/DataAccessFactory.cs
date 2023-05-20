using Book_Management.Interfaces;
using Book_Management.Models;
using Book_Management.Repo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Book_Management
{
    public class DataAccessFactory
    {
        public static IRepo<Book, int, Book> BookDataAccess()
        {
            return new BookRepo();
        }
    }
}