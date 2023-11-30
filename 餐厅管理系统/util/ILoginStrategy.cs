using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 餐厅管理系统.database;

namespace 餐厅管理系统.util
{
    public interface ILoginStrategy
    {
        bool Validate(string username, string password);
    }
    public class UserLoginStrategy : ILoginStrategy
    {
        public bool Validate(string username, string password)
        {
            using (var context = new UserDb())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                return user != null;
            }
        }
    }

    public class RestaurantLoginStrategy : ILoginStrategy
    {
        public bool Validate(string username, string password)
        {
            using (var context = new RestaurantDb())
            {
                var user = context.Restaurants.FirstOrDefault(u => u.Account == username && u.Password == password);
                return user != null;
            }
        }
    }

}
