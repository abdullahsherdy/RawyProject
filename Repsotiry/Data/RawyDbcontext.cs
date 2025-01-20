using core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Repsotiry.Data
{
    public class RawyDbcontext:DbContext
    {
        public RawyDbcontext(DbContextOptions<RawyDbcontext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Aurthor> Aurthors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Catygory> catygorys { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Teller> Tellers { get; set; }





    }
}
