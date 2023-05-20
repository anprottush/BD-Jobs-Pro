using Book_Management.Interfaces;
using Book_Management.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Book_Management.Repo
{
    public class BookRepo : Repo, IRepo<Book, int, Book>
    {
        public bool Delete(int id)
        {
            var ext = db.Books.Find(id);
            db.Books.Remove(ext);
            return db.SaveChanges() > 0;
        }

        public List<Book> Get()
        {
            return db.Books.ToList();
        }

        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        public Book Insert(Book obj)
        {
            db.Books.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public Book Update(Book obj)
        {
            var dbojb = Get(obj.Id);
            db.Entry(dbojb).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}