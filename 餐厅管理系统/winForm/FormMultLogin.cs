using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sunny.UI.IdentityCard;
using static 餐厅管理系统.winForm.FormShadow;
using 餐厅管理系统.database;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using System.IO;
using System.Xml.Linq;

namespace 餐厅管理系统.winForm
{
    public partial class FormMultLogin : Form
    {
        public static string UserType = "";
        public static User User = null;
        public static Restaurant Restaurant = null;
        bool isUpLoadPicture = false;
        string empUpLoadPictureFormat = "";
        private string imagePath = "";

        bool isUpLoadPictureU = false;
        string empUpLoadPictureFormatU = "";
        private string imagePathU = "";
        private static System.Drawing.Text.PrivateFontCollection pfcc;
        public static System.Drawing.Text.PrivateFontCollection PFCC
        {
            get { return pfcc ?? LoadFont(); }
        }
        private Point position;//定位
        public FormMultLogin()
        {
            InitializeComponent();
            button1.Text = "\xe680";
            button1.Font = new Font(PFCC.Families[0], 13);
            button2.Text = "\xe682";
            button2.Font = new Font(PFCC.Families[0], 13);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            pnlLogin.BackColor = Color.FromArgb(200, Color.White);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public static System.Drawing.Text.PrivateFontCollection LoadFont()
        {
            pfcc = new System.Drawing.Text.PrivateFontCollection();
            pfcc.AddFontFile(Environment.CurrentDirectory + "/iconfont.ttf");
            return pfcc;
        }
        private void FormMultLogin_MouseDown(object sender, MouseEventArgs e)
        {
            position = e.Location;
        }

        private void FormMultLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                this.Location = new Point(this.Left + (e.X - position.X), this.Top + (e.Y - position.Y));
        }

        private void FormMultLogin_MouseUp(object sender, MouseEventArgs e)
        {
            position = e.Location;
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            // 创建 OpenFileDialog 对象
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 设置文件对话框的属性
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image";

                // 显示文件对话框
                DialogResult result = openFileDialog.ShowDialog();

                // 如果用户选择了文件，则更新按钮的背景图片
                if (result == DialogResult.OK)
                {
                    string uploadpicture;
                    uploadpicture = openFileDialog.FileName; // 图片的物理路径
                    String[] empImageData = uploadpicture.Split('.'); // 获取文件类型
                    empUpLoadPictureFormat = empImageData[empImageData.Length - 1]; // 上传的图片的后缀名
                    imagePath = openFileDialog.FileName;
                    Image image = Image.FromFile(imagePath);
                    btn.BackgroundImage = image;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    isUpLoadPicture = true;
                }
            }
        }

        private void btnUserPic_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            // 创建 OpenFileDialog 对象
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 设置文件对话框的属性
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image";

                // 显示文件对话框
                DialogResult result = openFileDialog.ShowDialog();

                // 如果用户选择了文件，则更新按钮的背景图片
                if (result == DialogResult.OK)
                {
                    string uploadpicture;
                    uploadpicture = openFileDialog.FileName; // 图片的物理路径
                    String[] empImageData = uploadpicture.Split('.'); // 获取文件类型
                    empUpLoadPictureFormatU = empImageData[empImageData.Length - 1]; // 上传的图片的后缀名
                    imagePathU = openFileDialog.FileName;
                    Image image = Image.FromFile(imagePathU);
                    btn.BackgroundImage = image;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    isUpLoadPictureU = true;
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var type = cbxType.Text;
            if(type == "用户")
            {
                pnlLogin.Visible = false;
                pnlRegUser.Visible = true;
            }
            else
            {
                pnlLogin.Visible = false;
                pnlRegRes.Visible = true;
            }
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlRegUser.Visible = false;
            pnlRegRes.Visible = false;
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdminPsd.Text == "2021302111")
                {
                    FormAdmin form = new FormAdmin();
                    this.Hide();
                    form.Show(this);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog($"发生错误: {ex.Message}");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUser.Text;
                string password = txtPassword.Text;
                if (cbxType.SelectedIndex == 0)
                {
                    UserType = "用户";
                    var user = Program.DB.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                    if (user != null)
                    {
                        User = user;
                        FormMainMetro myform = new FormMainMetro(User.Username);   // 调用带参的构造函数
                        this.Hide();
                        myform.Show();
                    }
                    else
                    {
                        // 用户验证失败，显示错误消息
                        this.ShowErrorDialog("登录失败。请检查用户名和密码。");
                    }
                }
                else
                {
                    UserType = "餐厅";
                    var context = new RestaurantDb();
                    var con = new RestaurantDb();
                    var user = context.Restaurants.FirstOrDefault(u => u.Account == username && u.Password == password);
                    var apply = con.ResApplys.FirstOrDefault(u => u.Account == username && u.Password == password);
                    if (user != null)
                    {
                        FormResMain myform = new FormResMain(user);   // 调用带参的构造函数
                        this.Hide();
                        myform.Show();
                    }
                    else if (apply != null)
                    {
                        this.ShowErrorDialog("注册申请尚未审核，请耐心等待");
                    }
                    else
                    {
                        this.ShowErrorDialog("尚未注册账户，请先注册");
                    }
                    //释放连接
                    context.Dispose();
                    con.Dispose();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog($"发生错误: {ex.Message}");
            }
        }

