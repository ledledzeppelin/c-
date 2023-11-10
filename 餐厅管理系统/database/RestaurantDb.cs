using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统.database
{
    internal class RestaurantDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 配置数据库连接，使用 MySQL 数据库提供程序和连接字符串
            optionsBuilder.UseMySql("Server=localhost;Database=res;User Id=root;Password=hf20030819;");
        }

        public DbSet<Restaurant> Restaurants { get; set; }

        
        /// 添加餐厅
       
        public void AddRestaurant(Restaurant newRestaurant)
        {
            // 将新餐厅对象添加到数据库集合
            Restaurants.Add(newRestaurant);

            // 保存更改到数据库
            SaveChanges();
        }

       
        public void DeleteRestaurant(int restaurantId)
        {
            // 查找要删除的餐厅
            var restaurantToDelete = Restaurants.Find(restaurantId);

            if (restaurantToDelete != null)
            {
                // 从数据库集合中移除餐厅
                Restaurants.Remove(restaurantToDelete);

                // 保存更改到数据库
                SaveChanges();
            }
        }
    }
}
