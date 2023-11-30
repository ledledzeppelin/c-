using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 餐厅管理系统.data;

namespace 餐厅管理系统
{
    public class User
    {
        public int Id { get; set; } // 用户的唯一标识
        public string Username { get; set; } // 账号
        public string Password { get; set; } // 密码
        public string Nickname { get; set; } // 昵称
        public string ProfilePicture { get; set; } // 用二进制数据存储用户头像
        public string Location { get; set; } // 位置

        /*public int RestaurantId { get; set; }//收藏的餐厅
        public Restaurant Restaurant { get; set; }*/
    }

}
