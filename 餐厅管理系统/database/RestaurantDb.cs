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
            // 使用 MySQL 数据库提供程序和连接字符串
            optionsBuilder.UseMySql("Server=localhost;Database=classes;User Id=root;Password=hf20030819;");
        }
        public DbSet<Restaurant> Restaurants { get; set; }

        public void AddUser(Restaurant newReviews)    //增添用户：可以不上传用户头像，注册按钮使用
        {

            Restaurants.Add(newReviews);
            SaveChanges();
        }

        public void UpdateUser(Restaurant updatedReviews)  //每次用户修改数据时使用，如修改密码，修改昵称
        {
            Restaurants.Update(updatedReviews);
            SaveChanges();
        }

        public void DeleteUser(int dishid)  //仅管理员能使用，删除相应的账号
        {

            var studentToDelete = Restaurants.Find(dishid);
            if (studentToDelete != null)
            {
                Restaurants.Remove(studentToDelete);
                SaveChanges();

            }
        }
    }
}
