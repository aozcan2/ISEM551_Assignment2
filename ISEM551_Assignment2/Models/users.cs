using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ISEM551_Assignment2.Models
{
    public class users
    {
        [Key]
        public int user_id {get; set;}
        public string user_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
    }

    public class UsersDbContext : DbContext{
        public DbSet<users> users { get; set; }
    }
}