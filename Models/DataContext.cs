using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Test_WAD.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Test_WAD")
        {
        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Faculty> Faculties { get; set; }

        public System.Data.Entity.DbSet<Test_WAD.Models.Exam> Exams { get; set; }
    }
}