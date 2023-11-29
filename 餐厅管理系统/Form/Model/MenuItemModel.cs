using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form.Model
{
    public class MenuItemModel
    {
        public string Name { get; set; }
        public Action Click { get; set; }
        public bool IsSelect { get; set; }
    }
}
