using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 餐厅管理系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newuser = new User();
            if(textBox1.Text!=null)
            {
                newuser.Nickname=textBox1.Text;
                if(textBox2.Text!=null)
                {
                    newuser.Username=textBox2.Text;
                    if (textBox3.Text !=null&&textBox3.Text==textBox4.Text) 
                    {
                        newuser.Password=textBox3.Text;
                        UserDb udb=new  UserDb();
                        udb.AddUser(newuser);
                        MessageBox.Show("注册成功");
                    
                    }
                    else { label6.Text = "密码与确认密码不一致"; }
                }
                else { label6.Text = "邮箱为空，请输入邮箱"; }
            }
            else { label6.Text = "昵称为空，请输入昵称"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
