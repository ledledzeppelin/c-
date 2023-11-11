using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 餐厅管理系统.data;

namespace 餐厅管理系统.database
{
    internal class ApplyDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 使用 MySQL 数据库提供程序和连接字符串
            optionsBuilder.UseMySql("Server=localhost;Database=res;User Id=root;Password=hf20030819;");
        }

        public DbSet<Restaurant> ResApplys{ get; set; } // 将 Resapplys 改为 Restaurants，更好地反映表的内容

        public void AddResApply(Restaurant newRestaurant)    // 添加餐厅，可以不上传餐厅头像，注册按钮使用
        {
            ResApplys.Add(newRestaurant);
            SaveChanges();
        }

      

        public void DeleteResApply(int restaurantId)  // 仅管理员能使用，删除相应的餐厅
        {
            var restaurantToDelete = ResApplys.Find(restaurantId);

            if (restaurantToDelete != null)
            {
                ResApplys.Remove(restaurantToDelete);
                SaveChanges();
            }
        }

    }
}
