using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.database;
using System.Drawing;
using System.IO;
using System.Net;
using 餐厅管理系统;
using 餐厅管理系统.data;
using Microsoft.EntityFrameworkCore;
using 餐厅管理系统.controls;

/*
 * 封装了一些显示餐厅信息的函数，
 * 需要前端添加星星的素材（五个不同星级），并将星星路径修改到DisplayStarRating函数里
 */
namespace 餐厅管理系统.util
{
    internal class ResInfo
    {
        public ResInfo() { }

        // 根据餐厅id返回餐厅名称
        public static string GetResName(int resId)
        {
            string restaurantName;
            using (var context = new RestaurantDb())
            {
                // 查询数据库获取餐厅名字
                restaurantName = context.Restaurants
                .Where(r => r.RestaurantId == resId)
                .Select(r => r.Name)
                .FirstOrDefault();
            }
            return restaurantName;
        }
        // 根据餐厅id返回餐厅评级
        public static float GetResRate(int resId)
        {
            float rate;
            using (var context = new RestaurantDb())
            {
                // 查询数据库获取餐厅名字
                rate = context.Restaurants
                .Where(r => r.RestaurantId == resId)
                .Select(r => r.Rate)
                .FirstOrDefault();
            }
            return rate;
        }

        // 输入某个PictureBox和特定餐厅星级，根据星级显示星星数量
        public static void DisplayStarRating(float rate, PictureBox starPictureBox)
        {
            // 确保 rate 在合法范围内（0-5）
            rate = Math.Max(0, Math.Min(5, rate));

            // 根据 rate 设置星星图片
            /**
             * 需要添加星星素材
            string starImagePath = $"path_to_star_{rate}.png"; // 替换为实际的星星图片路径
            starPictureBox.Image = Image.FromFile(starImagePath);
            */
        }

        //
        public static string GetAddress(int resId)
        {
            string add;
            using (var context = new RestaurantDb())
            {
                // 查询数据库获取餐厅名字
                add = context.Restaurants
                .Where(r => r.RestaurantId == resId)
                .Select(r => r.Address)
                .FirstOrDefault();
            }
            return add;
        }

        /*
        *返回图片路径
        * 参数 mod 0-返回餐厅图片路径  1-返回菜品图片路径   2-返回用户头像图片路径
        */
        public static string GetImagePath(string fileName, int mod)
        {
            // 文件路径往上退两级
            string parentDirectory = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
            string imagePath;
            switch (mod)
            {
                //餐厅图片
                case 0:
                    imagePath = Path.Combine(parentDirectory, "image", "restaurantimage", fileName);
                    break;
                //菜品图片
                case 1:
                    imagePath = Path.Combine(parentDirectory, "image", "dishimage", fileName);
                    break;
                //用户头像
                case 2:
                    imagePath = Path.Combine(parentDirectory, "image", "userImage", fileName);
                    break;

                default: return null;
            }
            return imagePath;
        }

        // 向某个餐厅添加菜品
        public static void AddDishForRestaurant(int dishId, string dishName, string disPicture, decimal price, int restaurantId)
        {
            using (RestaurantDb db = new RestaurantDb())
            {

                // 创建一个新的菜品对象
                var newDish = new Dish
                {
                    // 设置菜品的属性
                    DishId = dishId,
                    Name = dishName,
                    DisPicture = disPicture,
                    Price = price,
                    //RestaurantId = restaurantId
                };
                
                db.AddDish(newDish);

                // 获取餐厅对象并更新菜单
                RestaurantDb restaurantDb = new RestaurantDb();
                var restaurantupdate = restaurantDb.Restaurants.Find(restaurantId);
                restaurantDb.Update(restaurantupdate);

                // 如果菜单为空，初始化菜单列表
                if (restaurantupdate.Menu == null)
                {
                    restaurantupdate.Menu = new List<Dish>();
                }

                // 添加菜品到菜单
                restaurantupdate.Menu.Add(newDish);
                restaurantDb.SaveChanges();

                // 保存更改到数据库
                db.SaveChanges();
                restaurantDb.Dispose();
            }
        }
        // 在 FormResDetailClient初始化网友评论 
        /*public static void LoadUserReviews(int resId,)
        {
            // 获取用户评价数据，这里假设有一个 UserReview 类存储评价信息
            List<Review> userReviews = GetRestaurantUserReviews(resId);

            // 清空现有的用户评价控件
            metroFlowLayoutPanelReviews.Controls.Clear();

            // 创建并添加 MetroUserReviewControl 控件
            foreach (UserReview review in userReviews)
            {
                MetroUserReviewControl reviewControl = new MetroUserReviewControl(
                    review.UserName,
                    review.ReviewContent,
                    review.UserImage,
                    review.ReviewImage);

                metroFlowLayoutPanelReviews.Controls.Add(reviewControl);
            }
        }*/

        /*private static List<Review> GetRestaurantUserReviews(int resId)
        {
            using (var context = new ReviewDb())
            {
                // 根据 RestaurantId 查询所有评论
                var reviews = context.Reviews
                    .Where(r => r.RestaurantId == resId)
                    .ToList();

                // 转换成 UserReview 对象
                var userReviews = reviews.Select(r => new Review
                {
                    UserName = r.UserId,  // 这里假设 UserId 就是用户名
                    ReviewContent = r.Comment,
                    Rating = r.Rating,
                    // 添加其他需要的属性...
                }).ToList();

                return userReviews;
            }*/

        /*public static List<Dish> GetDishesForRestaurant(int restaurantId)
        {
            using (var context = new DishDb())
            {
                // 根据 RestaurantId 查找所有相关的 Dish
                var dishesForRestaurant = context.Dishes
                    .Where(d => d.RestaurantId == restaurantId)
                    .ToList();

                return dishesForRestaurant;
            }
        }*/
        // 用户提交评论到数据库
        public static void AddCommentToDb(Review myReview)
        {
            using (var context = new RestaurantDb())
            {
                // 将评论添加到数据库
                context.Reviews.Add(myReview);
                context.SaveChanges();
            }
        }

        // 根据用户账号（userName）查找昵称NickName
        public static string GetUserNicknameByUserName(string userName)
        {
            using (var context = new UserDb())
            {
                var userNickname = context.Users
                    .Where(user => user.Username == userName)
                    .Select(user => user.Nickname)
                    .FirstOrDefault();

                return userNickname;
            }
        }

        // 更新评论区的显示
        public static void RefreshComment(CommentPanel commentPanel)
        {
            
        }
    }

}
