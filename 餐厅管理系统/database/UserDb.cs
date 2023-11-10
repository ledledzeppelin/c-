using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace 餐厅管理系统
{
    internal class UserDb : DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 使用 MySQL 数据库提供程序和连接字符串
            optionsBuilder.UseMySql("Server=localhost;Database=res;User Id=root;Password=hf20030819;");
        }
        public DbSet<User> Users { get; set; }

        //用户图片所在的文件夹：Application.StartupPath是应用程序当前路径
        public void AddUser(User newuser)    //增添用户：可以不上传用户头像，注册按钮使用
        {
            if (newuser.ProfilePicture == null)
            {
                newuser.ProfilePicture = "Almanac_IndexBack.jpg";
            }
            Users.Add(newuser);
            SaveChanges();
        }

     

        public void DeleteUser(int dishid)  //仅管理员能使用，删除相应的账号
        {

            var studentToDelete = Users.Find(dishid);
            if (studentToDelete != null)
            {
                Users.Remove(studentToDelete);
                SaveChanges();

            }
        }
    }
}