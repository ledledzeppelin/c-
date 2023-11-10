using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统.database
{
    internal class ApplyDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 使用 MySQL 数据库提供程序和连接字符串
            optionsBuilder.UseMySql("Server=localhost;Database=res;User Id=root;Password=hf20030819;");
        }

        public DbSet<Restaurant> Resapplys{ get; set; } 

        public void AddResapply(Restaurant newRestaurant)    // 添加餐厅，可以不上传餐厅头像，注册按钮使用
        {
            Resapplys.Add(newRestaurant);
            SaveChanges();
        }

     

        public void DeleteResapply(int restaurantId)  // 仅管理员能使用，删除相应的餐厅
        {
            var restaurantToDelete = Resapplys.Find(restaurantId);

            if (restaurantToDelete != null)
            {
                Resapplys.Remove(restaurantToDelete);
                SaveChanges();
            }
        }

    }
}
