using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CodeFirst
{
    public class schoolContext: DbContext
    {
       public schoolContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
