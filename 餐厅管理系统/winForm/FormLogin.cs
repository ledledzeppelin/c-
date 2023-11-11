using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using 餐厅管理系统.database;

namespace 餐厅管理系统
{
   public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    this.Hide();
                    FormUseRegister myform = new FormUseRegister();   // 调用带参的构造函数
                    myform.Show();
                }
                else
                {
                    this.Hide();
                    FormResRegister myform = new FormResRegister();   // 调用带参的构造函数
                    myform.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox3.Text;
                string password = textBox4.Text;
                if (comboBox1.SelectedIndex == 0)
                {
                    using (var context = new UserDb())
                    {
                        var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                        if (user != null)
                        {
                            this.Hide();
                            Form3 myform = new Form3();   // 调用带参的构造函数
                            myform.Show();
                        }
                        else
                        {
                            // 用户验证失败，显示错误消息
                            MessageBox.Show("登录失败。请检查用户名和密码。");
                        }
                    }
                }
                else
                {
                    var context = new RestaurantDb();
                    var con = new ApplyDb();
                    var user = context.Restaurants.FirstOrDefault(u => u.Account == username && u.Password == password);
                    var apply = con.ResApplys.FirstOrDefault(u => u.Account == username && u.Password == password);

                    if (user != null)
                    {
                        this.Hide();
                        FormResEdit myform = new FormResEdit(user);   // 调用带参的构造函数
                        myform.Show();
                    }
                    else if (apply != null)
                    {
                        MessageBox.Show("注册申请尚未审核，请耐心等待");
                    }
                    else
                    {
                        MessageBox.Show("尚未注册账户，请先注册");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "2021302111")
                {
                    this.Hide();
                    FormAdministrator form4 = new FormAdministrator();   // 调用带参的构造函数
                    form4.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生错误: {ex.Message}");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
 
}
