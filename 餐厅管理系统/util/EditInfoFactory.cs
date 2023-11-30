using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 餐厅管理系统.util
{
    // 基类工厂： 编辑信息
    internal abstract class EditInfoFactory
    {
        public abstract IEditInfo CreateEditInfo();
    }
}
