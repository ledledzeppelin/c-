using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 餐厅管理系统.winForm;

namespace 餐厅管理系统.util
{
    // 具体产品：编辑餐厅信息
    internal class EditResInfo:IEditInfo
    {
        public void Edit(string userName, string nickName, Image image, string address,Object formResMain)
        {
            FormEditResInfo myForm = new FormEditResInfo(userName, nickName, image, address,(FormResMain)formResMain);
            myForm.ShowDialog();
        }
    }
}
