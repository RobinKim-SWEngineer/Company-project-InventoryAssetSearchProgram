using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCZInventory.Interface
{
    interface ISelectionChangeNoticeControllable
    {
        public void DisableSelectionChangeNotice();
        public void EnableSelectionChangeNotice();
    }
}
