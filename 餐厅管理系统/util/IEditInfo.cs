using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统.util
{
    // 产品接口：编辑信息
    public interface IEditInfo
    {
        void Edit(string userName, string nickName, Image image, string address);
    }
}
