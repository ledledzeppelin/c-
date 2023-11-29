using HandyControl.Controls;
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
using System.Windows.Shapes;
using 餐厅管理系统.data;
using 餐厅管理系统.database;

namespace Form.Page.AddDishWindow
{
    /// <summary>
    /// AddDishWndView.xaml 的交互逻辑
    /// </summary>
    public partial class AddDishWndView : System.Windows.Window
    {
        public AddDishWndView()
        {
            InitializeComponent();
            using(MainDb db = new MainDb())
            {
                var ds = db.Restaurants.ToList();
                foreach (var d in ds)
                {
                    cmbRes.Items.Add(new ComboBoxItem
                    {
                        Content = d.Name,
                        Tag = d.RestaurantId
                    });
                }
                cmbRes.SelectedIndex = 0;
            }
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            try
            {
                var r = cmbRes.SelectedItem as ComboBoxItem;
                var resName = r.Content.ToString();
                var resId = Convert.ToInt32(r.Tag);
                // 如果上传了图片
                if (isPic.HasValue)
                {
                    var srcPath = isPic.Uri.LocalPath;
                    using (DishDb db = new DishDb())
                    {
                        //设置菜品图片的名字: 以餐厅名 + 菜品名 + 后缀名
                        string dishImageName = resName + txtFoodName.Text + System.IO.Path.GetExtension(srcPath);
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
                        dish.RestaurantId = resId;
                        db.AddDish(dish);
                        Growl.InfoGlobal($"菜品上传成功");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Growl.InfoGlobal($"保存菜品信息时发生错误: {ex.Message}");
            }
        }
    }
}
