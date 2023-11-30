using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.database;
using 餐厅管理系统.util;

namespace 餐厅管理系统.winForm
{
    public partial class FormMainMetro : MetroForm
    {
        public FormMainMetro(string userName)
        {
            InitializeComponent();
            mainPanel1.UserName = userName;
            
            using(var context = new UserDb())
            {
                string nickname = context.Users
                    .Where(u => u.Username == userName)
                    .Select(u => u.Nickname)
                    .FirstOrDefault();
                mainPanel1.NickName = nickname;
                string imageName = context.Users
                    .Where(u => u.Username == userName)
                    .Select(u => u.ProfilePicture)
                    .FirstOrDefault();
                string address = context.Users
                    .Where(u => u.Username == userName)
                    .Select(u => u.Location)
                    .FirstOrDefault();
                // 用户头像
                Image image = ResInfo.GetImage(imageName, 2);
                mainPanel1.MyProfileImage = image;
                mainPanel1.Address = address;
            }
            mainPanel1.InitializeRes();
        }
        //刷新用户头像
       public void RefreshUserProfile(Image image)
        {
            mainPanel1.RefreshUserProfile(image);
        }
    }
}
