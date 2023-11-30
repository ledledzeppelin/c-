using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using 餐厅管理系统.data;

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
        public DbSet<ResApply> ResApplys { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Dish>()
             .HasOne(d => d.Restaurant) // 一个菜品属于一个餐厅
             .WithMany(r => r.Menu) // 一个餐厅有多个菜品
             .HasForeignKey(d => d.RestaurantId); // 使用外键 RestaurantId

            // 配置 Restaurant 和 Review 之间的关联关系
            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Reviews) // 一个餐厅有多个评论
                .WithOne(r => r.Restaurant) // 一个评论属于一个餐厅
                .HasForeignKey(r => r.RestaurantId);
        }

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


        public void AddDish(Dish newDish)
        {
            // 将新菜品对象添加到数据库集合
            Dishes.Add(newDish);

            // 保存更改到数据库
            SaveChanges();
        }



        /// <summary>
        /// 仅管理员能使用，删除相应的菜品
        /// </summary>
        /// <param name="dishId">要删除的菜品的ID</param>
        public void DeleteDish(int dishId)
        {
            // 查找要删除的菜品
            var dishToDelete = Dishes.Find(dishId);

            if (dishToDelete != null)
            {
                // 从数据库集合中移除菜品
                Dishes.Remove(dishToDelete);

                // 保存更改到数据库
                SaveChanges();
            }
        }

        

        public void AddReview(Review newReview)
        {
            // 将新用户评价对象添加到数据库集合
            Reviews.Add(newReview);

            // 保存更改到数据库
            SaveChanges();
        }


        /// 仅管理员能使用，删除相应的用户评价
        /// </summary>
        /// <param name="reviewId">要删除的用户评价的ID</param>
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

        public void AddResApply(ResApply newRestaurant)    // 添加餐厅，可以不上传餐厅头像，注册按钮使用
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
