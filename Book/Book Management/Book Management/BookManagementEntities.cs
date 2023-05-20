using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text.RegularExpressions;
using System.Web;
using Book_Management.Models;

namespace Book_Management
{
    public class BookManagementEntities : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}