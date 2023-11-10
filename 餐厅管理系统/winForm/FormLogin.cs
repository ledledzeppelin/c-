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
using 餐厅管理系统.database;
using System.Reflection.Emit;

namespace 餐厅管理系统
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
          
        }

      

        private void button4_Click(object sender, EventArgs e)  //注册按钮
        {
            //用户注册
            if (comboBox1.SelectedIndex == 0)
            {
                this.Hide();
                FormUseRegister myform = new FormUseRegister();   //调用带参的构造函数
                myform.Show();
            }
            //商家注册
            else
            {
                this.Hide();
                FormResRegister myform = new FormResRegister();   //调用带参的构造函数
                myform.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)  //登录按钮
        {
            try
            {
                //用户登录
                string username = textBox3.Text;
                string password = textBox4.Text;
                if (comboBox1.SelectedIndex == 0)
                {
                    using (var context = new UserDb())
                    {
                        var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);  //访问数据库并匹配

                        if (user != null)
                        {
                            this.Hide();
                            Form3 myform = new Form3();   
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
                    //商家登录
                    var context = new RestaurantDb();
                    var con = new ApplyDb();
                    var user = context.Restaurants.FirstOrDefault(u => u.Name == username && u.Password == password);
                    var apply = con.Resapplys.FirstOrDefault(u => u.Name == username && u.Password == password);

                    if (user != null)
                    {
                        this.Hide();
                        FormResEdit myform = new FormResEdit(user);   // 调用带参的构造函数
                        myform.Show();
                    }
                    else if (user==null&&apply != null)
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



        private void button5_Click(object sender, EventArgs e) //管理员入口
        {
            
                if (textBox5.Text == "2021302111")
                {
                    this.Hide();
                    FormAdministrator form4 = new FormAdministrator();   // 调用带参的构造函数
                    form4.Show();
                }
                else
            {
                MessageBox.Show("密码错误");
            }
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
