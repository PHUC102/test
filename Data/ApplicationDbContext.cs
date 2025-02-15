using testbaithi.Models;
using Microsoft.EntityFrameworkCore;


namespace testbaithi.Data
{
    public class ApplicationDbContext : DbContext
    { 
        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        
}
}    