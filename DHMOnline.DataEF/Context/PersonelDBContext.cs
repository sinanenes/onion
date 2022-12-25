using DHMOnline.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.DataEF.Context
{
    public class PersonelDBContext:DbContext
    {
        public DbSet<Personel> Personel { get; set; }
        public DbSet<User> User { get; set; }
        public PersonelDBContext(DbContextOptions options) : base(options)
        {

        }
        //CodeFirst durumunda eklenir;
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
