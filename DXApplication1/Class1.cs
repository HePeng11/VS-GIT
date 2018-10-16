using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    public class ItemGroupView : BackstageViewControl
    {
        bool isLoad = false;
        public string GroupListId { get; set; }

        public string ItemTypeName { get; set; }

        public ItemGroupView() : base()
        {

        }

        private void Init()
        {

            if (UIHelper.IsDesignMode()) return;

          
            isLoad = true;
        }


    }
}
