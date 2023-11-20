using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 餐厅管理系统
{
    public partial class FormUseRegister : MetroForm
    {
        public FormUseRegister()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 在窗体加载时执行的代码（可留空）
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 创建一个新的用户对象
            User newuser = new User();

            // 检查昵称是否为空
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                // 设置用户对象的昵称
                newuser.Nickname = textBox1.Text;

                // 检查邮箱是否为空
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    // 设置用户对象的邮箱
                    newuser.Username = textBox2.Text;

                    // 检查密码是否不为空且与确认密码一致
                    if (!string.IsNullOrEmpty(textBox3.Text) && textBox3.Text == textBox4.Text)
                    {
                        // 设置用户对象的密码
                        newuser.Password = textBox3.Text;
                        newuser.Location=textBox5.Text;

                        // 创建 UserDb 对象用于数据库操作
                        using (UserDb udb = new UserDb())
                        {
                            // 调用 UserDb 中的 AddUser 方法将新用户添加到数据库
                            udb.AddUser(newuser);

                            // 显示注册成功消息
                            MessageBox.Show("注册成功");
                        }
                    }
                    else
                    {
                        // 显示密码与确认密码不一致的错误消息
                        MessageBox.Show( "密码与确认密码不一致");
                    }
                }
                else
                {
                    // 显示邮箱为空的错误消息
                    MessageBox.Show("邮箱为空，请输入邮箱");
                }
            }
            else
            {
                // 显示昵称为空的错误消息
                MessageBox.Show("昵称为空，请输入昵称");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 隐藏当前窗体并显示登录窗体
            FormLogin form = new FormLogin();
            this.Hide();
            form.ShowDialog();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 单击标签时执行的代码（可留空）
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // 文本框内容更改时执行的代码（可留空）
        }
    }

}
