using MySite.Models;
using Microsoft.EntityFrameworkCore;

namespace MySite.Data
{
    public class CMSContext : DbContext
    {
        public CMSContext(DbContextOptions<CMSContext> options) : base(options)
        {
        }

        public DbSet<Page> Page { get; set; }
    }
}