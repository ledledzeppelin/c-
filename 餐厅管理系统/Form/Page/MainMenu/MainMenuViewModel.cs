using Form.Config;
using Form.Model;
using Form.Page.AddDish;
using Form.Page.DishManage;
using Form.Page.Login;
using Form.Page.ResManage;
using Form.Page.ReviewManage;
using Form.Page.UserMain;
using Form.Page.UserManage;
using HandyControl.Controls;
using Stylet;
using Stylet.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form.Page.MainMenu
{
    public class MainMenuViewModel : Screen
    {
    	public MainMenuView SView { get; set; }
        public void Load()
        {
        	SView = this.View as MainMenuView;
            if (LoginViewModel.UserType == "用户")
            {
                SView.InitMenu(new List<MenuItemModel>() {
                    new MenuItemModel() { Name = "首页", Click = UserHome,IsSelect = true },
                });
                UserHome();
            }
            else if (LoginViewModel.UserType == "餐厅")
            {
                SView.InitMenu(new List<MenuItemModel>() {
                    new MenuItemModel() { Name = "添加菜品", Click = AddDish,IsSelect = true },
                });
                AddDish();
            }
            else
            {
                SView.InitMenu(new List<MenuItemModel>() {
                    new MenuItemModel() { Name = "菜品管理", Click = DishManage,IsSelect = true },
                    new MenuItemModel() { Name = "餐厅管理", Click = ResManage },
                    new MenuItemModel() { Name = "评价管理", Click = ReviewManage },
                    new MenuItemModel() { Name = "用户管理", Click = UserManage },
                });
                DishManage();
            }

        }
        public void DishManage()
        {
            SView.stkMain.Children.Clear();
            SView.stkMain.Children.Add(new DishManageView());
        }
        public void ResManage()
        {
            SView.stkMain.Children.Clear();
            SView.stkMain.Children.Add(new ResManageView());
        }
        public void ReviewManage()
        {
            SView.stkMain.Children.Clear();
            SView.stkMain.Children.Add(new ReviewManageView());
        }
        public void UserManage()
        {
            SView.stkMain.Children.Clear();
            SView.stkMain.Children.Add(new UserManageView());
        }

        public void AddDish() 
        {
            SView.stkMain.Children.Clear();
            SView.stkMain.Children.Add(new AddDishView(this,LoginViewModel.Restaurant));
        }

        public void UserHome()
        {
            SView.stkMain.Children.Clear();
            SView.stkMain.Children.Add(new UserMainView());
        }
        public void Close()
        {
            this.RequestClose();
        }

        public void Logout()
        {
            Boot.Manager.ShowWindow(new LoginViewModel());
            this.Close();
        }
    }
}