        private void btnRegRes_Click(object sender, EventArgs e)
        {
            try
            {
                // 如果上传了图片
                if (isUpLoadPicture)
                {
                    var srcPath = imagePath;
                    string imgName = Path.GetFileNameWithoutExtension(srcPath) + "." + empUpLoadPictureFormat;
                    // 获取当前应用程序的上级目录，用于保存图片
                    DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
                    string filename = pname.Parent.Parent.FullName;
                    // 将上传的图片复制到指定目录
                    File.Copy(imagePath, filename + "\\image\\restaurantimage\\" + imgName);
                    // 创建餐厅对象并设置属性
                    Restaurant restaurant = new Restaurant();
                    restaurant.Name = txtRegResName.Text;
                    restaurant.Account = txtRegResAcc.Text;
                    restaurant.Password = txtRegResPsd.Text;
                    restaurant.Address = txtRegResAdd.Text;
                    restaurant.ResPicture = imgName;
                    // 将餐厅信息添加到数据库
                    Program.DB.Restaurants.Add(restaurant);
                    Program.DB.SaveChanges();
                    // 显示申请已提交消息
                    this.ShowMessageDialog("申请已提交，请耐心等待","提示", false, UIStyle.Blue);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorDialog($"保存餐厅信息时发生错误: {ex.Message}");
            }
        }

        private void btnRegUser_Click(object sender, EventArgs e)
        {
            User newuser = new User();
            // 如果上传了图片
            if (isUpLoadPictureU)
            {
                var srcPath = imagePathU;
                string imgName = Path.GetFileNameWithoutExtension(srcPath) + "." + empUpLoadPictureFormatU;
                // 获取当前应用程序的上级目录，用于保存图片
                DirectoryInfo pname = new DirectoryInfo(Application.StartupPath);
                string filename = pname.Parent.Parent.FullName;
                // 将上传的图片复制到指定目录
                File.Copy(imagePathU, filename + "\\image\\userImage\\" + imgName);
                newuser.ProfilePicture = imgName;
                // 检查昵称是否为空
                if (!string.IsNullOrEmpty(txtRegUseNickName.Text) && !string.IsNullOrEmpty(txtRegUserAcc.Text))
                {
                    // 设置用户对象的昵称
                    newuser.Username = txtRegUserAcc.Text;
                    newuser.Nickname = txtRegUseNickName.Text;
                    // 检查密码是否不为空且与确认密码一致
                    if (!string.IsNullOrEmpty(txtRegUserPsd.Text) && txtRegUserPsd.Text == txtRegUserCPsd.Text)
                    {
                        // 设置用户对象的密码
                        newuser.Password = txtRegUserPsd.Text;
                        newuser.Location = txtRegUserAdd.Text;
                        Program.DB.Users.Add(newuser);
                        Program.DB.SaveChanges();
                        this.ShowMessageDialog("注册成功", "提示", false, UIStyle.Blue);
                    }
                    else
                    {
                        // 显示密码与确认密码不一致的错误消息
                        this.ShowErrorDialog("密码与确认密码不一致");
                    }
                }
                else
                {
                    // 显示昵称为空的错误消息
                    this.ShowErrorDialog("昵称或账号为空，请输入昵称");
                }
            }
            else
            {
                this.ShowErrorDialog("必须上传头像！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }
}
