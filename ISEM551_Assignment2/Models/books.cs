using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ISEM551_Assignment2.Models
{
    public class books
    {
        [Key]
        public int book_id { get; set; }
        public string book_name { get; set; }
        public string author { get; set; }
        public string type { get; set; }
        public byte[] cover_img { get; set; }
        public string link { get; set; }
        public string added_by_id { get; set; }
        public string date { get; set; }
    }

    public class BookDbContext : DbContext
    {
        public DbSet<books> books { get; set; }
    }
}