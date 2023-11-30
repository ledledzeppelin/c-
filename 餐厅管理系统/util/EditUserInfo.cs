using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using 餐厅管理系统.winForm;

namespace 餐厅管理系统.util
{
    // 具体产品：编辑用户信息
    internal class EditUserInfo:IEditInfo
    {
        public void Edit(string userName,string nickName,Image image,string address)
        {
            FormEditUserOrResInfo myForm = new FormEditUserOrResInfo(userName, nickName, image, address, 0);
            myForm.ShowDialog();
        }
    }
}
