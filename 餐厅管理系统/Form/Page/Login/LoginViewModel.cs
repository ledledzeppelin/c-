using Form.Config;
using Form.Page.MainMenu;
using HandyControl.Controls;
using Microsoft.Win32;
using Stylet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Controls;
using System.Windows.Input;
using 餐厅管理系统;
using 餐厅管理系统.database;

namespace Form.Page.Login
{
    public class LoginViewModel : Screen
    {
        private LoginView _loginView { get; set; }
        public int Page { get; set; } = 1;
        public static string UserType { get; set; }
        public static Restaurant Restaurant{ get; set; }
        public static User User { get; set; }
        public void LoginPage()
        {
            Page = 1;
        }
        public void RegUserPage()
        {
            Page = 2;
        }
        public void RegResPage()
        {
            Page = 3;
        }
        public void Logon()
        {
            if(_loginView.cmbType.Text == "用户")
            {
                RegUserPage();
            }
            else
            {
                RegResPage();
            }
        }
        public void Login()
        {

            try
            {
                string username = _loginView.txtUsername.Text;
                string password = _loginView.txtPassword.Password;
                if (_loginView.cmbType.SelectedIndex == 0)
                {
                    UserType = "用户";
                    using (var context = new UserDb())
                    {
                        var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                        if (user != null)
                        {
                            User = user;
                            Boot.Manager.ShowWindow(new MainMenuViewModel());
                            this.Close();
                        }
                        else
                        {
                            // 用户验证失败，显示错误消息
                            Growl.InfoGlobal("登录失败。请检查用户名和密码。");
                        }
                    }
                }
                else
                {
                    UserType = "餐厅";
                    var context = new RestaurantDb();
                   // var con = new ApplyDb();
                    var user = context.Restaurants.FirstOrDefault(u => u.Account == username && u.Password == password);
                    var apply = context.ResApplys.FirstOrDefault(u => u.Account == username && u.Password == password);
                    if (user != null)
                    {
                        Restaurant = user;
                        Boot.Manager.ShowWindow(new MainMenuViewModel());
                        this.Close();
                    }
                    else if (apply != null)
                    {
                        Growl.InfoGlobal("注册申请尚未审核，请耐心等待");

                    }
                    else
                    {
                        Growl.InfoGlobal("尚未注册账户，请先注册");

                    }
                    //释放连接
                    context.Dispose();
                    //con.Dispose();
                }
            }
            catch (Exception ex)
            {
                Growl.InfoGlobal($"发生错误: {ex.Message}");
            }
        }
        public void AdminLogin()
        {
            if(_loginView.txtAdminKey.Text == "2021302111")
            {
                UserType = "管理员";
                Boot.Manager.ShowWindow(new MainMenuViewModel());
                this.Close();
            }
            else
            {

            }
        }
        public void Load()
        {
            _loginView = this.View as LoginView;
            _loginView.cmbType.SelectedIndex = 0;
        }

        public void Close()
        {
            this.RequestClose();
        }

        public void RegUser()
        {
            // 创建一个新的用户对象
            User newuser = new User();

            // 检查昵称是否为空
            if (!string.IsNullOrEmpty(_loginView.txtRegUserName.Text))
            {
                // 设置用户对象的昵称
                newuser.Nickname = _loginView.txtRegUserName.Text;

                // 检查邮箱是否为空
                if (!string.IsNullOrEmpty(_loginView.txtRegMail.Text))
                {
                    // 设置用户对象的邮箱
                    newuser.Username = _loginView.txtRegMail.Text;

                    // 检查密码是否不为空且与确认密码一致
                    if (!string.IsNullOrEmpty(_loginView.txtPsd.Password) && _loginView.txtPsd.Password == _loginView.txtCfmPsd.Password)
                    {
                        // 设置用户对象的密码
                        newuser.Password = _loginView.txtPsd.Password;
                        newuser.Location = _loginView.txtUserAddress.Text;
                        Boot.DB.Users.Add(newuser);
                        Boot.DB.SaveChanges();
                        Growl.InfoGlobal("注册成功");
                    }
                    else
                    {
                        // 显示密码与确认密码不一致的错误消息
                        Growl.InfoGlobal("密码与确认密码不一致");
                    }
                }
                else
                {
                    // 显示邮箱为空的错误消息
                    Growl.InfoGlobal("邮箱为空，请输入邮箱");
                }
            }
            else
            {
                // 显示昵称为空的错误消息
                Growl.InfoGlobal("昵称为空，请输入昵称");
            }
        }

        public void RegRes()
        {
            try
            {
                // 如果上传了图片
                if (_loginView.isPic.HasValue)
                {
                    var srcPath = _loginView.isPic.Uri.LocalPath;
                    // 设置餐厅图片的名字:以系统当前时间毫秒来命名
                    string dishImageName = Guid.NewGuid() + Path.GetExtension(srcPath);
                    var dstPath = Environment.CurrentDirectory + "\\image\\resimage\\";
                    if (!Directory.Exists(dstPath))
                    {
                        Directory.CreateDirectory(dstPath);
                    }
                    // 将上传的图片复制到指定目录
                    File.Copy(srcPath, dstPath + dishImageName);

                    // 创建餐厅对象并设置属性
                    Restaurant restaurant = new Restaurant();
                    restaurant.Name = _loginView.txtResName.Text;
                    restaurant.Account = _loginView.txtResNo.Text;
                    restaurant.Password = _loginView.txtResPsd.Password;
                    restaurant.Address = _loginView.txtResAddress.Text;
                    restaurant.ResPicture = dstPath + dishImageName;
                    // 将餐厅信息添加到数据库
                    Boot.DB.Restaurants.Add(restaurant);
                    Boot.DB.SaveChanges();
                    // 显示申请已提交消息
                    Growl.InfoGlobal("申请已提交，请耐心等待");
                }
            }
            catch (Exception ex)
            {
                Growl.InfoGlobal($"保存餐厅信息时发生错误: {ex.Message}");
            }
        }
    }
}
