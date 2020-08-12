using Microsoft.EntityFrameworkCore;
using WebApiPeople.Models;

namespace WebApiPeople.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {            
        }

        public DbSet<PeopleViewModel> People{ get; set; }
    }
}