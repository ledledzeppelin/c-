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
using 餐厅管理系统.winForm;

namespace 餐厅管理系统.controls
{
    public partial class MyInfo : UserControl
    {
        public MyInfo()
        {
            InitializeComponent();
        }

        // 需要头像，昵称
        private Image _image;
        private string _nickName;
        private string _address;
        private string _userName;
        public string UserName
        {
            set { _userName = value; }
        }
        public string Address
        {
            set { _address = value; bunifuLabel4.Text = value; }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }
        public string NickName
        {
            get { return _nickName; }
            set { _nickName = value; LabelNickName.Text = value; }
        }

        private void bunifuButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            /**工厂模式
             * 选择修改用户信息的工厂
             */
            EditInfoFactory factory = new EditUserInfoFactory();
            // 使用工厂类创建产品
            IEditInfo editInfo = factory.CreateEditInfo();
            editInfo.Edit(_userName, _nickName, _image, _address,this);
        }
    }
}
