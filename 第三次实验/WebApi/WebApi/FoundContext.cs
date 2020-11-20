using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebApi.Model;


namespace WebApi
{
    public class FoundContext : DbContext
    {
        public static string Connection { get; set; }
        public FoundContext(DbContextOptions<FoundContext> options)
            : base(options)
        {
        }
        public FoundContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //连接数据库
            optionsBuilder.UseSqlServer(Connection);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //用model对象绑定到数据库，以便可以操作数据库
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }
        //设置可以访问的数据库表
        public DbSet<t_lostgoods> t_lostgoods { get; set; }
        public DbSet<t_user> t_user { get; set; }
    }
}
