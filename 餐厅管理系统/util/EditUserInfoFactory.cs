using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统.util
{
    // 具体工厂：编辑用户信息 
    internal class EditUserInfoFactory:EditInfoFactory
    {
        public override IEditInfo CreateEditInfo()
        {
            return new EditUserInfo();
        }
    }
}
