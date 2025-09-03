using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SafetyReminderWF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Compliance> Compliance { get; set; }
        public AppDbContext() { } // EF design-time can use this if OnConfiguring is present
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        private const string ConnStr =
            "Server=localhost; Database=safety_reminder; User Id=root; Password=Kossan@123456;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = ServerVersion.AutoDetect(ConnStr);
            optionsBuilder.UseMySql(ConnStr, serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compliance>(eb =>
            {
                eb.HasKey(x => x.Id);
                eb.Property(x => x.Assessment).HasMaxLength(200);
                eb.Property(x => x.Fee).HasColumnType("decimal(10,2)");
                eb.Property(x => x.CurrentDT).HasColumnType("dateTime(6)");
                eb.Property(x => x.UpComingDT).HasColumnType("dateTime(6)");

            });
        }
    }
}
