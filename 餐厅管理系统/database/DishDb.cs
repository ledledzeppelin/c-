using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 餐厅管理系统.data;

namespace 餐厅管理系统.database
{
    internal class DishDb:DbContext
    {
       
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                // 配置数据库连接，使用 MySQL 数据库提供程序和连接字符串
                optionsBuilder.UseMySql("Server=localhost;Database=res;User Id=root;Password=hf20030819;");
            }

            public DbSet<Dish> Dishes { get; set; }

            /// <summary>
            /// 增添用户：可以不上传用户头像，注册按钮使用
            /// </summary>
            /// <param name="newDish">要添加的菜品对象</param>
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
        

    }
}
