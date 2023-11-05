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

namespace 餐厅管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 myform = new Form2();   //调用带参的构造函数
            myform.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox4.Text;

            using (var context = new  UserDb())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    this.Hide();
                    Form3 myform = new Form3();   //调用带参的构造函数
                    myform.Show();
                }
                else
                {
                    // 用户验证失败，显示错误消息
                    MessageBox.Show("登录失败。请检查用户名和密码。");
                }
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        /*private void button2_click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 myform = new Form2();   //调用带参的构造函数
            myform.Show();


        }*/
    }
}
