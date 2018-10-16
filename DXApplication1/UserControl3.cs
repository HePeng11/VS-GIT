using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            List<ParentUser> users = new List<ParentUser>();
            Guid gid = Guid.Empty;
            for (int i = 0; i < 5; i++)
            {
                var u = new ParentUser();
                u.ParentGuid = gid;
                gid = u.Guid;
                users.Add(u);
            }
            treeList1.KeyFieldName = "Guid";
            treeList1.ParentFieldName = "ParentGuid";
            this.treeList1.DataSource = users;
            treeList1.ExpandAll();
        }

    }
}
