using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统
{
    internal class User
    {
        public int Id { get; set; } // 用户的唯一标识
        public string Username { get; set; } // 账号
        public string Password { get; set; } // 密码
        public string Nickname { get; set; } // 昵称
        public string ProfilePicture { get; set; } // 用二进制数据存储用户头像
        public string Location { get; set; } // 位置

        // 构造函数、方法等

        // 可以根据需要添加其他属性和方法
    }

}
