using CoffeXO.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeXO.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<Dish> Dishes { get; set; }
    }
        
}
