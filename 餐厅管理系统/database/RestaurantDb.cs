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
                optionsBuilder.UseMySql("Server=localhost;Database=res;User Id=root;Password=448260lklk;");
            }

            public DbSet<Restaurant> Restaurants { get; set; }

            /// <summary>
            /// 添加餐厅：可以不上传餐厅头像，注册按钮使用
            /// </summary>
            /// <param name="newRestaurant">要添加的餐厅对象</param>
            public void AddRestaurant(Restaurant newRestaurant)
            {
                // 将新餐厅对象添加到数据库集合
                Restaurants.Add(newRestaurant);

                // 保存更改到数据库
                SaveChanges();
            }

            /// <summary>
            /// 仅管理员能使用，删除相应的餐厅
            /// </summary>
            /// <param name="restaurantId">要删除的餐厅的ID</param>
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
