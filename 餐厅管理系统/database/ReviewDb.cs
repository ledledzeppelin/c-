using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using 餐厅管理系统.database;

namespace 餐厅管理系统
{
    internal class ReviewDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 配置数据库连接，使用 MySQL 数据库提供程序和连接字符串
            optionsBuilder.UseMySql("Server=localhost;Database=res;User Id=root;Password=hf20030819;");
        }

        public DbSet<Review> Reviews { get; set; }

       
        /// 增添用户评价
        public void AddReview(Review newReview)
        {
            // 将新用户评价对象添加到数据库集合
            Reviews.Add(newReview);

            // 保存更改到数据库
            SaveChanges();
        }

  

        
        public void DeleteReview(int reviewId)
        {
            // 查找要删除的用户评价
            var reviewToDelete = Reviews.Find(reviewId);

            if (reviewToDelete != null)
            {
                // 从数据库集合中移除用户评价
                Reviews.Remove(reviewToDelete);

                // 保存更改到数据库
                SaveChanges();
            }
        }
    }

}