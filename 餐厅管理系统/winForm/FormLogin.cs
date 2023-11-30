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
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroSet_UI.Forms;
using 餐厅管理系统.winForm;
using 餐厅管理系统.util;

namespace 餐厅管理系统
{
   public partial class FormLogin : MetroForm
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
                    FormUseRegister myform = new FormUseRegister();   // 调用带参的构造函数
                    this.Hide();
                    myform.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    FormResRegister myform = new FormResRegister();   // 调用带参的构造函数
                    this.Hide();
                    myform.ShowDialog();
                    this.Dispose();
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
                ILoginStrategy loginStrategy = null;

                if (comboBox1.SelectedIndex == 0)
                {
                    loginStrategy = new UserLoginStrategy();
                }
                else
                {
                    loginStrategy = new RestaurantLoginStrategy();
                }

                bool isValidUser = loginStrategy.Validate(username, password);

                if (isValidUser)
                {
                    if (loginStrategy is UserLoginStrategy)
                    {
                        FormMainMetro myform = new FormMainMetro(username);
                        this.Hide();
                        myform.ShowDialog();
                        this.Dispose();
                    }
                    else if (loginStrategy is RestaurantLoginStrategy)
                    {
                        var context = new RestaurantDb();
                        var apply = context.ResApplys.FirstOrDefault(u => u.Account == username && u.Password == password);
                        var user = context.Restaurants.FirstOrDefault(u => u.Account == username && u.Password == password);
                        if (apply != null)
                        {
                            MessageBox.Show("注册申请尚未审核，请耐心等待");
                        }
                        else if(user!=null)
                        {
                            FormResMain myform = new FormResMain(user);
                            this.Hide();
                            myform.ShowDialog();
                            this.Dispose();
                        }
                        else { MessageBox.Show("尚未注册账户，请先注册"); }

                        context.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("登录失败。请检查用户名和密码。");
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
                    FormAdministrator form4 = new FormAdministrator();   // 调用带参的构造函数
                    this.Hide();
                    form4.ShowDialog();
                    this.Dispose();
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

        private void button6_Click(object sender, EventArgs e)
        {
            FormMainMetro form4 = new FormMainMetro("1");
            this.Hide();
            form4.ShowDialog();
            this.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormMainMetro form4 = new FormMainMetro("1");
            this.Hide();
            form4.ShowDialog();
            this.Dispose();
        }
    }
 
}
