using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMeARoomMate.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace FindMeARoomMate.DataLayer.DBContext
{
    public class FindMeRoomMateDBContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Dormitories> Dormitories { get; set; }
        public DbSet<DormitoryStudent> DormitoryStudents { get; set; }
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Announcements> Announcements { get; set; }


        public FindMeRoomMateDBContext()
        { }

        public FindMeRoomMateDBContext(DbContextOptions<FindMeRoomMateDBContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8S5U7LB\SQLEXPRESS; Initial Catalog=FindMeRoomMate;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
