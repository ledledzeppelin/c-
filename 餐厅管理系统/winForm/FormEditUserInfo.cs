using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.util;

namespace 餐厅管理系统.winForm
{
    public partial class FormEditUserInfo : MetroForm
    {
        public FormEditUserInfo(string nickName,Image image,string address)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

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
            // 修改昵称
            if(bunifuTextBox1.Text != "")
            {

            }
            // 修改地址
            if(bunifuTextBox2.Text != "") 
            {

            }
            //修改密码
            if((bunifuTextBox3.Text!="")&&(bunifuTextBox4.Text!="")&& (bunifuTextBox3.Text == bunifuTextBox4.Text))
            {

            }
        }
        // 上传新头像
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormEditUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
