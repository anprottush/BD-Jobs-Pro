using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_Management.Repo
{
    public class Repo
    {
        protected BookManagementEntities db;
        protected Repo()
        {
            db = new BookManagementEntities();
        }
    }
}