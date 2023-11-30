using Form.Config;
using Form.Page.DishDetail;
using Form.Page.Login;
using Form.Page.MainMenu;
using Form.Page.ResDetail;
using HandyControl.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 餐厅管理系统;
using 餐厅管理系统.data;
using 餐厅管理系统.database;
using Path = System.IO.Path;

namespace Form.Page.AddDish
{
    /// <summary>
    /// AddDishView.xaml 的交互逻辑
    /// </summary>
    public partial class AddDishView : UserControl
    {
        // 餐厅对象
        Restaurant res;
        public MainMenuViewModel MainMenuViewModel { get; set; }
        public AddDishView(MainMenuViewModel mainMenuViewModel, Restaurant res)
        {
            InitializeComponent();
            MainMenuViewModel = mainMenuViewModel;
            this.res = res;
            LoadDishMenu();
        }
        public void LoadDishMenu()
        {
            using (DishDb db = new DishDb())
            {
                dgdDishMenu.ItemsSource = db.Dishes.Where(x => x.RestaurantId == res.RestaurantId).ToList();
            }
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            try
            {
                // 如果上传了图片
                if (isPic.HasValue)
                {
                    var srcPath = isPic.Uri.LocalPath;
                    using (DishDb db = new DishDb())
                    {
                        //设置菜品图片的名字: 以餐厅名 + 菜品名 + 后缀名
                        string dishImageName = res.Name + txtFoodName.Text + Path.GetExtension(srcPath);
                        var dstPath = Environment.CurrentDirectory + "\\image\\dishimage\\";
                        if (!Directory.Exists(dstPath))
                        {
                            Directory.CreateDirectory(dstPath);
                        }
                        // 将上传的图片复制到指定目录
                        File.Copy(srcPath, dstPath + dishImageName);

                        // 创建菜品对象并设置属性
                        Dish dish = new Dish();
                        dish.DisPicture = dstPath + dishImageName;
                        dish.Price = decimal.Parse(txtFoodPrice.Text);
                        dish.Name = txtFoodName.Text;
                        dish.RestaurantId = res.RestaurantId;
                        db.AddDish(dish);
                        Growl.InfoGlobal($"菜品上传成功");
                        LoadDishMenu();
                    }
                }
            }
            catch (Exception ex)
            {
                Growl.InfoGlobal($"保存菜品信息时发生错误: {ex.Message}");
            }
        }

        private void BackLogin(object sender, RoutedEventArgs e)
        {
            Boot.Manager.ShowWindow(new LoginViewModel());
            MainMenuViewModel.Close();
        }

        private void Detail(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            new DishDetailView(btn.CommandParameter).ShowDialog();
        }
    }
}
