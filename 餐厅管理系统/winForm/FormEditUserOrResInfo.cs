using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.data;
using 餐厅管理系统.database;
using 餐厅管理系统.util;

namespace 餐厅管理系统.winForm
{
    /**
     * 用户（普通用户、商家）通过此界面修改头像、昵称（商家名）、地址、密码
     * 传入模式参数UserOrRes,0-User 1-Res
     */
    public partial class FormEditUserOrResInfo : MetroForm
    {
        public FormEditUserOrResInfo(string UserName,string nickName,Image image,string address,int UserOrRes)
        {
            InitializeComponent();
            if(UserOrRes == 0 )//普通用户编辑昵称
            {
                bunifuLabel1.Text = "编辑昵称";
            }else if(UserOrRes == 1 )// 商家编辑商家名称
            {
                bunifuLabel1.Text = "商家名";
            }
            this.originalNickName = nickName;
            this.UserName = UserName;
            this.UserOrRes = UserOrRes;
            pictureBox1.Image = image;
        }
        private string originalNickName;
        private int UserOrRes;
        private string UserName;//用户或商家的UserName，便于查询修改
        private bool isUpLoadPicture = false;
        private string imagePath;
        // 上传的图片的后缀名
        private string empUpLoadPictureFormat;
        // OpenFileDialog 控件，用于选择上传的图片文件
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {
            if(bunifuTextBox3.Text == bunifuTextBox4.Text)
            {
                pictureBox3.Image = ResInfo.GetImage("对的.png", 3);
            }
            else
            {
                pictureBox3.Image = ResInfo.GetImage("错误.png", 3);
            }
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if(UserOrRes == 1)// 餐厅用户
            {
                using (var context = new RestaurantDb())
                {

                    // 根据Account 查询用户
                    var user = context.Restaurants.FirstOrDefault(u => u.Account == UserName);
                    // 修改昵称,newName初始值为原先昵称（餐厅名）
                    string newName = originalNickName;
                    if (bunifuTextBox1.Text != "")
                    {
                        newName = bunifuTextBox1.Text;
                        if (user != null)
                        {
                            // 更改属性
                            user.Name = newName;
                            // 保存更改
                            context.SaveChanges();
                        }
                    }

                    // 如果上传了图片，将新图片重命名并添加到文件夹中
                    // 新图片命名方式为 UserName属性值+NickName+时间+后缀
                    if (isUpLoadPicture)
                    {
                        //获取当前时间
                        DateTime currentTime = DateTime.Now;
                        DateTime roundedTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day,
                                                            currentTime.Hour, currentTime.Minute, currentTime.Second);
                        string formattedTime = roundedTime.ToString("yyyyMMdd_HHmmss");

                        // 获取当前应用程序的上级目录，用于保存图片
                        DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
                        // 当前工作路径
                        string filename = pname.Parent.Parent.FullName;
                        // 新图片名称
                        string newImageName = UserName  + formattedTime + "." + empUpLoadPictureFormat;
                        // 将上传的图片复制到指定目录
                        if (openFileDialog1.FileName != null)
                        {
                            File.Copy(imagePath, filename + "\\image\\restaurantimage\\" + newImageName, true);
                        }
                        // 保存到数据库
                        if (user != null)
                        {
                            // 更改属性
                            user.ResPicture = newImageName;
                            // 保存更改
                            context.SaveChanges();
                            //form.RefreshUserProfile(pictureBox1.Image);
                        }
                    }

                    string newAddress = "";
                    string newPassword = "";

                    // 修改地址
                    if (bunifuTextBox2.Text != "")
                    {
                        newAddress = bunifuTextBox2.Text;
                        if (user != null)
                        {
                            // 更改属性
                            user.Address = newAddress;
                            // 保存更改
                            context.SaveChanges();
                        }
                    }
                    //修改密码
                    if ((bunifuTextBox3.Text != "") && (bunifuTextBox4.Text != "") && 
                        (bunifuTextBox3.Text == bunifuTextBox4.Text)&&
                        ResInfo.ValidatePassword(bunifuTextBox4.Text))
                    {
                        newPassword = bunifuTextBox3.Text;
                        if (user != null)
                        {
                            // 更改属性
                            user.Password = newPassword;
                            // 保存更改
                            context.SaveChanges();
                        }
                    }
                }
            }else if(UserOrRes == 0) // 普通用户
            {
                using (var context = new UserDb())
                {

                    // 查询用户
                    var user = context.Users.FirstOrDefault(u => u.Username == UserName);
                    // 修改昵称
                    string newName = "";
                    if (bunifuTextBox1.Text != "")
                    {
                        newName = bunifuTextBox1.Text;
                        if (user != null)
                        {
                            // 更改属性
                            user.Nickname = newName;
                            // 保存更改
                            context.SaveChanges();
                        }
                    }

                    // 如果上传了图片，将新图片重命名并添加到文件夹中
                    // 新图片命名方式为 UserName属性值+NickName+时间+后缀
                    if (isUpLoadPicture)
                    {
                        //获取当前时间
                        DateTime currentTime = DateTime.Now;
                        DateTime roundedTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day,
                                                            currentTime.Hour, currentTime.Minute, currentTime.Second);
                        string formattedTime = roundedTime.ToString("yyyyMMdd_HHmmss");

                        // 获取当前应用程序的上级目录，用于保存图片
                        DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
                        // 当前工作路径
                        string filename = pname.Parent.Parent.FullName;
                        // 新图片名称
                        string newImageName = UserName + newName + formattedTime + "." + empUpLoadPictureFormat;
                        // 将上传的图片复制到指定目录
                        if (openFileDialog1.FileName != null)
                        {
                            File.Copy(imagePath, filename + "\\image\\userImage\\" + newImageName, true);
                        }
                        // 保存到数据库
                        if (user != null)
                        {
                            // 更改属性
                            user.ProfilePicture = newImageName;
                            // 保存更改
                            context.SaveChanges();
                        }
                    }

                    string newAddress = "";
                    string newPassword = "";

                    // 修改地址
                    if (bunifuTextBox2.Text != "")
                    {
                        newAddress = bunifuTextBox2.Text;
                        if (user != null)
                        {
                            // 更改属性
                            user.Location = newAddress;
                            // 保存更改
                            context.SaveChanges();
                        }
                    }
                    //修改密码
                    if ((bunifuTextBox3.Text != "") && (bunifuTextBox4.Text != "") && (bunifuTextBox3.Text == bunifuTextBox4.Text))
                    {
                        newPassword = bunifuTextBox3.Text;
                        if (user != null)
                        {
                            // 更改属性
                            user.Password = newPassword;
                            // 保存更改
                            context.SaveChanges();
                        }
                    }
                }
            }
            
        }
        // 上传新头像，获取头像位置
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // 设置文件过滤器，只允许选择特定格式的图片
                openFileDialog1.Filter = "*.jpg|*.jpg|*.png|*.png|*.bmp|*.bmp|*.tiff|*.tiff";

                // 如果用户点击了"确定"按钮
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        isUpLoadPicture = true; // 记录已上传图片，用于保存操作
                        string uploadpicture;
                        uploadpicture = openFileDialog1.FileName; // 图片的物理路径
                        String[] empImageData = uploadpicture.Split('.'); // 获取文件类型
                        empUpLoadPictureFormat = empImageData[empImageData.Length - 1]; // 上传的图片的后缀名
                        pictureBox1.Image = Image.FromFile(uploadpicture); // 将图片显示在 PictureBox 控件中
                        imagePath = openFileDialog1.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("您选择的图片不能被读取或文件类型不对！", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("上传相片出错: " + ex.Message);
            }
        }
        //输入密码时确保密码符合格式
        private void bunifuTextBox4_TextChange(object sender, EventArgs e)
        {
            if (ResInfo.ValidatePassword(bunifuTextBox4.Text))
            {
                label1.Text = "格式正确！";
            }
            else
            {
                label1.Text = "密码至少包含一个字母和一个数字，总长度至少为8个字符！";
            }
        }
    }
}
